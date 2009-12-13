var Control;
var selectedOptionValue;

function dropDownRequest_onSuccess(result) {
    Control.options.length = 0;
    for (var x = 0; x < result.length; x++) {
        var opt = document.createElement("option");
        opt.text = result[x].Text;
        opt.value = result[x].Value;
        if (result[x].Value == selectedOptionValue) {
            opt.setAttribute("selected", "true");
        }
        Control.options.add(opt);
    }
}

function onFailure(result) {
    window.alert(result);
}

function populateDropDown(dropdown) {
    Control = dropdown;
    DataService.GetData(dropDownRequest_onSuccess, onFailure);
}

function setpopulateDropdown(controlId, value) {
    Control = document.getElementById(controlId);
    selectedOptionValue = value;
    populateDropDown(Control);
}
 