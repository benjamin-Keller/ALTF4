/* Department */
function openFlatButtonDepartment() {

    if (document.getElementById("addButtonDepartment").style.display == "none") {
        document.getElementById("updateButtonDepartment").style.display = "block";
        document.getElementById("addButtonDepartment").style.display = "block";
    }
    else {
        document.getElementById("updateButtonDepartment").style.display = "none";
		document.getElementById("addButtonDepartment").style.display = "none";
    }
}


/* Equipment */
function openFlatButtonEquipment() {

    if (document.getElementById("addButtonEquipment").style.display == "none") {
        document.getElementById("updateButtonEquipment").style.display = "block";
        document.getElementById("addButtonEquipment").style.display = "block";
    }
    else {
        document.getElementById("updateButtonEquipment").style.display = "none";
        document.getElementById("addButtonEquipment").style.display = "none";
    }
}

/* Equipment */
function openFlatButtonEquipment() {

    if (document.getElementById("addButtonEquipmentType").style.display == "none") {
        document.getElementById("updateButtonEquipmentType").style.display = "block";
        document.getElementById("addButtonEquipmentType").style.display = "block";
    }
    else {
        document.getElementById("updateButtonEquipmentType").style.display = "none";
        document.getElementById("addButtonEquipmentType").style.display = "none";
    }
}

/* Venue */
function openFlatButtonVenue() {

    if (document.getElementById("addButtonVenue").style.display == "none") {
        document.getElementById("updateButtonVenue").style.display = "block";
        document.getElementById("addButtonVenue").style.display = "block";
    }
    else {
        document.getElementById("updateButtonVenue").style.display = "none";
        document.getElementById("addButtonVenue").style.display = "none";
    }
}

/* Request */
function openFlatButtonRequest() {

    if (document.getElementById("addButtonRequest").style.display == "none") {
        document.getElementById("updateButtonRequest").style.display = "block";
        document.getElementById("addButtonRequest").style.display = "block";
    }
    else {
        document.getElementById("updateButtonRequest").style.display = "none";
        document.getElementById("addButtonRequest").style.display = "none";
    }
}

/* Tutor Request */
function openFlatButtonTutorRequest() {

    if (document.getElementById("addButtonTutorRequest").style.display == "none") {
        document.getElementById("updateButtonTutorRequest").style.display = "block";
        document.getElementById("addButtonTutorRequest").style.display = "block";
    }
    else {
        document.getElementById("updateButtonTutorRequest").style.display = "none";
        document.getElementById("addButtonTutorRequest").style.display = "none";
    }
}

/* Inspection */
function openFlatButtonInspection() {
    if (document.getElementById("addButtonInspection").style.display == "none") {
        document.getElementById("updateButtonInspection").style.display = "block";
        document.getElementById("addButtonInspection").style.display = "block";
    }
    else {
        document.getElementById("updateButtonInspection").style.display = "none";
        document.getElementById("addButtonInspection").style.display = "none";
    }
}

/* Task Type */
function openFlatButtonTaskType() {

    if (document.getElementById("addButtonTaskType").style.display == "none") {
        document.getElementById("updateButtonTaskType").style.display = "block";
        document.getElementById("addButtonTaskType").style.display = "block";
    }
    else {
        document.getElementById("updateButtonTaskType").style.display = "none";
        document.getElementById("addButtonTaskType").style.display = "none";
    }
}

/* Student */
function openFlatButtonStudent() {

    if (document.getElementById("addButtonStudent").style.display == "none") {
        document.getElementById("updateButtonStudent").style.display = "block";
        document.getElementById("addButtonStudent").style.display = "block";
    }
    else {
        document.getElementById("updateButtonStudent").style.display = "none";
        document.getElementById("addButtonStudent").style.display = "none";
    }
}

/* Staff */
function openFlatButtonStaff() {

    if (document.getElementById("addButtonStaff").style.display == "none") {
        document.getElementById("updateButtonStaff").style.display = "block";
        document.getElementById("addButtonStaff").style.display = "block";
    }
    else {
        document.getElementById("updateButtonStaff").style.display = "none";
        document.getElementById("addButtonStaff").style.display = "none";
    }
}

function reportVenue() {

    if (document.getElementById("reportVenue").style.display == "none") {
        document.getElementById("reportVenue").style.display = "block";
    }
    else {
        document.getElementById("reportVenue").style.display = "none";
        document.getElementById("reportDepartment").style.display = "none";
    }
}

function reportDepartment() {

    if (document.getElementById("reportDepartment").style.display == "none") {
        document.getElementById("reportDepartment").style.display = "block";
        document.getElementById("reportVenue").style.display = "none";
    }
    else {
        document.getElementById("reportDepartment").style.display = "none";
    }
}
