// Write your Javascript code.
$('#myModal')
    .on('shown.bs.modal',
        function() {
            $('#Email').focus();
        });


var items;
var id;
var phoneNumber;
var userName;
var accessFailedCount;
var concurrentystamp;
var emailConfirmed;
var lockoutEnabled;
var lockoutEnd;
var normalizedEmail;
var normalizedUserName;
var passwordHash;
var phoneNumberConfirmed;
var securitystamp;
var twoFactorEnabled;


function GetDataAjax(id, action) {
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {


            //console.log(response);
            OnSuccess(response);
        }

    });
};


function OnSuccess(response) {

    items = response;

    $.each(items, function (index, val) {

        $('input[name=Id]').val(val.id);
        $('input[name=Email]').val(val.email);
        $('input[name=PhoneNumber]').val(val.phoneNumber);
        $('input[name=UserName]').val(val.userName);

    });

}

//CODIGO DE UUSARIO:
function SetDataUser(action)
{

    id          = $('input[name=Id]')[0]         .value;
    email       = $('input[name=Email]')[0]      .value;
    phoneNumber = $('input[name=PhoneNumber]')[0].value;
    userName    = $('input[name=UserName]')[0].value;

    $.each(items, function(index, val) {


        accessFailedCount = val.accessFailedCount;
        concurrentystamp = val.concurrentystamp;
        emailConfirmed = val.emailConfirmed;
        lockoutEnabled = val.lockoutEnabled;
        lockoutEnd = val.lockoutEnd;
        normalizedEmail = val.normalizedEmail;
        normalizedUserName = val.normalizedUserName;
        passwordHash = val.passwordHash;
        phoneNumberConfirmed = val.phoneNumberConfirmed;
        securitystamp = val.securitystamp;
        twoFactorEnabled = val.twoFactorEnabled;


    });

    //valido los campos:
    if (email == "") {


        alert("Ingrese el Email.");
        $('#Email').focus();

        return;
    }

    if (phoneNumber == "") {


        alert("Ingrese el Teléfono.");
        $('#PhoneNumber').focus();

        return;
    }

    if (userName == "") {

        alert("Ingrese el Usuario.");
        $('#UserName').focus();


        return;
    }


}