// NOTIFICACIONES EMERGENTES
var UIToastr = function () {
     return {
        //main function to initiate the module
        init: function () {
            $('#all-save').click(function () {
                toastr.options = {
                    "closeButton": true,
                    "debug": false,
                    "positionClass": "toast-top-right",
                    "onclick": null,
                    "showDuration": "1000",
                    "hideDuration": "1000",
                    "timeOut": "5000",
                    "extendedTimeOut": "1000",
                    "showEasing": "swing",
                    "hideEasing": "linear",
                    "showMethod": "fadeIn",
                    "hideMethod": "fadeOut"
                }
                toastr.info('Sus cambios se guardaron satisfactoriamente');
            });

            //Not network connection
             $('#all-save i').click(function () {
                toastr.options = {
                    "closeButton": true,
                    "debug": false,
                    "positionClass": "toast-top-right",
                    "onclick": null,
                    "showDuration": "1000",
                    "hideDuration": "1000",
                    "timeOut": "5000",
                    "extendedTimeOut": "1000",
                    "showEasing": "swing",
                    "hideEasing": "linear",
                    "showMethod": "fadeIn",
                    "hideMethod": "fadeOut"
                }
                toastr.warning('Los cambios no se pudieron guardar. Revise su conexión y guarde sus cambios nuevamente');
            });
        }
     }
        
}();


jQuery(document).ready(function() {
    $('[data-toggle="tooltip"]').tooltip(); 
    UIToastr.init();
    //Tooltips init
});

