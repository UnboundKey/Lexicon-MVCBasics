var elementToChange = "#result"

function GetPerson() {
    let id = document.getElementById("personIDNumber").value;
    // Send request to backend
    // Get All Person Objects
    // Return a partial view for each entry in the element to change
    let targetElement = document.getElementById(elementToChange);
    console.log(elementToChange);
    //let request = $.get("/AJAX/Get?personid=1");
    $.get("/AJAX/Get?personid=" + id, function (data, status) {
        $(result).html(data);
    })
    console.log("Finished");
}

function GetAll() {
    

}