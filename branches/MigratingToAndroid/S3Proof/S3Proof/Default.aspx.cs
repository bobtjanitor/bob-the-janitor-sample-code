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
        private AmazonS3 _s3Client;
        public AmazonS3 S3Client
        {
            get
            {
                if (_s3Client==null)
                {
                    _s3Client = AWSClientFactory.CreateAmazonS3Client(
                        ConfigurationManager.AppSettings["AWSAccessKey"],
                        ConfigurationManager.AppSettings["AWSSecretKey"]);
                }
                return _s3Client;
            }
            set { _s3Client = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayImageList();
            }
        }

        private void DisplayImageList()
        {
            ListBucketsResponse response = S3Client.ListBuckets();
               
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
                ListObjectsResponse imageList = S3Client.ListObjects(request);

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


                    imageLink.HRef = S3Client.GetPreSignedURL(preSignedUrlRequest);
                    DivlistOfImages.Controls.Add(imageLink);
                }
            }
        }

        protected void buttonuploadImage_click(object sender, EventArgs e)
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = "TruckstopImages";
            request.Key = imageUpload.FileName;
            request.InputStream = imageUpload.FileContent;

            S3Client.PutObject(request);
            

            DisplayImageList();
        }
    }
}