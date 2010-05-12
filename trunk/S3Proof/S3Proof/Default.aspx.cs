using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace S3Proof
{
    public partial class S3Images : Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            AmazonS3 s3Client = AWSClientFactory.CreateAmazonS3Client(
                ConfigurationManager.AppSettings["AWSAccessKey"],
                ConfigurationManager.AppSettings["AWSSecretKey"]);

            ListBucketsResponse response = s3Client.ListBuckets();
               
            foreach (S3Bucket bucket in response.Buckets)
            {
                HtmlGenericControl header = new HtmlGenericControl("div")
                {
                    InnerText = bucket.BucketName
                };

                DivlistOfImages.Controls.Add(header);

                ListObjectsRequest request = new ListObjectsRequest
                 {
                     BucketName = bucket.BucketName
                 };
                ListObjectsResponse imageList = s3Client.ListObjects(request);

                foreach (S3Object s3Object in imageList.S3Objects)
                {
                    HtmlAnchor imageLink = new HtmlAnchor
                   {
                       InnerText = s3Object.Key
                   };
                    string bucketName = bucket.BucketName;
                    string objectKey = s3Object.Key;
                    GetPreSignedUrlRequest preSignedUrlRequest = new GetPreSignedUrlRequest
                     {
                         BucketName = bucketName,
                         Key = objectKey,
                         Protocol = Protocol.HTTP,
                         Expires = DateTime.Now.AddDays(7)
                     };


                    imageLink.HRef = s3Client.GetPreSignedURL(preSignedUrlRequest);
                    DivlistOfImages.Controls.Add(imageLink);
                }
            }
        }
    }
}