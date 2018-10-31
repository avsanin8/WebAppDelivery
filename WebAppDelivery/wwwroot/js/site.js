// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*the only js is to continuously checking the value of the dropdown. for posterity*/
var img = setInterval(function () { $("#trace").val($("input[name=line-style]:checked").val()); }, 100); 

var tempId = 0;

//Seted standart type packageType

function selectedPackT() {
    let packT = document.getElementById("packageTypeId").value;
    document.getElementById("demo").innerHTML = "You selected: " + packT;

    if (packT === "envelope") {
        console.log("Envelope");
    }
    if (packT === "bag") {
        console.log("Bag");        
    }
    if (packT === "box") {
        updatePackT();
        console.log("Box");        
    }
    if (packT === "etc") {
        console.log("Etc.");
    }
}

function updatePackT() {
    let valPackT = document.getElementById("packageTypeId").value;
    let curLine = $("#trace").val($("input[name=line-style]:checked").val());

    if (valPackT === "box")
    {
        if (curLine.val() === "2") {
            document.getElementById("dimensionTypeId").value = "centimeters";
            document.getElementById("form-length").value = 180;
            document.getElementById("form-Width").value = 125;
            document.getElementById("form-Height").value = 80;
            document.getElementById("WeightTypeId").value = "pounds";
            document.getElementById("form-Weight").value = 1.0526;
        }
        if (curLine.val() === "3") {
            document.getElementById("dimensionTypeId").value = "centimeters";
            document.getElementById("form-length").value = 205;
            document.getElementById("form-Width").value = 160;
            document.getElementById("form-Height").value = 85;
            document.getElementById("WeightTypeId").value = "pounds";
            document.getElementById("form-Weight").value = 1.58;
        }
        if (curLine.val() === "4") {
            document.getElementById("dimensionTypeId").value = "centimeters";
            document.getElementById("form-length").value = 250;
            document.getElementById("form-Width").value = 220;
            document.getElementById("form-Height").value = 85;
            document.getElementById("WeightTypeId").value = "pounds";
            document.getElementById("form-Weight").value = 2.6;
        }
        if (curLine.val() === "5") {
            document.getElementById("dimensionTypeId").value = "centimeters";
            document.getElementById("form-length").value = 325;
            document.getElementById("form-Width").value = 240;
            document.getElementById("form-Height").value = 85;
            document.getElementById("WeightTypeId").value = "pounds";
            document.getElementById("form-Weight").value = 10;
        }
        if (curLine.val() === "6") {
            document.getElementById("dimensionTypeId").value = "centimeters";
            document.getElementById("form-length").value = 375;
            document.getElementById("form-Width").value = 90;
            document.getElementById("form-Height").value = 260;
            document.getElementById("WeightTypeId").value = "pounds";
            document.getElementById("form-Weight").value = 6;
        }
        if (curLine.val() === "7") {
            document.getElementById("dimensionTypeId").value = "centimeters";
            document.getElementById("form-length").value = 430;
            document.getElementById("form-Width").value = 320;
            document.getElementById("form-Height").value = 245;
            document.getElementById("WeightTypeId").value = "ounces";
            document.getElementById("form-Weight").value = 2;
        }
    }
}



function selectedFromCountry() {
    let fromCountry = document.getElementById("from-country").value;
    let toCountry = document.getElementById("to-country").value;
    if (fromCountry === "US") {
        document.getElementById("from-state-section").hidden = false;
        show(document.getElementById("from-state-section").id, 40, 200, 3);
    } else {        
        //show(document.getElementById("from-state-section").id, 40, 200, -3);
        document.getElementById("from-state-section").hidden = true;
    }
    if (toCountry === "US") {
        document.getElementById("to-state-section").hidden = false;
    } else {
        document.getElementById("to-state-section").hidden = true;
        
    }
}



/*<![CDATA[*/
let s = [], s_timer = [];//s - section
function show(id, h, w, v)//id элемента,h высота, w- ,v скорость ---(-v) если блок надо первоначально закрывать
{
    console.log(s);
    console.log(s_timer);
    s[id] = s[id] === v ? -v : v; //flag
    //console.log(s[id]);
    //console.log(s_timer[id]);
    s_timer[id] = setTimeout(function () {
        let obj = document.getElementById(id);
        let v_w = Math.ceil(w * s[id] / h); //
        if (obj.offsetHeight + s[id] >= h) {
            obj.style.height = h + "px";
            obj.style.width = w + "px";
            obj.style.overflow = "auto";
        }
        else if (obj.offsetHeight + s[id] <= 0 ) {
            obj.style.height = 0 + "px";
            obj.style.width = 0 + "px";
            obj.style.display = "none";
        }
        else {
            obj.style.height = obj.offsetHeight + s[id] + "px";
            obj.style.width = obj.offsetWidth + v_w + "px";
            obj.style.overflow = "hidden";
            obj.style.display = "block";
            setTimeout(arguments.callee, 10);
        }
    }, 10);
}
 /*]]>*/










//function getValue() {
//    var imgVal = document.getElementsByName("trace")[0].value;
//    console.log("imgVal:",imgVal);
//}
//function openBoxMenu() {input[name=line-style]:checked").val()
//    document.getElementById("sidebar").classList.toggle('active');
//}

//$("#trace").val($("input[name=line-style]:checked").val()
    //if (document.getElementById("dimensionTypeId").value === "box") {
    //    console.log("dimensionTypeId.value === box");
    //    alert(document.getElementById("box").value);
    //}
    //document.documentElement.dimensionType
