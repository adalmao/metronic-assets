var FormEditable = function() {

    $.mockjaxSettings.responseTime = 500;

    var log = function(settings, response) {
        var s = [],
            str;
        s.push(settings.type.toUpperCase() + ' url = "' + settings.url + '"');
        for (var a in settings.data) {
            if (settings.data[a] && typeof settings.data[a] === 'object') {
                str = [];
                for (var j in settings.data[a]) {
                    str.push(j + ': "' + settings.data[a][j] + '"');
                }
                str = '{ ' + str.join(', ') + ' }';
            } else {
                str = '"' + settings.data[a] + '"';
            }
            s.push(a + ' = ' + str);
        }
        s.push('RESPONSE: status = ' + response.status);

        if (response.responseText) {
            if ($.isArray(response.responseText)) {
                s.push('[');
                $.each(response.responseText, function(i, v) {
                    s.push('{value: ' + v.value + ', text: "' + v.text + '"}');
                });
                s.push(']');
            } else {
                s.push($.trim(response.responseText));
            }
        }
        s.push('--------------------------------------\n');
        $('#console').val(s.join('\n') + $('#console').val());
    }

    var initAjaxMock = function() {
        //ajax mocks

        $.mockjax({
            url: '/post',
            response: function(settings) {
                log(settings, this);
            }
        });

        $.mockjax({
            url: '/error',
            status: 400,
            statusText: 'Bad Request',
            response: function(settings) {
                this.responseText = 'Please input correct value';
                log(settings, this);
            }
        });

        $.mockjax({
            url: '/status',
            status: 500,
            response: function(settings) {
                this.responseText = 'Internal Server Error';
                log(settings, this);
            }
        });

        $.mockjax({
            url: '/groups',
            response: function(settings) {
                this.responseText = [{
                    value: 0,
                    text: 'Guest'
                }, {
                    value: 1,
                    text: 'Service'
                }, {
                    value: 2,
                    text: 'Customer'
                }, {
                    value: 3,
                    text: 'Operator'
                }, {
                    value: 4,
                    text: 'Support'
                }, {
                    value: 5,
                    text: 'Admin'
                }];
                log(settings, this);
            }
        });

    }

    var initEditables = function() {

        //set editable mode based on URL parameter
        if (App.getURLParameter('mode') == 'inline') {
            $.fn.editable.defaults.mode = 'inline';
            $('#inline').attr("checked", true);
        } else {
            $('#inline').attr("checked", false);
        }

        //global settings 
        $.fn.editable.defaults.inputclass = 'form-control';
        $.fn.editable.defaults.url = '/post';

        //editables element samples 
        $('.editable-note').editable({
            showbuttons: (App.isRTL() ? 'left' : 'right')
        });

        $('#pencil-1').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-1').editable('toggle');
        });

        $('#pencil-2').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-2').editable('toggle');
        });

        $('#pencil-3').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-3').editable('toggle');
        });
        $('#pencil-4').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-4').editable('toggle');
        });
        $('#pencil-5').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-5').editable('toggle');
        });
        $('#pencil-6').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-6').editable('toggle');
        });
        $('#pencil-7').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-7').editable('toggle');
        });
        $('#pencil-8').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-8').editable('toggle');
        });
        $('#pencil-9').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-9').editable('toggle');
        });
        $('#pencil-10').click(function(e) {
            e.stopPropagation();
            e.preventDefault();
            $('#note-10').editable('toggle');
        });
    
    
    }

    return {
        //main function to initiate the module
        init: function() {

            // inii ajax simulation
            initAjaxMock();

            // init editable elements
            initEditables();

            // init editable toggler
            $('#enable').click(function() {
                $('#user .editable').editable('toggleDisabled');
            });

            // init 
            $('#inline').on('change', function(e) {
                if ($(this).is(':checked')) {
                    window.location.href = 'form_editable.html?mode=inline';
                } else {
                    window.location.href = 'form_editable.html';
                }
            });

            // handle editable elements on hidden event fired
            $('#user .editable').on('hidden', function(e, reason) {
                if (reason === 'save' || reason === 'nochange') {
                    var $next = $(this).closest('tr').next().find('.editable');
                    if ($('#autoopen').is(':checked')) {
                        setTimeout(function() {
                            $next.editable('show');
                        }, 300);
                    } else {
                        $next.focus();
                    }
                }
            });


        }

    };

}();

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
    FormEditable.init();
    UIToastr.init();
    
});