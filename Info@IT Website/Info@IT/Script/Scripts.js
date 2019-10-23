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
	/* Manage */
function openFlatButtonEquipment() {

    if (document.getElementById("addButtonEquipment").style.display == "none") {
        document.getElementById("updateButtonEquipment").style.display = "block";
		document.getElementById("addButtonEquipment").style.display = "block";

		document.getElementById("viewButtonEquipment").style.display = "none";
    }
    else {
        document.getElementById("updateButtonEquipment").style.display = "none";
        document.getElementById("addButtonEquipment").style.display = "none";
    }
}
	/* View */
function openFlatButtonEquipmentView() {

	if (document.getElementById("viewButtonEquipment").style.display == "none") {
		document.getElementById("viewButtonEquipment").style.display = "block";

		document.getElementById("updateButtonEquipment").style.display = "none";
		document.getElementById("addButtonEquipment").style.display = "none";
	}
	else {
		document.getElementById("viewButtonEquipment").style.display = "none";
	}
}

/* Equipment Type */
function openFlatButtonEquipmentType() {

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

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
        document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
        document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
        document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }

        try {
        document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
        document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
        document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
    }
    else {
        document.getElementById("reportVenue").style.display = "none";
    }
}

function reportDepartment() {

    if (document.getElementById("reportDepartment").style.display == "none") {

        document.getElementById("reportDepartment").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }

    }
    else {
        document.getElementById("reportDepartment").style.display = "none";
    }
}

function reportEquipment() {

    if (document.getElementById("reportEquipment").style.display == "none") {
        document.getElementById("reportEquipment").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }
    }
    else {
        document.getElementById("reportEquipment").style.display = "none";
    }
}

function reportInspection() {

    if (document.getElementById("reportInspection").style.display == "none") {
        document.getElementById("reportInspection").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }

    }
    else {
        document.getElementById("reportInspection").style.display = "none";
    }
}

function reportInspectionDetails() {

    if (document.getElementById("reportInspectionDetails").style.display == "none") {
        document.getElementById("reportInspectionDetails").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }
    }
    else {
        document.getElementById("reportInspectionDetails").style.display = "none";
    }
}

function reportRequest() {

    if (document.getElementById("reportRequest").style.display == "none") {
        document.getElementById("reportRequest").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }
    }
    else {
        document.getElementById("reportRequest").style.display = "none";
    }
}

function reportStaff() {

    if (document.getElementById("reportStaff").style.display == "none") {
        document.getElementById("reportStaff").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }
    }
    else {
        document.getElementById("reportStaff").style.display = "none";
    }
}

function reportStudent() {

    if (document.getElementById("reportStudent").style.display == "none") {
        document.getElementById("reportStudent").style.display = "block";
        
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportTutorRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }
    }
    else {
        document.getElementById("reportStudent").style.display = "none";
    }
}

function reportTutorRequest() {

    if (document.getElementById("reportTutorRequest").style.display == "none") {

        document.getElementById("reportTutorRequest").style.display = "block";

        try {
            document.getElementById("reportStudent").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportStaff").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportRequest").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportInspectionDetails").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportInspection").style.display = "none";
        }
        catch{ }

        try {
            document.getElementById("reportEquipment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportDepartment").style.display = "none";
        }
        catch{ }
        try {
            document.getElementById("reportVenue").style.display = "none";
        }
        catch{ }
    }
    else {

        document.getElementById("reportTutorRequest").style.display = "none";
    }
}

function __doPostBack(eventTarget, eventArgument) {
    debugger;
    if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
        
        theForm.__EVENTTARGET.value = eventTarget;
        theForm.__EVENTARGUMENT.value = eventArgument;
        theForm.submit();
    }
}