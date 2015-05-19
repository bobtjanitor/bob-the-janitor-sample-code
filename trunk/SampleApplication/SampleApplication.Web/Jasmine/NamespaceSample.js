(function (sampleNamespace, $, undefined) {
    
    var settings;

    sampleNamespace.init = function (options) {
        settings = options;
    };

    sampleNamespace.getTestValue = function () {
         return settings.TestValue;
    };


    sampleNamespace.updateTestValue = function(newValue) {
        settings.TestValue = newValue;
    };
    
}(window.sampleNamespace = window.sampleNamespace || {}, jQuery));

