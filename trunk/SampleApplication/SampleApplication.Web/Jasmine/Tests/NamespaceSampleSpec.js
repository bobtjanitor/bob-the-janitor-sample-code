describe("sampleNamespace_Tests", function () {

    var testValue;
    var newTestValue;

    beforeEach(function () {
        testValue = "Test Value";
        newTestValue = "New Value";
        $(document).ready(function () {
            sampleNamespace.init({ TestValue: testValue });
        });

    });

    it("Returns expected Test Value", function () {
        var value = sampleNamespace.getTestValue();
        expect(value).toBe(testValue);
    });

    it("Returns updated Test Value", function () {
        sampleNamespace.updateTestValue(newTestValue);
        var value = sampleNamespace.getTestValue();
        expect(value).toBe(newTestValue);
    });

    it("test", function () {
        expect(true).toBe(true);
    });

});