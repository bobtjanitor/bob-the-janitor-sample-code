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

function populateCountry(dropdown) {
    Control = dropdown;   
    DataService.GetCountryData(populateCountry_onSuccess, onFailure)
}

function populateCountry_onSuccess(result) {
    dropDownRequest_onSuccess(result);    
}

function populateStates(dropdown, countyControl) {
    Control = dropdown;

    var selectedCountry = "USA";

    if (countyControl.options.length > 0) {
        selectedCountry = countyControl.value;
    }

    DataService.GetStateData(selectedCountry, populateCountry_onSuccess, onFailure)
}

function showSuggestions(suggestCityControl, textCityControl) {

    if (textCityControl.value.length > 0) {
        suggestCityControl.style.display = "";
    }

}

function setSuggestions(suggestCityControl, textCityControl) {
    showSuggestions(suggestCityControl, textCityControl);
    var opt = document.createElement("option");
    opt.text = "Boise";
    opt.value = "Boise";

    suggestCityControl.options.add(opt);
    
}
 