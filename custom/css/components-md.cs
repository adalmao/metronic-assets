/*****************************************
 METRONIC MATERIAL DESIGN STYLE COMPONENTS 
******************************************/
/* Cubic Bezier Transition */
/***
General reset
***/
/* Set default body */
body {
  color: #333333;
  font-family: "Roboto", sans-serif;
  padding: 0px !important;
  margin: 0px !important;
  direction: "ltr";
  font-size: 14px; }

/*
 Internet Explorer 10 doesn't differentiate device width from viewport width, and thus doesn't 
 properly apply the media queries in Bootstrap's CSS. To address this, 
 you can optionally include the following CSS and JavaScript to work around this problem until Microsoft issues a fix.
*/
@-webkit-viewport {
  width: device-width; }
@-moz-viewport {
  width: device-width; }
@-ms-viewport {
  width: device-width; }
@-o-viewport {
  width: device-width; }
@viewport {
  width: device-width; }
/*
 Internet Explorer 10 doesn't differentiate device width from viewport width, 
 and thus doesn't properly apply the media queries in Bootstrap's CSS. To address this, following CSS code applied 
*/
@-ms-viewport {
  width: auto !important; }
.md-shadow-z-1, .alert, .badge, .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all), .btn-group > .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all), .btn.btn-link:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all):hover, .icon-btn, .label:not(.md-skip), .note, .panel, .social-icons li > a, .social-icons.social-icons-color > li > a, .well {
  box-shadow: 0 1px 3px rgba(0, 0, 0, 0.1), 0 1px 2px rgba(0, 0, 0, 0.18); }

.md-shadow-z-1-i {
  box-shadow: 0 1px 3px rgba(0, 0, 0, 0.1), 0 1px 2px rgba(0, 0, 0, 0.18) !important; }

.md-shadow-z-1-hover {
  box-shadow: 0 1px 3px rgba(0, 0, 0, 0.14), 0 1px 2px rgba(0, 0, 0, 0.22); }

.md-shadow-z-2, .ver-inline-menu, .popover {
  box-shadow: 0 3px 6px rgba(0, 0, 0, 0.16), 0 3px 6px rgba(0, 0, 0, 0.22); }

.md-shadow-z-2-i, .dropdown-menu, .btn-group > .dropdown-menu {
  box-shadow: 0 3px 6px rgba(0, 0, 0, 0.16), 0 3px 6px rgba(0, 0, 0, 0.22) !important; }

.md-shadow-z-2-hover, .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all):hover, .icon-btn:hover, .portlet.box.white > .portlet-title > .actions .btn-default:hover, .portlet.box.default > .portlet-title > .actions .btn-default:hover, .portlet.box.dark > .portlet-title > .actions .btn-default:hover, .portlet.box.blue > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-madison > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-chambray > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-hoki > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-steel > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-dark > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-sharp > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-oleo > .portlet-title > .actions .btn-default:hover, .portlet.box.green > .portlet-title > .actions .btn-default:hover, .portlet.box.green-meadow > .portlet-title > .actions .btn-default:hover, .portlet.box.green-seagreen > .portlet-title > .actions .btn-default:hover, .portlet.box.green-turquoise > .portlet-title > .actions .btn-default:hover, .portlet.box.green-haze > .portlet-title > .actions .btn-default:hover, .portlet.box.green-jungle > .portlet-title > .actions .btn-default:hover, .portlet.box.green-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.green-dark > .portlet-title > .actions .btn-default:hover, .portlet.box.green-sharp > .portlet-title > .actions .btn-default:hover, .portlet.box.green-steel > .portlet-title > .actions .btn-default:hover, .portlet.box.grey > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-steel > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-cararra > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-gallery > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-cascade > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-silver > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-salsa > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-salt > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-mint > .portlet-title > .actions .btn-default:hover, .portlet.box.red > .portlet-title > .actions .btn-default:hover, .portlet.box.red-pink > .portlet-title > .actions .btn-default:hover, .portlet.box.red-sunglo > .portlet-title > .actions .btn-default:hover, .portlet.box.red-intense > .portlet-title > .actions .btn-default:hover, .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default:hover, .portlet.box.red-flamingo > .portlet-title > .actions .btn-default:hover, .portlet.box.red-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.red-haze > .portlet-title > .actions .btn-default:hover, .portlet.box.red-mint > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-gold > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-haze > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-mint > .portlet-title > .actions .btn-default:hover, .portlet.box.purple > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-plum > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-medium > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-studio > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-seance > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-intense > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-sharp > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-soft > .portlet-title > .actions .btn-default:hover, .social-icons li:hover > a, .social-icons.social-icons-color > li > a:hover {
  box-shadow: 0 3px 6px rgba(0, 0, 0, 0.2), 0 3px 6px rgba(0, 0, 0, 0.26); }

.md-shadow-z-3, .modal .modal-content {
  box-shadow: 0 8px 18px rgba(0, 0, 0, 0.18), 0 6px 6px rgba(0, 0, 0, 0.23); }

.md-shadow-z-3-i {
  box-shadow: 0 8px 18px rgba(0, 0, 0, 0.18), 0 6px 6px rgba(0, 0, 0, 0.24) !important; }

.md-shadow-z-3-hover, .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all):active, .portlet.box.white > .portlet-title > .actions .btn-default:active, .portlet.box.default > .portlet-title > .actions .btn-default:active, .portlet.box.dark > .portlet-title > .actions .btn-default:active, .portlet.box.blue > .portlet-title > .actions .btn-default:active, .portlet.box.blue-madison > .portlet-title > .actions .btn-default:active, .portlet.box.blue-chambray > .portlet-title > .actions .btn-default:active, .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default:active, .portlet.box.blue-hoki > .portlet-title > .actions .btn-default:active, .portlet.box.blue-steel > .portlet-title > .actions .btn-default:active, .portlet.box.blue-soft > .portlet-title > .actions .btn-default:active, .portlet.box.blue-dark > .portlet-title > .actions .btn-default:active, .portlet.box.blue-sharp > .portlet-title > .actions .btn-default:active, .portlet.box.blue-oleo > .portlet-title > .actions .btn-default:active, .portlet.box.green > .portlet-title > .actions .btn-default:active, .portlet.box.green-meadow > .portlet-title > .actions .btn-default:active, .portlet.box.green-seagreen > .portlet-title > .actions .btn-default:active, .portlet.box.green-turquoise > .portlet-title > .actions .btn-default:active, .portlet.box.green-haze > .portlet-title > .actions .btn-default:active, .portlet.box.green-jungle > .portlet-title > .actions .btn-default:active, .portlet.box.green-soft > .portlet-title > .actions .btn-default:active, .portlet.box.green-dark > .portlet-title > .actions .btn-default:active, .portlet.box.green-sharp > .portlet-title > .actions .btn-default:active, .portlet.box.green-steel > .portlet-title > .actions .btn-default:active, .portlet.box.grey > .portlet-title > .actions .btn-default:active, .portlet.box.grey-steel > .portlet-title > .actions .btn-default:active, .portlet.box.grey-cararra > .portlet-title > .actions .btn-default:active, .portlet.box.grey-gallery > .portlet-title > .actions .btn-default:active, .portlet.box.grey-cascade > .portlet-title > .actions .btn-default:active, .portlet.box.grey-silver > .portlet-title > .actions .btn-default:active, .portlet.box.grey-salsa > .portlet-title > .actions .btn-default:active, .portlet.box.grey-salt > .portlet-title > .actions .btn-default:active, .portlet.box.grey-mint > .portlet-title > .actions .btn-default:active, .portlet.box.red > .portlet-title > .actions .btn-default:active, .portlet.box.red-pink > .portlet-title > .actions .btn-default:active, .portlet.box.red-sunglo > .portlet-title > .actions .btn-default:active, .portlet.box.red-intense > .portlet-title > .actions .btn-default:active, .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default:active, .portlet.box.red-flamingo > .portlet-title > .actions .btn-default:active, .portlet.box.red-soft > .portlet-title > .actions .btn-default:active, .portlet.box.red-haze > .portlet-title > .actions .btn-default:active, .portlet.box.red-mint > .portlet-title > .actions .btn-default:active, .portlet.box.yellow > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-gold > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-soft > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-haze > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-mint > .portlet-title > .actions .btn-default:active, .portlet.box.purple > .portlet-title > .actions .btn-default:active, .portlet.box.purple-plum > .portlet-title > .actions .btn-default:active, .portlet.box.purple-medium > .portlet-title > .actions .btn-default:active, .portlet.box.purple-studio > .portlet-title > .actions .btn-default:active, .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default:active, .portlet.box.purple-seance > .portlet-title > .actions .btn-default:active, .portlet.box.purple-intense > .portlet-title > .actions .btn-default:active, .portlet.box.purple-sharp > .portlet-title > .actions .btn-default:active, .portlet.box.purple-soft > .portlet-title > .actions .btn-default:active {
  box-shadow: 0 8px 18px rgba(0, 0, 0, 0.22), 0 6px 6px rgba(0, 0, 0, 0.26); }

.md-shadow-z-4 {
  box-shadow: 0 14px 28px rgba(0, 0, 0, 0.26), 0 10px 10px rgba(0, 0, 0, 0.22); }

.md-shadow-z-4-i {
  box-shadow: 0 14px 28px rgba(0, 0, 0, 0.26), 0 10px 10px rgba(0, 0, 0, 0.22) !important; }

.md-shadow-z-5 {
  box-shadow: 0 19px 38px rgba(0, 0, 0, 0.28), 0 15px 12px rgba(0, 0, 0, 0.22); }

.md-shadow-z-5-i {
  box-shadow: 0 19px 38px rgba(0, 0, 0, 0.28), 0 15px 12px rgba(0, 0, 0, 0.22) !important; }

.md-shadow-none {
  box-shadow: none !important; }

.md-click-circle {
  display: block;
  position: absolute;
  background: rgba(0, 0, 0, 0.2);
  border-radius: 50%;
  opacity: 0;
  -webkit-animation: scale(0);
  -moz-transform: scale(0);
  transform: scale(0); }
  .md-click-circle.md-click-animate {
    -webkit-animation: mdClickEffect 0.65s linear;
    -moz-animation: mdClickEffect 0.65s linear;
    animation: mdClickEffect 0.65s linear; }

@-webkit-keyframes mdClickEffect {
  0% {
    opacity: 1;
    -webkit-transform: scale(0); }
  100% {
    opacity: 0 !important;
    -webkit-transform: scale(2.5); } }
@-moz-keyframes mdClickEffect {
  0% {
    opacity: 1;
    -webkit-transform: scale(0); }
  100% {
    opacity: 0 !important;
    -moz-transform: scale(2.5); } }
@keyframes mdClickEffect {
  0% {
    opacity: 1;
    -webkit-transform: scale(0); }
  100% {
    opacity: 0 !important;
    transform: scale(2.5); } }
.form-group.form-md-line-input {
  position: relative;
  margin: 0 0 35px 0;
  padding-top: 20px; }
  .form-horizontal .form-group.form-md-line-input {
    padding-top: 10px;
    margin-bottom: 20px;
    margin: 0 -15px 20px -15px; }
  .form-horizontal .form-group.form-md-line-input > label {
    padding-top: 5px;
    font-size: 14px;
    color: #888888;
    opacity: 1 ;
    filter: alpha(opacity=100) ; }
  .form-group.form-md-line-input .form-control {
    background: none;
    border: 0;
    border-bottom: 1px solid #c2cad8;
    -webkit-border-radius: 0;
    -moz-border-radius: 0;
    -ms-border-radius: 0;
    -o-border-radius: 0;
    border-radius: 0;
    color: #555555;
    box-shadow: none;
    padding-left: 0;
    padding-right: 0;
    font-size: 14px; }
    .form-group.form-md-line-input .form-control::-moz-placeholder {
      color: #999;
      opacity: 1; }
    .form-group.form-md-line-input .form-control:-ms-input-placeholder {
      color: #999; }
    .form-group.form-md-line-input .form-control::-webkit-input-placeholder {
      color: #999; }
    .form-group.form-md-line-input .form-control.form-control-static {
      border-bottom: 0; }
    .form-group.form-md-line-input .form-control.input-sm {
      font-size: 14px;
      padding: 6px 0; }
    .form-group.form-md-line-input .form-control.input-lg {
      font-size: 20px;
      padding: 14px 0; }
    .form-group.form-md-line-input .form-control ~ label,
    .form-group.form-md-line-input .form-control ~ .form-control-focus {
      width: 100%;
      position: absolute;
      left: 0;
      bottom: 0;
      pointer-events: none; }
      .form-horizontal .form-group.form-md-line-input .form-control ~ label, .form-horizontal
      .form-group.form-md-line-input .form-control ~ .form-control-focus {
        width: auto;
        left: 15px;
        right: 15px; }
      .form-group.form-md-line-input .form-control ~ label:after,
      .form-group.form-md-line-input .form-control ~ .form-control-focus:after {
        content: '';
        position: absolute;
        z-index: 5;
        bottom: 0;
        left: 50%;
        width: 0;
        height: 2px;
        width: 0;
        visibility: hidden;
        transition: 0.2s ease all; }
    .form-group.form-md-line-input .form-control ~ label {
      top: 0;
      margin-bottom: 0;
      font-size: 14px;
      color: #888888;
      opacity: 1 ;
      filter: alpha(opacity=100) ; }
    .form-group.form-md-line-input .form-control ~ .help-block-error {
      opacity: 1 ;
      filter: alpha(opacity=100) ; }
    .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ label,
    .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ .form-control-focus, .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ label,
    .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ .form-control-focus {
      color: #888888; }
      .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ label:after,
      .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ label:after,
      .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ .form-control-focus:after {
        visibility: visible;
        left: 0;
        width: 100%;
        background: #36c6d3; }
    .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ label, .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ label {
      opacity: 1 ;
      filter: alpha(opacity=100) ; }
    .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ .help-block, .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ .help-block {
      color: #36c6d3;
      opacity: 1 ;
      filter: alpha(opacity=100) ; }
    .form-group.form-md-line-input .form-control.edited:not([readonly]) ~ .help-block-error, .form-group.form-md-line-input .form-control:focus:not([readonly]) ~ .help-block-error {
      opacity: 0 ;
      filter: alpha(opacity=0) ; }
    .form-group.form-md-line-input .form-control.edited:not([readonly]):not(:focus) ~ .help-block {
      opacity: 0 ;
      filter: alpha(opacity=0) ; }
    .form-group.form-md-line-input .form-control.edited:not([readonly]):not(:focus) ~ .help-block-error {
      opacity: 0 ;
      filter: alpha(opacity=0) ; }
    .form-group.form-md-line-input .form-control[readonly], .form-group.form-md-line-input .form-control[disabled], fieldset[disabled] .form-group.form-md-line-input .form-control {
      background: none;
      cursor: not-allowed;
      border-bottom: 1px dashed #c2cad8; }
  .form-group.form-md-line-input.form-md-floating-label .form-control ~ label {
    font-size: 16px;
    top: 25px;
    transition: 0.2s ease all;
    color: #999; }
  .form-group.form-md-line-input.form-md-floating-label .form-control[readonly] ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.edited ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.form-control-static ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control:focus:not([readonly]) ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.focus:not([readonly]) ~ label {
    top: 0;
    font-size: 13px; }
  .form-group.form-md-line-input.form-md-floating-label .form-control.input-sm ~ label {
    font-size: 14px;
    top: 24px; }
  .form-group.form-md-line-input.form-md-floating-label .form-control.input-sm[readonly] ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-sm.form-control-static ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-sm.edited ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-sm:focus:not([readonly]) ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-sm.focus:not([readonly]) ~ label {
    top: 0;
    font-size: 13px; }
  .form-group.form-md-line-input.form-md-floating-label .form-control.input-lg ~ label {
    font-size: 20px;
    top: 30px; }
  .form-group.form-md-line-input.form-md-floating-label .form-control.input-lg[readonly] ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-lg.edited ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-lg.form-control-static ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-lg:focus:not([readonly]) ~ label, .form-group.form-md-line-input.form-md-floating-label .form-control.input-lg.focus:not([readonly]) ~ label {
    top: 0;
    font-size: 13px; }
  .form-group.form-md-line-input.form-md-floating-label .input-icon > label {
    padding-left: 34px; }
  .form-group.form-md-line-input.form-md-floating-label .input-icon.right > label {
    padding-left: 0;
    padding-right: 34px; }
  .form-group.form-md-line-input.form-md-floating-label .input-group.left-addon label {
    padding-left: 34px; }
  .form-group.form-md-line-input.form-md-floating-label .input-group.right-addon label {
    padding-right: 34px; }
  .form-group.form-md-line-input + .input-icon {
    padding-top: 0; }
  .form-group.form-md-line-input .help-block {
    position: absolute;
    margin: 2px 0 0 0;
    opacity: 0 ;
    filter: alpha(opacity=0) ;
    font-size: 13px; }
  .form-group.form-md-line-input > .input-icon > i {
    left: 0;
    bottom: 0;
    margin: 9px 2px 10px 10px;
    color: #888888; }
  .form-group.form-md-line-input > .input-icon.input-icon-lg > i {
    top: 6px; }
  .form-group.form-md-line-input > .input-icon.input-icon-sm > i {
    top: -1px; }
  .form-group.form-md-line-input > .input-icon .form-control {
    padding-left: 34px; }
  .form-group.form-md-line-input > .input-icon > label {
    margin-top: -20px; }
  .form-group.form-md-line-input > .input-icon.right .form-control {
    padding-left: 0;
    padding-right: 34px; }
  .form-group.form-md-line-input > .input-icon.right > i {
    left: auto;
    right: 8px;
    margin: 11px 2px 10px 10px; }
  .form-group.form-md-line-input + .input-group {
    padding-top: 0; }
  .form-group.form-md-line-input .input-group {
    padding-top: 0; }
    .form-group.form-md-line-input .input-group > label {
      margin-top: -20px; }
    .form-group.form-md-line-input .input-group .input-group-addon {
      -webkit-border-radius: 0;
      -moz-border-radius: 0;
      -ms-border-radius: 0;
      -o-border-radius: 0;
      border-radius: 0;
      background: none;
      border: 0;
      border-bottom: 1px solid #c2cad8; }
    .form-group.form-md-line-input .input-group + .input-group-control {
      padding-top: 0; }
    .form-group.form-md-line-input .input-group .input-group-control {
      padding-top: 0;
      position: relative;
      display: table-cell;
      vertical-align: bottom; }
      .form-group.form-md-line-input .input-group .input-group-control > label {
        margin-top: -20px; }
    .form-group.form-md-line-input .input-group .input-group-btn .btn {
      -webkit-border-radius: 2px;
      -moz-border-radius: 2px;
      -ms-border-radius: 2px;
      -o-border-radius: 2px;
      border-radius: 2px; }
    .form-group.form-md-line-input .input-group .input-group-btn.btn-left .btn {
      margin-right: 10px; }
    .form-group.form-md-line-input .input-group .input-group-btn.btn-right .btn {
      margin-left: 10px; }
    .form-group.form-md-line-input .input-group .help-block {
      margin-top: 35px; }
    .form-group.form-md-line-input .input-group.input-group-sm .help-block {
      margin-top: 30px; }
    .form-group.form-md-line-input .input-group.input-group-lg .help-block {
      margin-top: 47px; }
  .form-group.form-md-line-input.has-success .form-control {
    border-bottom: 1px solid #27a4b0; }
    .form-group.form-md-line-input.has-success .form-control.edited:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-success .form-control.edited:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-success .form-control.form-control-static ~ label:after,
    .form-group.form-md-line-input.has-success .form-control.form-control-static ~ .form-control-focus:after, .form-group.form-md-line-input.has-success .form-control:focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-success .form-control:focus:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-success .form-control.focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-success .form-control.focus:not([readonly]) ~ .form-control-focus:after {
      background: #27a4b0; }
    .form-group.form-md-line-input.has-success .form-control.edited:not([readonly]) ~ label, .form-group.form-md-line-input.has-success .form-control.form-control-static ~ label, .form-group.form-md-line-input.has-success .form-control:focus:not([readonly]) ~ label, .form-group.form-md-line-input.has-success .form-control.focus:not([readonly]) ~ label {
      color: #27a4b0; }
    .form-group.form-md-line-input.has-success .form-control.edited:not([readonly]) ~ i, .form-group.form-md-line-input.has-success .form-control.form-control-static ~ i, .form-group.form-md-line-input.has-success .form-control:focus:not([readonly]) ~ i, .form-group.form-md-line-input.has-success .form-control.focus:not([readonly]) ~ i {
      color: #27a4b0; }
    .form-group.form-md-line-input.has-success .form-control.edited:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-success .form-control.form-control-static ~ .help-block, .form-group.form-md-line-input.has-success .form-control:focus:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-success .form-control.focus:not([readonly]) ~ .help-block {
      color: #27a4b0; }
  .form-group.form-md-line-input.has-success .input-group-addon {
    color: #27a4b0;
    border-bottom: 1px solid #27a4b0; }
  .form-group.form-md-line-input.has-success label {
    color: #27a4b0; }
  .form-group.form-md-line-input.has-warning .form-control {
    border-bottom: 1px solid #c29d0b; }
    .form-group.form-md-line-input.has-warning .form-control.edited:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-warning .form-control.edited:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-warning .form-control.form-control-static ~ label:after,
    .form-group.form-md-line-input.has-warning .form-control.form-control-static ~ .form-control-focus:after, .form-group.form-md-line-input.has-warning .form-control:focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-warning .form-control:focus:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-warning .form-control.focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-warning .form-control.focus:not([readonly]) ~ .form-control-focus:after {
      background: #c29d0b; }
    .form-group.form-md-line-input.has-warning .form-control.edited:not([readonly]) ~ label, .form-group.form-md-line-input.has-warning .form-control.form-control-static ~ label, .form-group.form-md-line-input.has-warning .form-control:focus:not([readonly]) ~ label, .form-group.form-md-line-input.has-warning .form-control.focus:not([readonly]) ~ label {
      color: #c29d0b; }
    .form-group.form-md-line-input.has-warning .form-control.edited:not([readonly]) ~ i, .form-group.form-md-line-input.has-warning .form-control.form-control-static ~ i, .form-group.form-md-line-input.has-warning .form-control:focus:not([readonly]) ~ i, .form-group.form-md-line-input.has-warning .form-control.focus:not([readonly]) ~ i {
      color: #c29d0b; }
    .form-group.form-md-line-input.has-warning .form-control.edited:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-warning .form-control.form-control-static ~ .help-block, .form-group.form-md-line-input.has-warning .form-control:focus:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-warning .form-control.focus:not([readonly]) ~ .help-block {
      color: #c29d0b; }
  .form-group.form-md-line-input.has-warning .input-group-addon {
    color: #c29d0b;
    border-bottom: 1px solid #c29d0b; }
  .form-group.form-md-line-input.has-warning label {
    color: #c29d0b; }
  .form-group.form-md-line-input.has-error .form-control {
    border-bottom: 1px solid #e73d4a; }
    .form-group.form-md-line-input.has-error .form-control.edited:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-error .form-control.edited:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-error .form-control.form-control-static ~ label:after,
    .form-group.form-md-line-input.has-error .form-control.form-control-static ~ .form-control-focus:after, .form-group.form-md-line-input.has-error .form-control:focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-error .form-control:focus:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-error .form-control.focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-error .form-control.focus:not([readonly]) ~ .form-control-focus:after {
      background: #e73d4a; }
    .form-group.form-md-line-input.has-error .form-control.edited:not([readonly]) ~ label, .form-group.form-md-line-input.has-error .form-control.form-control-static ~ label, .form-group.form-md-line-input.has-error .form-control:focus:not([readonly]) ~ label, .form-group.form-md-line-input.has-error .form-control.focus:not([readonly]) ~ label {
      color: #e73d4a; }
    .form-group.form-md-line-input.has-error .form-control.edited:not([readonly]) ~ i, .form-group.form-md-line-input.has-error .form-control.form-control-static ~ i, .form-group.form-md-line-input.has-error .form-control:focus:not([readonly]) ~ i, .form-group.form-md-line-input.has-error .form-control.focus:not([readonly]) ~ i {
      color: #e73d4a; }
    .form-group.form-md-line-input.has-error .form-control.edited:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-error .form-control.form-control-static ~ .help-block, .form-group.form-md-line-input.has-error .form-control:focus:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-error .form-control.focus:not([readonly]) ~ .help-block {
      color: #e73d4a; }
  .form-group.form-md-line-input.has-error .input-group-addon {
    color: #e73d4a;
    border-bottom: 1px solid #e73d4a; }
  .form-group.form-md-line-input.has-error label {
    color: #e73d4a; }
  .form-group.form-md-line-input.has-info .form-control {
    border-bottom: 1px solid #327ad5; }
    .form-group.form-md-line-input.has-info .form-control.edited:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-info .form-control.edited:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-info .form-control.form-control-static ~ label:after,
    .form-group.form-md-line-input.has-info .form-control.form-control-static ~ .form-control-focus:after, .form-group.form-md-line-input.has-info .form-control:focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-info .form-control:focus:not([readonly]) ~ .form-control-focus:after, .form-group.form-md-line-input.has-info .form-control.focus:not([readonly]) ~ label:after,
    .form-group.form-md-line-input.has-info .form-control.focus:not([readonly]) ~ .form-control-focus:after {
      background: #327ad5; }
    .form-group.form-md-line-input.has-info .form-control.edited:not([readonly]) ~ label, .form-group.form-md-line-input.has-info .form-control.form-control-static ~ label, .form-group.form-md-line-input.has-info .form-control:focus:not([readonly]) ~ label, .form-group.form-md-line-input.has-info .form-control.focus:not([readonly]) ~ label {
      color: #327ad5; }
    .form-group.form-md-line-input.has-info .form-control.edited:not([readonly]) ~ i, .form-group.form-md-line-input.has-info .form-control.form-control-static ~ i, .form-group.form-md-line-input.has-info .form-control:focus:not([readonly]) ~ i, .form-group.form-md-line-input.has-info .form-control.focus:not([readonly]) ~ i {
      color: #327ad5; }
    .form-group.form-md-line-input.has-info .form-control.edited:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-info .form-control.form-control-static ~ .help-block, .form-group.form-md-line-input.has-info .form-control:focus:not([readonly]) ~ .help-block, .form-group.form-md-line-input.has-info .form-control.focus:not([readonly]) ~ .help-block {
      color: #327ad5; }
  .form-group.form-md-line-input.has-info .input-group-addon {
    color: #327ad5;
    border-bottom: 1px solid #327ad5; }
  .form-group.form-md-line-input.has-info label {
    color: #327ad5; }

.form-inline .form-md-line-input {
  margin: 0;
  padding-top: 0;
  margin-right: 20px; }
  .form-inline .form-md-line-input > .input-icon {
    padding: 0; }

.form-horizontal .form-group.form-md-line-input .input-icon .form-control {
  padding-left: 33px; }
.form-horizontal .form-group.form-md-line-input .input-icon > i {
  top: 0; }
.form-horizontal .form-group.form-md-line-input .input-icon.right .form-control {
  padding-left: 0;
  padding-right: 33px; }
.form-horizontal .form-group.form-md-line-input .input-icon > .form-control-focus {
  left: 0 !important;
  right: 0 !important; }
.form-horizontal .form-group.form-md-line-input .input-group {
  padding-top: 0; }
  .form-horizontal .form-group.form-md-line-input .input-group > .input-group-btn .btn {
    margin-bottom: 0 !important; }
  .form-horizontal .form-group.form-md-line-input .input-group > .input-group-control {
    padding-top: 0; }
    .form-horizontal .form-group.form-md-line-input .input-group > .input-group-control > .form-control-focus {
      left: 0 !important;
      right: 0 !important; }
  .form-horizontal .form-group.form-md-line-input .input-group > .form-control-focus {
    left: 0 !important;
    right: 0 !important; }

.md-checkbox {
  position: relative;
  /* handling click events */
  /* when checkbox is checked */ }
  .md-checkbox.md-checkbox-inline {
    display: inline-block; }
  .form-inline .md-checkbox.md-checkbox-inline {
    margin-right: 20px;
    top: 3px; }
  .md-checkbox input[type=checkbox] {
    visibility: hidden;
    position: absolute; }
  .md-checkbox label {
    cursor: pointer;
    padding-left: 30px; }
  .md-checkbox label > span {
    display: block;
    position: absolute;
    left: 0;
    -webkit-transition-duration: 0.3s;
    -moz-transition-duration: 0.3s;
    transition-duration: 0.3s; }
  .md-checkbox label > span.inc {
    background: #fff;
    left: -20px;
    top: -20px;
    height: 60px;
    width: 60px;
    opacity: 0;
    border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    -webkit-border-radius: 50% !important; }
  .md-checkbox label > .box {
    top: 0px;
    border: 2px solid #666;
    height: 20px;
    width: 20px;
    z-index: 5;
    -webkit-transition-delay: 0.2s;
    -moz-transition-delay: 0.2s;
    transition-delay: 0.2s; }
  .md-checkbox label > .check {
    top: -4px;
    left: 6px;
    width: 10px;
    height: 20px;
    border: 2px solid #36c6d3;
    border-top: none;
    border-left: none;
    opacity: 0;
    z-index: 5;
    -webkit-transform: rotate(180deg);
    -moz-transform: rotate(180deg);
    transform: rotate(180deg);
    -webkit-transition-delay: 0.3s;
    -moz-transition-delay: 0.3s;
    transition-delay: 0.3s; }
  .md-checkbox label > span.inc {
    -webkit-animation: growCircle 0.3s ease;
    -moz-animation: growCircle 0.3s ease;
    animation: growCircle 0.3s ease; }
  .md-checkbox input[type=checkbox]:checked ~ label > .box {
    opacity: 0;
    -webkit-transform: scale(0) rotate(-180deg);
    -moz-transform: scale(0) rotate(-180deg);
    transform: scale(0) rotate(-180deg); }
  .md-checkbox input[type=checkbox]:checked ~ label > .check {
    opacity: 1;
    -webkit-transform: scale(1) rotate(45deg);
    -moz-transform: scale(1) rotate(45deg);
    transform: scale(1) rotate(45deg); }
  .md-checkbox input[type=checkbox]:disabled ~ label,
  .md-checkbox input[type=checkbox][disabled] ~ label {
    cursor: not-allowed;
    opacity: 0.7 ;
    filter: alpha(opacity=70) ; }
  .md-checkbox input[type=checkbox]:disabled ~ label > .box,
  .md-checkbox input[type=checkbox][disabled] ~ label > .box {
    cursor: not-allowed;
    opacity: 0.7 ;
    filter: alpha(opacity=70) ; }
  .md-checkbox input[type=checkbox]:disabled:checked ~ label > .check,
  .md-checkbox input[type=checkbox][disabled]:checked ~ label > .check {
    cursor: not-allowed;
    opacity: 0.7 ;
    filter: alpha(opacity=70) ; }

.has-error .md-checkbox label,
.has-error.md-checkbox label {
  color: #e73d4a; }
.has-error .md-checkbox label > .box,
.has-error.md-checkbox label > .box {
  border-color: #e73d4a; }
.has-error .md-checkbox label > .check,
.has-error.md-checkbox label > .check {
  border-color: #e73d4a; }

.has-success .md-checkbox label,
.has-success.md-checkbox label {
  color: #27a4b0; }
.has-success .md-checkbox label > .box,
.has-success.md-checkbox label > .box {
  border-color: #27a4b0; }
.has-success .md-checkbox label > .check,
.has-success.md-checkbox label > .check {
  border-color: #27a4b0; }

.has-warning .md-checkbox label,
.has-warning.md-checkbox label {
  color: #c29d0b; }
.has-warning .md-checkbox label > .box,
.has-warning.md-checkbox label > .box {
  border-color: #c29d0b; }
.has-warning .md-checkbox label > .check,
.has-warning.md-checkbox label > .check {
  border-color: #c29d0b; }

.has-info .md-checkbox label,
.has-info.md-checkbox label {
  color: #327ad5; }
.has-info .md-checkbox label > .box,
.has-info.md-checkbox label > .box {
  border-color: #327ad5; }
.has-info .md-checkbox label > .check,
.has-info.md-checkbox label > .check {
  border-color: #327ad5; }

.form-md-checkboxes {
  padding-top: 5px; }
  .form-md-checkboxes > label {
    font-size: 14px;
    color: #888888;
    opacity: 1 ;
    filter: alpha(opacity=100) ; }
  .form-md-checkboxes.has-error label {
    color: #fbe1e3; }
  .form-md-checkboxes.has-info label {
    color: #e0ebf9; }
  .form-md-checkboxes.has-success label {
    color: #abe7ed; }
  .form-md-checkboxes.has-warning label {
    color: #f9e491; }

.md-checkbox-list {
  margin: 5px 0 5px 0; }
  .form-horizontal .md-checkbox-list {
    margin-top: 5px; }
  .md-checkbox-list .md-checkbox {
    display: block;
    margin-bottom: 10px; }
    .md-checkbox-list .md-checkbox:last-child {
      margin-bottom: 0; }

.md-checkbox-inline {
  margin: 5px 0 5px 0; }
  .form-horizontal .md-checkbox-inline {
    margin-top: 7px; }
  .md-checkbox-inline .md-checkbox {
    display: inline-block;
    margin-right: 20px; }
    .md-checkbox-inline .md-checkbox:last-child {
      margin-right: 0; }

/* bubble animation */
@-webkit-keyframes growCircle {
  0%, 100% {
    -webkit-transform: scale(0);
    opacity: 1; }
  70% {
    background: #eee;
    -webkit-transform: scale(1.25); } }
@-moz-keyframes growCircle {
  0%, 100% {
    -moz-transform: scale(0);
    opacity: 1; }
  70% {
    background: #eee;
    -moz-transform: scale(1.25); } }
@keyframes growCircle {
  0%, 100% {
    transform: scale(0);
    opacity: 1; }
  70% {
    background: #eee;
    transform: scale(1.25); } }
.md-radio {
  position: relative;
  /* handling click events */
  /* when radio is checked */ }
  .md-radio input[type=radio] {
    visibility: hidden;
    position: absolute; }
  .md-radio label {
    cursor: pointer;
    padding-left: 30px; }
  .md-radio label > span {
    display: block;
    position: absolute;
    left: 0;
    -webkit-transition-duration: 0.3s;
    -moz-transition-duration: 0.3s;
    transition-duration: 0.3s; }
  .md-radio label > span.inc {
    background: #fff;
    left: -20px;
    top: -20px;
    height: 60px;
    width: 60px;
    opacity: 0;
    border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    -webkit-border-radius: 50% !important; }
  .md-radio label > .box {
    top: 0px;
    border: 2px solid #666;
    height: 20px;
    width: 20px;
    border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    -webkit-border-radius: 50% !important;
    z-index: 5; }
  .md-radio label > .check {
    top: 5px;
    left: 5px;
    width: 10px;
    height: 10px;
    background: #36c6d3;
    opacity: 0;
    z-index: 6;
    border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    -webkit-border-radius: 50% !important;
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    transform: scale(0); }
  .md-radio label > span.inc {
    -webkit-animation: growCircleRadio 0.3s ease;
    -moz-animation: growCircleRadio 0.3s ease;
    animation: growCircleRadio 0.3s ease; }
  .md-radio input[type=radio]:checked ~ label > .check {
    opacity: 1;
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    transform: scale(1); }
  .md-radio input[type=radio]:disabled ~ label,
  .md-radio input[type=radio][disabled] ~ label {
    cursor: not-allowed;
    opacity: 0.7 ;
    filter: alpha(opacity=70) ; }
  .md-radio input[type=radio]:disabled ~ label > .box,
  .md-radio input[type=radio][disabled] ~ label > .box {
    cursor: not-allowed;
    opacity: 0.7 ;
    filter: alpha(opacity=70) ; }
  .md-radio input[type=radio]:disabled:checked ~ label > .check,
  .md-radio input[type=radio][disabled]:checked ~ label > .check {
    cursor: not-allowed;
    opacity: 0.7 ;
    filter: alpha(opacity=70) ; }

.has-error .md-radio label,
.has-error.md-radio label {
  color: #e73d4a; }
.has-error .md-radio label > .box,
.has-error.md-radio label > .box {
  border-color: #e73d4a; }
.has-error .md-radio label > .check,
.has-error.md-radio label > .check {
  background: #e73d4a; }

.has-success .md-radio label,
.has-success.md-radio label {
  color: #27a4b0; }
.has-success .md-radio label > .box,
.has-success.md-radio label > .box {
  border-color: #27a4b0; }
.has-success .md-radio label > .check,
.has-success.md-radio label > .check {
  background: #27a4b0; }

.has-warning .md-radio label,
.has-warning.md-radio label {
  color: #c29d0b; }
.has-warning .md-radio label > .box,
.has-warning.md-radio label > .box {
  border-color: #c29d0b; }
.has-warning .md-radio label > .check,
.has-warning.md-radio label > .check {
  background: #c29d0b; }

.has-info .md-radio label,
.has-info.md-radio label {
  color: #327ad5; }
.has-info .md-radio label > .box,
.has-info.md-radio label > .box {
  border-color: #327ad5; }
.has-info .md-radio label > .check,
.has-info.md-radio label > .check {
  background: #327ad5; }

.form-md-radios {
  padding-top: 5px; }
  .form-md-radios > label {
    font-size: 14px;
    color: #888888;
    opacity: 1 ;
    filter: alpha(opacity=100) ; }
  .form-md-radios.has-error label {
    color: #fbe1e3; }
  .form-md-radios.has-info label {
    color: #e0ebf9; }
  .form-md-radios.has-success label {
    color: #abe7ed; }
  .form-md-radios.has-warning label {
    color: #f9e491; }

.md-radio-list {
  margin: 5px 0 5px 0; }
  .form-horizontal .md-radio-list {
    margin-top: 5px; }
  .md-radio-list .md-radio {
    display: block;
    margin-bottom: 10px; }

.md-radio-inline {
  margin: 5px 0 5px 0; }
  .form-horizontal .md-radio-inline {
    margin-top: 7px; }
  .md-radio-inline .md-radio {
    display: inline-block;
    margin-right: 20px; }
    .md-radio-inline .md-radio:last-child {
      margin-right: 0; }

/* bubble animation */
@-webkit-keyframes growCircleRadio {
  0%, 100% {
    -webkit-transform: scale(0);
    opacity: 1; }
  70% {
    background: #eee;
    -webkit-transform: scale(1.25); } }
@-moz-keyframes growCircleRadio {
  0%, 100% {
    -moz-transform: scale(0);
    opacity: 1; }
  70% {
    background: #eee;
    -moz-transform: scale(1.25); } }
@keyframes growCircleRadio {
  0%, 100% {
    transform: scale(0);
    opacity: 1; }
  70% {
    background: #eee;
    transform: scale(1.25); } }
/***
General typography
***/
/* Links */
a:hover {
  cursor: pointer; }

/* Primary Link */
.primary-link {
  color: #65A0D0;
  font-weight: 600; }
  .primary-link:hover {
    color: #5194ca; }

p {
  margin: 20px 0; }

label {
  font-weight: normal; }

/* Headings */
h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: "Roboto", sans-serif;
  font-weight: 300; }

h1 {
  font-size: 36px; }

h2 {
  font-size: 30px; }

h3 {
  font-size: 24px; }

h4 {
  font-size: 18px; }

h5 {
  font-size: 14px; }

h6 {
  font-size: 12px; }

/* Headings helper text */
h1 small,
h2 small,
h3 small,
h4 small,
h5 small,
h6 small {
  color: #444444; }

/* Block headings */
h1.block,
h2.block,
h3.block,
h4.block,
h5.block,
h6.block {
  padding-top: 10px;
  padding-bottom: 10px; }

/* Links */
a {
  text-shadow: none;
  color: #337ab7; }
  a:hover {
    color: #23527c; }
  a:focus, a:hover, a:active {
    outline: 0; }

/* Horizontal break */
hr {
  margin: 20px 0;
  border: 0;
  border-top: 1px solid #eee;
  border-bottom: 0; }

/* Unstyled List */
.list-unstyled li > .list-unstyled {
  margin-left: 25px; }

/* Code */
code {
  border: 1px solid #e1e1e1;
  -webkit-box-shadow: 0 1px 4px rgba(0, 0, 0, 0.1);
  -moz-box-shadow: 0 1px 4px rgba(0, 0, 0, 0.1);
  box-shadow: 0 1px 4px rgba(0, 0, 0, 0.1); }

/* Disabled Navigation Link */
.disabled-link.disable-target,
.disabled-link .disable-target {
  opacity: 0.6 !important;
  filter: alpha(opacity=60) !important; }
  .disabled-link.disable-target:hover,
  .disabled-link .disable-target:hover {
    cursor: not-allowed !important; }
.disabled-link:hover {
  cursor: not-allowed !important; }

/***
Utilities
***/
/* Rounded Element */
.rounded-2 {
  border-radius: 2px !important; }

.rounded-3 {
  border-radius: 3px !important; }

.rounded-4 {
  border-radius: 4px !important; }

/* Circle Element */
.circle {
  border-radius: 25px !important; }

.circle-right {
  border-radius: 0 25px 25px 0 !important; }

.circle-left {
  border-radius: 25px 0 0 25px !important; }

.circle-bottom {
  border-radius: 0 0 25px 25px !important; }

.circle-top {
  border-radius: 25px 25px 0 0 !important; }

.rounded {
  border-radius: 50% !important; }

/* General utilities */
.display-none,
.display-hide {
  display: none; }

.hidden {
  display: none !important; }

.primary-font {
  font-family: "Roboto", sans-serif !important; }

.bold {
  font-weight: 700 !important; }
  .bold.btn {
    letter-spacing: 0; }

.sbold {
  font-weight: 600 !important; }
  .sbold.btn {
    letter-spacing: 0; }

.thin {
  font-weight: 500 !important; }

.uppercase {
  text-transform: uppercase !important; }

.fix-margin {
  margin-left: 0px !important; }

.border {
  border: 1px solid red; }

.font-hg {
  font-size: 23px; }

.font-lg {
  font-size: 18px; }

.font-md {
  font-size: 14px; }

.font-sm {
  font-size: 13px; }

.font-xs {
  font-size: 11px; }

.inline {
  display: inline; }

.inline-block {
  display: inline-block; }

.text-align-reverse {
  text-align: right; }

/* Margin and padding utilities */
.no-space {
  margin: 0px !important;
  padding: 0px !important; }

.no-margin {
  margin: 0; }

.margin-bottom-5 {
  margin-bottom: 5px; }

.margin-bottom-10 {
  margin-bottom: 10px !important; }

.margin-top-10 {
  margin-top: 10px !important; }

.margin-top-15 {
  margin-top: 15px !important; }

.margin-bottom-15 {
  margin-bottom: 15px !important; }

.margin-bottom-20 {
  margin-bottom: 20px !important; }

.margin-top-20 {
  margin-top: 20px !important; }

.margin-top-30 {
  margin-top: 30px !important; }

.margin-top-40 {
  margin-top: 40px !important; }

.margin-bottom-25 {
  margin-bottom: 25px !important; }

.margin-bottom-30 {
  margin-bottom: 30px !important; }

.margin-bottom-40 {
  margin-bottom: 40px !important; }

.margin-right-10 {
  margin-right: 10px !important; }

/* IE8 & IE9 mode utilities */
.visible-ie8 {
  display: none; }

.ie8 .visible-ie8 {
  display: inherit !important; }

.visible-ie9 {
  display: none; }

.ie9 .visible-ie9 {
  display: inherit !important; }

.hidden-ie8 {
  display: inherit; }

.ie8 .hidden-ie8 {
  display: none !important; }

.hidden-ie9 {
  display: inherit; }

.ie9 .hidden-ie9 {
  display: none !important; }

/***
Responsive Utils
***/
@media (max-width: 1024px) {
  .hidden-1024 {
    display: none; } }
@media (max-width: 480px) {
  .hidden-480 {
    display: none; } }
@media (max-width: 320px) {
  .hidden-320 {
    display: none; } }
/***
Demo Utils
***/
.scrollspy-example {
  position: relative;
  height: 200px;
  margin-top: 10px;
  overflow: auto; }

.util-btn-margin-bottom-5 .btn {
  margin-bottom: 5px !important; }

.util-btn-group-margin-bottom-5 .btn-group {
  margin-bottom: 5px !important; }

.padding-tb-10 {
  padding: 10px 0; }

.padding-tb-15 {
  padding: 10px 0; }

.padding-tb-20 {
  padding: 20px 0; }

/***
Users
***/
.user-info {
  margin-bottom: 10px !important; }
  .user-info img {
    float: left;
    margin-right: 5px; }
  .user-info .details {
    display: inline-block; }
  .user-info .label {
    font-weight: 300;
    font-size: 11px; }

/***
Custom vertical inline menu
***/
.ver-inline-menu {
  padding: 0;
  margin: 0;
  list-style: none; }
  .ver-inline-menu li {
    position: relative;
    margin-bottom: 1px; }
    .ver-inline-menu li i {
      width: 37px;
      height: 37px;
      display: inline-block;
      color: #b9cbd5;
      font-size: 15px;
      padding: 12px 10px 10px 8px;
      margin: 0 8px 0 0;
      text-align: center;
      background: #e0eaf0 !important; }
    .ver-inline-menu li a {
      font-size: 14px;
      font-weight: 300;
      color: #557386;
      display: block;
      background: #f0f6fa;
      border-left: solid 2px #c4d5df; }
    .ver-inline-menu li:hover a {
      background: #e0eaf0;
      text-decoration: none; }
    .ver-inline-menu li:hover i {
      color: #fff;
      background: #c4d5df !important; }
    .ver-inline-menu li.active a {
      border-left: solid 2px #0c91e5; }
    .ver-inline-menu li.active i {
      background: #0c91e5 !important; }
    .ver-inline-menu li.active a, .ver-inline-menu li.active i {
      color: #fff;
      background: #169ef4;
      text-decoration: none; }
    .ver-inline-menu li.active a, .ver-inline-menu li:hover a {
      font-size: 14px; }
    .ver-inline-menu li.active:after {
      content: '';
      display: inline-block;
      border-bottom: 6px solid transparent;
      border-top: 6px solid transparent;
      border-left: 6px solid #169ef4;
      position: absolute;
      top: 12px;
      right: -5px; }

.ver-inline-menu {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px; }

@media (max-width: 767px) {
  .ver-inline-menu > li.active:after {
    display: none; } }
/***
Separated List
***/
.list-separated {
  margin-top: 10px;
  margin-bottom: 15px; }
  .list-separated > div:last-child {
    border-right: 0; }
  @media (max-width: 767px) {
    .list-separated {
      /* 767px */ }
      .list-separated > div {
        margin-bottom: 20px; } }

/***
Number & Chart Stats
***/
.number-stats {
  margin: 10px 0; }
  .number-stats .stat-number {
    display: inline-block;
    margin: 0 5px; }
    .number-stats .stat-number .title {
      font-size: 13px;
      margin-bottom: 3px;
      color: #B8C3C7; }
    .number-stats .stat-number .number {
      font-size: 27px;
      line-height: 27px;
      color: #7D8C9D; }
  .number-stats .stat-chart {
    display: inline-block;
    margin: 0 5px; }
  .number-stats > div {
    border-right: 1px solid #f5f5f5; }
    .number-stats > div:last-child {
      border-right: 0; }
  .number-stats .stat-left {
    float: right; }
    .number-stats .stat-left .stat-number {
      float: right;
      text-align: right; }
    .number-stats .stat-left .stat-chart {
      float: right; }
  .number-stats .stat-right {
    float: left !important; }
    .number-stats .stat-right .stat-number {
      float: left;
      text-align: left; }
    .number-stats .stat-right .stat-chart {
      float: left; }
  .number-stats .stat-number {
    float: left;
    text-align: left; }
  .number-stats .stat-chart {
    float: left; }

/***
General User Record Listing
***/
.general-item-list > .item {
  padding: 10px 0;
  border-bottom: 1px solid #F1F4F7; }
  .general-item-list > .item:last-child {
    border-bottom: 0; }
  .general-item-list > .item > .item-head {
    margin-bottom: 5px; }
    .general-item-list > .item > .item-head:before, .general-item-list > .item > .item-head:after {
      content: " ";
      display: table; }
    .general-item-list > .item > .item-head:after {
      clear: both; }
    .general-item-list > .item > .item-head > .item-details {
      display: inline-block;
      float: left; }
      .general-item-list > .item > .item-head > .item-details > .item-pic {
        height: 35px;
        margin-right: 10px;
        -webkit-border-radius: 100%;
        -moz-border-radius: 100%;
        -ms-border-radius: 100%;
        -o-border-radius: 100%;
        border-radius: 100%; }
      .general-item-list > .item > .item-head > .item-details > .item-name {
        display: inline-block;
        margin-right: 10px; }
      .general-item-list > .item > .item-head > .item-details > .item-label {
        color: #C0C9CC; }
    .general-item-list > .item > .item-head > .item-status {
      color: #C0C9CC;
      top: 10px;
      position: relative;
      display: inline-block;
      float: right; }
      .general-item-list > .item > .item-head > .item-status > .badge {
        margin-top: -2px; }
  .general-item-list > .item > .item-body {
    color: #96a5aa; }

/***
File dropzone
***/
.file-drop-zone {
  border: 2px dashed #ddd;
  padding: 30px;
  text-align: center; }
  .file-drop-zone.file-drop-zone-over {
    border-color: #aaa; }

.m-grid {
  display: table;
  width: 100%;
  table-layout: fixed; }
  .m-grid.m-grid-auto {
    width: auto; }
  .m-grid.m-grid-full-height {
    height: 100%; }
    .m-grid.m-grid-full-height > .m-grid-row {
      height: 100%;
      position: static; }
      .m-grid.m-grid-full-height > .m-grid-row > .m-grid-col {
        height: 100%; }
    .m-grid.m-grid-full-height > .m-grid-col {
      height: 100%; }
  .m-grid .m-grid-row {
    display: table-row; }
    .m-grid .m-grid-row.m-grid-row-full-height {
      height: 100%;
      position: static; }
    .m-grid .m-grid-row.m-grid-row-auto-height {
      height: auto; }
      .m-grid .m-grid-row.m-grid-row-auto-height > .m-grid-col {
        height: auto; }
  .m-grid .m-grid-col {
    display: table-cell;
    text-align: left;
    vertical-align: top; }
    .m-grid .m-grid-col.m-grid-col-full-width {
      width: 100%; }
    .m-grid .m-grid-col.m-grid-col-full-height {
      height: 100%; }
    .m-grid .m-grid-col.m-grid-col-auto-height {
      height: auto; }
    .m-grid .m-grid-col.m-grid-col-top {
      vertical-align: top; }
    .m-grid .m-grid-col.m-grid-col-middle {
      vertical-align: middle; }
    .m-grid .m-grid-col.m-grid-col-bottom {
      vertical-align: bottom; }
    .m-grid .m-grid-col.m-grid-col-left {
      text-align: left; }
    .m-grid .m-grid-col.m-grid-col-center {
      text-align: center; }
    .m-grid .m-grid-col.m-grid-col-right {
      text-align: right; }
    .m-grid .m-grid-col:not(.m-grid-col-middle):not(.m-grid-col-bottom) {
      vertical-align: top; }
    .m-grid .m-grid-col.m-grid-col-xs, .m-grid .m-grid-col.m-grid-col-sm, .m-grid .m-grid-col.m-grid-col-md, .m-grid .m-grid-col.m-grid-col-lg {
      width: 100%;
      display: block; }

.m-grid.m-grid-demo .m-grid-col {
  border: 1px solid #ddd;
  background: #fafafa;
  height: 100px; }

.m-grid-col-xs-1 {
  width: 8.33333%; }

.m-grid-col-xs-offset-1 {
  margin-left: 8.33333%; }

.m-grid-col-xs-2 {
  width: 16.66667%; }

.m-grid-col-xs-offset-2 {
  margin-left: 16.66667%; }

.m-grid-col-xs-3 {
  width: 25%; }

.m-grid-col-xs-offset-3 {
  margin-left: 25%; }

.m-grid-col-xs-4 {
  width: 33.33333%; }

.m-grid-col-xs-offset-4 {
  margin-left: 33.33333%; }

.m-grid-col-xs-5 {
  width: 41.66667%; }

.m-grid-col-xs-offset-5 {
  margin-left: 41.66667%; }

.m-grid-col-xs-6 {
  width: 50%; }

.m-grid-col-xs-offset-6 {
  margin-left: 50%; }

.m-grid-col-xs-7 {
  width: 58.33333%; }

.m-grid-col-xs-offset-7 {
  margin-left: 58.33333%; }

.m-grid-col-xs-8 {
  width: 66.66667%; }

.m-grid-col-xs-offset-8 {
  margin-left: 66.66667%; }

.m-grid-col-xs-9 {
  width: 75%; }

.m-grid-col-xs-offset-9 {
  margin-left: 75%; }

.m-grid-col-xs-10 {
  width: 83.33333%; }

.m-grid-col-xs-offset-10 {
  margin-left: 83.33333%; }

.m-grid-col-xs-11 {
  width: 91.66667%; }

.m-grid-col-xs-offset-11 {
  margin-left: 91.66667%; }

.m-grid-col-xs-12 {
  width: 100%; }

.m-grid-col-xs-offset-12 {
  margin-left: 100%; }

@media (min-width: 767px) {
  .m-grid-col-sm-1 {
    width: 8.33333%; }

  .m-grid-col-sm-offset-1 {
    margin-left: 8.33333%; }

  .m-grid-col-sm-2 {
    width: 16.66667%; }

  .m-grid-col-sm-offset-2 {
    margin-left: 16.66667%; }

  .m-grid-col-sm-3 {
    width: 25%; }

  .m-grid-col-sm-offset-3 {
    margin-left: 25%; }

  .m-grid-col-sm-4 {
    width: 33.33333%; }

  .m-grid-col-sm-offset-4 {
    margin-left: 33.33333%; }

  .m-grid-col-sm-5 {
    width: 41.66667%; }

  .m-grid-col-sm-offset-5 {
    margin-left: 41.66667%; }

  .m-grid-col-sm-6 {
    width: 50%; }

  .m-grid-col-sm-offset-6 {
    margin-left: 50%; }

  .m-grid-col-sm-7 {
    width: 58.33333%; }

  .m-grid-col-sm-offset-7 {
    margin-left: 58.33333%; }

  .m-grid-col-sm-8 {
    width: 66.66667%; }

  .m-grid-col-sm-offset-8 {
    margin-left: 66.66667%; }

  .m-grid-col-sm-9 {
    width: 75%; }

  .m-grid-col-sm-offset-9 {
    margin-left: 75%; }

  .m-grid-col-sm-10 {
    width: 83.33333%; }

  .m-grid-col-sm-offset-10 {
    margin-left: 83.33333%; }

  .m-grid-col-sm-11 {
    width: 91.66667%; }

  .m-grid-col-sm-offset-11 {
    margin-left: 91.66667%; }

  .m-grid-col-sm-12 {
    width: 100%; }

  .m-grid-col-sm-offset-12 {
    margin-left: 100%; } }
@media (min-width: 991px) {
  .m-grid-col-md-1 {
    width: 8.33333%; }

  .m-grid-col-md-offset-1 {
    margin-left: 8.33333%; }

  .m-grid-col-md-2 {
    width: 16.66667%; }

  .m-grid-col-md-offset-2 {
    margin-left: 16.66667%; }

  .m-grid-col-md-3 {
    width: 25%; }

  .m-grid-col-md-offset-3 {
    margin-left: 25%; }

  .m-grid-col-md-4 {
    width: 33.33333%; }

  .m-grid-col-md-offset-4 {
    margin-left: 33.33333%; }

  .m-grid-col-md-5 {
    width: 41.66667%; }

  .m-grid-col-md-offset-5 {
    margin-left: 41.66667%; }

  .m-grid-col-md-6 {
    width: 50%; }

  .m-grid-col-md-offset-6 {
    margin-left: 50%; }

  .m-grid-col-md-7 {
    width: 58.33333%; }

  .m-grid-col-md-offset-7 {
    margin-left: 58.33333%; }

  .m-grid-col-md-8 {
    width: 66.66667%; }

  .m-grid-col-md-offset-8 {
    margin-left: 66.66667%; }

  .m-grid-col-md-9 {
    width: 75%; }

  .m-grid-col-md-offset-9 {
    margin-left: 75%; }

  .m-grid-col-md-10 {
    width: 83.33333%; }

  .m-grid-col-md-offset-10 {
    margin-left: 83.33333%; }

  .m-grid-col-md-11 {
    width: 91.66667%; }

  .m-grid-col-md-offset-11 {
    margin-left: 91.66667%; }

  .m-grid-col-md-12 {
    width: 100%; }

  .m-grid-col-md-offset-12 {
    margin-left: 100%; } }
@media (min-width: 1259px) {
  .m-grid-col-lg-1 {
    width: 8.33333%; }

  .m-grid-col-lg-offset-1 {
    margin-left: 8.33333%; }

  .m-grid-col-lg-2 {
    width: 16.66667%; }

  .m-grid-col-lg-offset-2 {
    margin-left: 16.66667%; }

  .m-grid-col-lg-3 {
    width: 25%; }

  .m-grid-col-lg-offset-3 {
    margin-left: 25%; }

  .m-grid-col-lg-4 {
    width: 33.33333%; }

  .m-grid-col-lg-offset-4 {
    margin-left: 33.33333%; }

  .m-grid-col-lg-5 {
    width: 41.66667%; }

  .m-grid-col-lg-offset-5 {
    margin-left: 41.66667%; }

  .m-grid-col-lg-6 {
    width: 50%; }

  .m-grid-col-lg-offset-6 {
    margin-left: 50%; }

  .m-grid-col-lg-7 {
    width: 58.33333%; }

  .m-grid-col-lg-offset-7 {
    margin-left: 58.33333%; }

  .m-grid-col-lg-8 {
    width: 66.66667%; }

  .m-grid-col-lg-offset-8 {
    margin-left: 66.66667%; }

  .m-grid-col-lg-9 {
    width: 75%; }

  .m-grid-col-lg-offset-9 {
    margin-left: 75%; }

  .m-grid-col-lg-10 {
    width: 83.33333%; }

  .m-grid-col-lg-offset-10 {
    margin-left: 83.33333%; }

  .m-grid-col-lg-11 {
    width: 91.66667%; }

  .m-grid-col-lg-offset-11 {
    margin-left: 91.66667%; }

  .m-grid-col-lg-12 {
    width: 100%; }

  .m-grid-col-lg-offset-12 {
    margin-left: 100%; } }
@media (max-width: 479px) {
  .m-grid.m-grid-responsive-xs {
    display: block;
    width: auto; }
    .m-grid.m-grid-responsive-xs > .m-grid-row,
    .m-grid.m-grid-responsive-xs > .m-grid-row > .m-grid-col,
    .m-grid.m-grid-responsive-xs > .m-grid-col {
      display: block;
      width: auto;
      height: auto; }
    .m-grid.m-grid-responsive-xs > .m-grid-row {
      display: flex;
      flex-flow: column; }
    .m-grid.m-grid-responsive-xs.m-grid-flex {
      display: flex;
      flex-flow: column; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-2,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-2 {
        order: 2; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-3,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-3 {
        order: 3; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-4,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-4 {
        order: 4; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-5,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-5 {
        order: 5; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-6,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-6 {
        order: 6; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-7,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-7 {
        order: 7; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-8,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-8 {
        order: 8; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-9,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-9 {
        order: 9; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-10,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-10 {
        order: 10; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-11,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-11 {
        order: 11; }
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-row > .m-grid-col-order-12,
      .m-grid.m-grid-responsive-xs.m-grid-flex > .m-grid-col-order-12 {
        order: 12; } }
@media (max-width: 767px) {
  .m-grid.m-grid-responsive-sm {
    display: block;
    width: auto; }
    .m-grid.m-grid-responsive-sm > .m-grid-row,
    .m-grid.m-grid-responsive-sm > .m-grid-row > .m-grid-col,
    .m-grid.m-grid-responsive-sm > .m-grid-col {
      display: block;
      width: auto;
      height: auto; }
    .m-grid.m-grid-responsive-sm > .m-grid-row {
      display: flex;
      flex-flow: column; }
    .m-grid.m-grid-responsive-sm.m-grid-flex {
      display: flex;
      flex-flow: column; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-2,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-2 {
        order: 2; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-3,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-3 {
        order: 3; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-4,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-4 {
        order: 4; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-5,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-5 {
        order: 5; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-6,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-6 {
        order: 6; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-7,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-7 {
        order: 7; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-8,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-8 {
        order: 8; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-9,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-9 {
        order: 9; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-10,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-10 {
        order: 10; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-11,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-11 {
        order: 11; }
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-row > .m-grid-col-order-12,
      .m-grid.m-grid-responsive-sm.m-grid-flex > .m-grid-col-order-12 {
        order: 12; } }
@media (max-width: 991px) {
  .m-grid.m-grid-responsive-md {
    display: block;
    width: auto; }
    .m-grid.m-grid-responsive-md > .m-grid-row,
    .m-grid.m-grid-responsive-md > .m-grid-row > .m-grid-col,
    .m-grid.m-grid-responsive-md > .m-grid-col {
      display: block;
      width: auto;
      height: auto; }
    .m-grid.m-grid-responsive-md > .m-grid-row {
      display: flex;
      flex-flow: column; }
    .m-grid.m-grid-responsive-md.m-grid-flex {
      display: flex;
      flex-flow: column; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-2,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-2 {
        order: 2; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-3,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-3 {
        order: 3; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-4,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-4 {
        order: 4; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-5,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-5 {
        order: 5; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-6,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-6 {
        order: 6; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-7,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-7 {
        order: 7; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-8,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-8 {
        order: 8; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-9,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-9 {
        order: 9; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-10,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-10 {
        order: 10; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-11,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-11 {
        order: 11; }
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-row > .m-grid-col-order-12,
      .m-grid.m-grid-responsive-md.m-grid-flex > .m-grid-col-order-12 {
        order: 12; } }
@media (max-width: 1259px) {
  .m-grid.m-grid-responsive-lg {
    display: block;
    width: auto; }
    .m-grid.m-grid-responsive-lg > .m-grid-row,
    .m-grid.m-grid-responsive-lg > .m-grid-row > .m-grid-col,
    .m-grid.m-grid-responsive-lg > .m-grid-col {
      display: block;
      width: auto;
      height: auto; }
    .m-grid.m-grid-responsive-lg > .m-grid-row {
      display: flex;
      flex-flow: column; }
    .m-grid.m-grid-responsive-lg.m-grid-flex {
      display: flex;
      flex-flow: column; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-2,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-2 {
        order: 2; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-3,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-3 {
        order: 3; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-4,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-4 {
        order: 4; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-5,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-5 {
        order: 5; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-6,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-6 {
        order: 6; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-7,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-7 {
        order: 7; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-8,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-8 {
        order: 8; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-9,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-9 {
        order: 9; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-10,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-10 {
        order: 10; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-11,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-11 {
        order: 11; }
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-row > .m-grid-col-order-12,
      .m-grid.m-grid-responsive-lg.m-grid-flex > .m-grid-col-order-12 {
        order: 12; } }
/***
Fontawesome Icons
***/
[class^="fa-"]:not(.fa-stack),
[class^="glyphicon-"],
[class^="icon-"],
[class*=" fa-"]:not(.fa-stack),
[class*=" glyphicon-"],
[class*=" icon-"] {
  display: inline-block;
  *margin-right: .3em;
  line-height: 14px;
  -webkit-font-smoothing: antialiased; }

/* Make font awesome icons fixed width */
li [class^="fa-"],
li [class^="glyphicon-"],
li [class^="icon-"],
li [class*=" fa-"],
li [class*=" glyphicon-"],
li [class*=" icon-"] {
  display: inline-block;
  width: 1.25em;
  text-align: center; }

li [class^="glyphicon-"],
li [class*=" glyphicon-"] {
  top: 2px; }

li [class^="icon-"],
li [class*=" icon-"] {
  top: 1px;
  position: relative; }

li [class^="fa-"].icon-large,
li [class^="glyphicon-"].icon-large,
li [class^="icon-"].icon-large,
li [class*=" fa-"].icon-large,
li [class*=" glyphicon-"].icon-large,
li [class*=" icon-"].icon-large {
  /* increased font size for icon-large */
  width: 1.5625em; }

/* Icon states */
.icon-state-default {
  color: #bac3d0; }

.icon-state-success {
  color: #36c6d3; }

.icon-state-info {
  color: #659be0; }

.icon-state-warning {
  color: #F1C40F; }

.icon-state-danger {
  color: #ed6b75; }

/***
Font Awesome 4.x Demo
***/
.fa-item {
  font-size: 14px;
  padding: 10px 10px 10px 20px; }
  .fa-item i {
    font-size: 16px;
    display: inline-block;
    width: 20px;
    color: #333; }
  .fa-item:hover {
    cursor: pointer;
    background: #eee; }

/***
Simple Line Icons Demo
***/
.simplelineicons-demo .item-box {
  display: inline-block;
  font-size: 16px;
  margin: 0 -0.22em 1em 0;
  padding-left: 1em;
  width: 100%; }
  .simplelineicons-demo .item-box .item {
    background-color: #fff;
    color: #33383e;
    border-radius: 8px;
    display: inline-block;
    padding: 10px;
    width: 100%; }
    .simplelineicons-demo .item-box .item span {
      font-size: 22px; }

@media only screen and (min-width: 768px) {
  .simplelineicons-demo .item-box {
    width: 33.333%; } }
/*** 
Glyphicons Demo
***/
.glyphicons-demo ul {
  padding-left: 0;
  padding-bottom: 1px;
  margin-bottom: 20px;
  list-style: none;
  overflow: hidden; }

.bs-glyphicon-class {
  text-align: center; }

.bs-glyphicons {
  padding-left: 0;
  padding-bottom: 1px;
  margin-bottom: 20px;
  list-style: none;
  overflow: hidden; }

.glyphicons-demo ul li {
  float: left;
  width: 25%;
  height: 115px;
  padding: 10px;
  margin: 0 -1px -1px 0;
  font-size: 14px;
  line-height: 1.4;
  text-align: center;
  border: 1px solid #ddd; }

.glyphicons-demo .glyphicon {
  display: block;
  margin: 5px auto 10px;
  font-size: 24px;
  color: #444; }

.glyphicons-demo ul li:hover {
  background-color: rgba(86, 61, 124, 0.1); }

@media (min-width: 768px) {
  .glyphicons-demo ul li {
    width: 12.5%; } }
/***
Customized Bootstrap Alerts
***/
.alert {
  border-width: 1px; }
  .alert > p {
    margin: 0; }
  .alert.alert-borderless {
    border: 0; }

.alert {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  border-width: 0; }

/***
Custom Bootstrap Badges
***/
.badge {
  font-size: 11px !important;
  font-weight: 300;
  text-align: center;
  height: 18px;
  color: #fff;
  padding: 3px 6px 3px 6px;
  -webkit-border-radius: 12px !important;
  -moz-border-radius: 12px !important;
  border-radius: 12px !important;
  text-shadow: none !important;
  text-align: center;
  vertical-align: middle; }
  .badge.badge-roundless {
    -webkit-border-radius: 0 !important;
    -moz-border-radius: 0 !important;
    border-radius: 0 !important; }
  .badge.badge-empty {
    display: inline-block;
    padding: 0;
    min-width: 8px;
    height: 8px;
    width: 8px; }

/* Badge variants */
.badge-default {
  background-color: #bac3d0;
  background-image: none; }

.badge-primary {
  background-color: #17b8b6;
  background-image: none; }

.badge-info {
  background-color: #659be0;
  background-image: none; }

.badge-success {
  background-color: #36c6d3;
  background-image: none; }

.badge-danger {
  background-color: #ed6b75;
  background-image: none; }

.badge-warning {
  background-color: #F1C40F;
  background-image: none; }

/* Fix badge position for navs */
.nav.nav-pills > li > a > .badge,
.nav.nav-stacked > li > a > .badge {
  margin-top: -2px; }

/***
Dropdown Menu Badges
***/
.dropdown-menu > li > a > .badge {
  position: absolute;
  margin-top: 1px;
  right: 3px;
  display: inline;
  padding: 4px 6px 2px 6px; }
.dropdown-menu.badge-roundless {
  -webkit-border-radius: 0 !important;
  -moz-border-radius: 0 !important;
  border-radius: 0 !important; }

.badge {
  text-transform: uppercase;
  font-size: 10px;
  font-weight: 600;
  padding: 4px 6px 2px 6px; }

.page-sidebar .badge {
  font-size: 10px !important; }

/***
Custom buttons based on bootstrap SASS
***/
.btn {
  outline: none !important; }
  .btn:hover {
    transition: all 0.3s; }

.btn:not(.btn-sm):not(.btn-lg) {
  line-height: 1.44; }

/***
Custom color buttons 
***/
.btn.white:not(.btn-outline) {
  color: #666;
  background-color: #ffffff;
  border-color: #ffffff; }
  .btn.white:not(.btn-outline):focus, .btn.white:not(.btn-outline).focus {
    color: #666;
    background-color: #e6e6e6;
    border-color: #bfbfbf; }
  .btn.white:not(.btn-outline):hover {
    color: #666;
    background-color: #e6e6e6;
    border-color: #e0e0e0; }
  .btn.white:not(.btn-outline):active, .btn.white:not(.btn-outline).active, .open > .btn.white:not(.btn-outline).dropdown-toggle {
    color: #666;
    background-color: #e6e6e6;
    border-color: #e0e0e0; }
    .btn.white:not(.btn-outline):active:hover, .btn.white:not(.btn-outline):active:focus, .btn.white:not(.btn-outline):active.focus, .btn.white:not(.btn-outline).active:hover, .btn.white:not(.btn-outline).active:focus, .btn.white:not(.btn-outline).active.focus, .open > .btn.white:not(.btn-outline).dropdown-toggle:hover, .open > .btn.white:not(.btn-outline).dropdown-toggle:focus, .open > .btn.white:not(.btn-outline).dropdown-toggle.focus {
      color: #666;
      background-color: #d4d4d4;
      border-color: #bfbfbf; }
  .btn.white:not(.btn-outline):active, .btn.white:not(.btn-outline).active, .open > .btn.white:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.white:not(.btn-outline).disabled:hover, .btn.white:not(.btn-outline).disabled:focus, .btn.white:not(.btn-outline).disabled.focus, .btn.white:not(.btn-outline)[disabled]:hover, .btn.white:not(.btn-outline)[disabled]:focus, .btn.white:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.white:not(.btn-outline):hover, fieldset[disabled] .btn.white:not(.btn-outline):focus, fieldset[disabled] .btn.white:not(.btn-outline).focus {
    background-color: #ffffff;
    border-color: #ffffff; }
  .btn.white:not(.btn-outline) .badge {
    color: #ffffff;
    background-color: #666; }

.btn.btn-outline.white {
  border-color: #ffffff;
  color: #ffffff;
  background: none; }
  .btn.btn-outline.white:hover, .btn.btn-outline.white:active, .btn.btn-outline.white:active:hover, .btn.btn-outline.white:active:focus, .btn.btn-outline.white:focus, .btn.btn-outline.white.active {
    border-color: #ffffff;
    color: #666;
    background-color: #ffffff; }

.btn.white-stripe {
  border-left: 4px solid #ffffff !important; }

.btn.white.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.default:not(.btn-outline) {
  color: #666;
  background-color: #e1e5ec;
  border-color: #e1e5ec; }
  .btn.default:not(.btn-outline):focus, .btn.default:not(.btn-outline).focus {
    color: #666;
    background-color: #c2cad8;
    border-color: #93a1bb; }
  .btn.default:not(.btn-outline):hover {
    color: #666;
    background-color: #c2cad8;
    border-color: #bcc5d4; }
  .btn.default:not(.btn-outline):active, .btn.default:not(.btn-outline).active, .open > .btn.default:not(.btn-outline).dropdown-toggle {
    color: #666;
    background-color: #c2cad8;
    border-color: #bcc5d4; }
    .btn.default:not(.btn-outline):active:hover, .btn.default:not(.btn-outline):active:focus, .btn.default:not(.btn-outline):active.focus, .btn.default:not(.btn-outline).active:hover, .btn.default:not(.btn-outline).active:focus, .btn.default:not(.btn-outline).active.focus, .open > .btn.default:not(.btn-outline).dropdown-toggle:hover, .open > .btn.default:not(.btn-outline).dropdown-toggle:focus, .open > .btn.default:not(.btn-outline).dropdown-toggle.focus {
      color: #666;
      background-color: #acb7ca;
      border-color: #93a1bb; }
  .btn.default:not(.btn-outline):active, .btn.default:not(.btn-outline).active, .open > .btn.default:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.default:not(.btn-outline).disabled:hover, .btn.default:not(.btn-outline).disabled:focus, .btn.default:not(.btn-outline).disabled.focus, .btn.default:not(.btn-outline)[disabled]:hover, .btn.default:not(.btn-outline)[disabled]:focus, .btn.default:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.default:not(.btn-outline):hover, fieldset[disabled] .btn.default:not(.btn-outline):focus, fieldset[disabled] .btn.default:not(.btn-outline).focus {
    background-color: #e1e5ec;
    border-color: #e1e5ec; }
  .btn.default:not(.btn-outline) .badge {
    color: #e1e5ec;
    background-color: #666; }

.btn.btn-outline.default {
  border-color: #e1e5ec;
  color: #e1e5ec;
  background: none; }
  .btn.btn-outline.default:hover, .btn.btn-outline.default:active, .btn.btn-outline.default:active:hover, .btn.btn-outline.default:active:focus, .btn.btn-outline.default:focus, .btn.btn-outline.default.active {
    border-color: #e1e5ec;
    color: #666;
    background-color: #e1e5ec; }

.btn.default-stripe {
  border-left: 4px solid #e1e5ec !important; }

.btn.default.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.dark:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #2f353b;
  border-color: #2f353b; }
  .btn.dark:not(.btn-outline):focus, .btn.dark:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #181c1f;
    border-color: black; }
  .btn.dark:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #181c1f;
    border-color: #141619; }
  .btn.dark:not(.btn-outline):active, .btn.dark:not(.btn-outline).active, .open > .btn.dark:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #181c1f;
    border-color: #141619; }
    .btn.dark:not(.btn-outline):active:hover, .btn.dark:not(.btn-outline):active:focus, .btn.dark:not(.btn-outline):active.focus, .btn.dark:not(.btn-outline).active:hover, .btn.dark:not(.btn-outline).active:focus, .btn.dark:not(.btn-outline).active.focus, .open > .btn.dark:not(.btn-outline).dropdown-toggle:hover, .open > .btn.dark:not(.btn-outline).dropdown-toggle:focus, .open > .btn.dark:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #090a0b;
      border-color: black; }
  .btn.dark:not(.btn-outline):active, .btn.dark:not(.btn-outline).active, .open > .btn.dark:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.dark:not(.btn-outline).disabled:hover, .btn.dark:not(.btn-outline).disabled:focus, .btn.dark:not(.btn-outline).disabled.focus, .btn.dark:not(.btn-outline)[disabled]:hover, .btn.dark:not(.btn-outline)[disabled]:focus, .btn.dark:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.dark:not(.btn-outline):hover, fieldset[disabled] .btn.dark:not(.btn-outline):focus, fieldset[disabled] .btn.dark:not(.btn-outline).focus {
    background-color: #2f353b;
    border-color: #2f353b; }
  .btn.dark:not(.btn-outline) .badge {
    color: #2f353b;
    background-color: #FFFFFF; }

.btn.btn-outline.dark {
  border-color: #2f353b;
  color: #2f353b;
  background: none; }
  .btn.btn-outline.dark:hover, .btn.btn-outline.dark:active, .btn.btn-outline.dark:active:hover, .btn.btn-outline.dark:active:focus, .btn.btn-outline.dark:focus, .btn.btn-outline.dark.active {
    border-color: #2f353b;
    color: #FFFFFF;
    background-color: #2f353b; }

.btn.dark-stripe {
  border-left: 4px solid #2f353b !important; }

.btn.dark.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #3598dc;
  border-color: #3598dc; }
  .btn.blue:not(.btn-outline):focus, .btn.blue:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #217ebd;
    border-color: #15527c; }
  .btn.blue:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #217ebd;
    border-color: #1f78b5; }
  .btn.blue:not(.btn-outline):active, .btn.blue:not(.btn-outline).active, .open > .btn.blue:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #217ebd;
    border-color: #1f78b5; }
    .btn.blue:not(.btn-outline):active:hover, .btn.blue:not(.btn-outline):active:focus, .btn.blue:not(.btn-outline):active.focus, .btn.blue:not(.btn-outline).active:hover, .btn.blue:not(.btn-outline).active:focus, .btn.blue:not(.btn-outline).active.focus, .open > .btn.blue:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #1c699f;
      border-color: #15527c; }
  .btn.blue:not(.btn-outline):active, .btn.blue:not(.btn-outline).active, .open > .btn.blue:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue:not(.btn-outline).disabled:hover, .btn.blue:not(.btn-outline).disabled:focus, .btn.blue:not(.btn-outline).disabled.focus, .btn.blue:not(.btn-outline)[disabled]:hover, .btn.blue:not(.btn-outline)[disabled]:focus, .btn.blue:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue:not(.btn-outline):hover, fieldset[disabled] .btn.blue:not(.btn-outline):focus, fieldset[disabled] .btn.blue:not(.btn-outline).focus {
    background-color: #3598dc;
    border-color: #3598dc; }
  .btn.blue:not(.btn-outline) .badge {
    color: #3598dc;
    background-color: #FFFFFF; }

.btn.btn-outline.blue {
  border-color: #3598dc;
  color: #3598dc;
  background: none; }
  .btn.btn-outline.blue:hover, .btn.btn-outline.blue:active, .btn.btn-outline.blue:active:hover, .btn.btn-outline.blue:active:focus, .btn.btn-outline.blue:focus, .btn.btn-outline.blue.active {
    border-color: #3598dc;
    color: #FFFFFF;
    background-color: #3598dc; }

.btn.blue-stripe {
  border-left: 4px solid #3598dc !important; }

.btn.blue.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-madison:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #578ebe;
  border-color: #578ebe; }
  .btn.blue-madison:not(.btn-outline):focus, .btn.blue-madison:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #3f74a3;
    border-color: #2a4d6c; }
  .btn.blue-madison:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #3f74a3;
    border-color: #3c6f9c; }
  .btn.blue-madison:not(.btn-outline):active, .btn.blue-madison:not(.btn-outline).active, .open > .btn.blue-madison:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #3f74a3;
    border-color: #3c6f9c; }
    .btn.blue-madison:not(.btn-outline):active:hover, .btn.blue-madison:not(.btn-outline):active:focus, .btn.blue-madison:not(.btn-outline):active.focus, .btn.blue-madison:not(.btn-outline).active:hover, .btn.blue-madison:not(.btn-outline).active:focus, .btn.blue-madison:not(.btn-outline).active.focus, .open > .btn.blue-madison:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-madison:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-madison:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #356289;
      border-color: #2a4d6c; }
  .btn.blue-madison:not(.btn-outline):active, .btn.blue-madison:not(.btn-outline).active, .open > .btn.blue-madison:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-madison:not(.btn-outline).disabled:hover, .btn.blue-madison:not(.btn-outline).disabled:focus, .btn.blue-madison:not(.btn-outline).disabled.focus, .btn.blue-madison:not(.btn-outline)[disabled]:hover, .btn.blue-madison:not(.btn-outline)[disabled]:focus, .btn.blue-madison:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-madison:not(.btn-outline):hover, fieldset[disabled] .btn.blue-madison:not(.btn-outline):focus, fieldset[disabled] .btn.blue-madison:not(.btn-outline).focus {
    background-color: #578ebe;
    border-color: #578ebe; }
  .btn.blue-madison:not(.btn-outline) .badge {
    color: #578ebe;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-madison {
  border-color: #578ebe;
  color: #578ebe;
  background: none; }
  .btn.btn-outline.blue-madison:hover, .btn.btn-outline.blue-madison:active, .btn.btn-outline.blue-madison:active:hover, .btn.btn-outline.blue-madison:active:focus, .btn.btn-outline.blue-madison:focus, .btn.btn-outline.blue-madison.active {
    border-color: #578ebe;
    color: #FFFFFF;
    background-color: #578ebe; }

.btn.blue-madison-stripe {
  border-left: 4px solid #578ebe !important; }

.btn.blue-madison.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-chambray:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #2C3E50;
  border-color: #2C3E50; }
  .btn.blue-chambray:not(.btn-outline):focus, .btn.blue-chambray:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #1a252f;
    border-color: black; }
  .btn.blue-chambray:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #1a252f;
    border-color: #161f29; }
  .btn.blue-chambray:not(.btn-outline):active, .btn.blue-chambray:not(.btn-outline).active, .open > .btn.blue-chambray:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #1a252f;
    border-color: #161f29; }
    .btn.blue-chambray:not(.btn-outline):active:hover, .btn.blue-chambray:not(.btn-outline):active:focus, .btn.blue-chambray:not(.btn-outline):active.focus, .btn.blue-chambray:not(.btn-outline).active:hover, .btn.blue-chambray:not(.btn-outline).active:focus, .btn.blue-chambray:not(.btn-outline).active.focus, .open > .btn.blue-chambray:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-chambray:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-chambray:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #0d1318;
      border-color: black; }
  .btn.blue-chambray:not(.btn-outline):active, .btn.blue-chambray:not(.btn-outline).active, .open > .btn.blue-chambray:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-chambray:not(.btn-outline).disabled:hover, .btn.blue-chambray:not(.btn-outline).disabled:focus, .btn.blue-chambray:not(.btn-outline).disabled.focus, .btn.blue-chambray:not(.btn-outline)[disabled]:hover, .btn.blue-chambray:not(.btn-outline)[disabled]:focus, .btn.blue-chambray:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-chambray:not(.btn-outline):hover, fieldset[disabled] .btn.blue-chambray:not(.btn-outline):focus, fieldset[disabled] .btn.blue-chambray:not(.btn-outline).focus {
    background-color: #2C3E50;
    border-color: #2C3E50; }
  .btn.blue-chambray:not(.btn-outline) .badge {
    color: #2C3E50;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-chambray {
  border-color: #2C3E50;
  color: #2C3E50;
  background: none; }
  .btn.btn-outline.blue-chambray:hover, .btn.btn-outline.blue-chambray:active, .btn.btn-outline.blue-chambray:active:hover, .btn.btn-outline.blue-chambray:active:focus, .btn.btn-outline.blue-chambray:focus, .btn.btn-outline.blue-chambray.active {
    border-color: #2C3E50;
    color: #FFFFFF;
    background-color: #2C3E50; }

.btn.blue-chambray-stripe {
  border-left: 4px solid #2C3E50 !important; }

.btn.blue-chambray.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-ebonyclay:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #22313F;
  border-color: #22313F; }
  .btn.blue-ebonyclay:not(.btn-outline):focus, .btn.blue-ebonyclay:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #10171e;
    border-color: black; }
  .btn.blue-ebonyclay:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #10171e;
    border-color: #0d1217; }
  .btn.blue-ebonyclay:not(.btn-outline):active, .btn.blue-ebonyclay:not(.btn-outline).active, .open > .btn.blue-ebonyclay:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #10171e;
    border-color: #0d1217; }
    .btn.blue-ebonyclay:not(.btn-outline):active:hover, .btn.blue-ebonyclay:not(.btn-outline):active:focus, .btn.blue-ebonyclay:not(.btn-outline):active.focus, .btn.blue-ebonyclay:not(.btn-outline).active:hover, .btn.blue-ebonyclay:not(.btn-outline).active:focus, .btn.blue-ebonyclay:not(.btn-outline).active.focus, .open > .btn.blue-ebonyclay:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-ebonyclay:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-ebonyclay:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #040507;
      border-color: black; }
  .btn.blue-ebonyclay:not(.btn-outline):active, .btn.blue-ebonyclay:not(.btn-outline).active, .open > .btn.blue-ebonyclay:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-ebonyclay:not(.btn-outline).disabled:hover, .btn.blue-ebonyclay:not(.btn-outline).disabled:focus, .btn.blue-ebonyclay:not(.btn-outline).disabled.focus, .btn.blue-ebonyclay:not(.btn-outline)[disabled]:hover, .btn.blue-ebonyclay:not(.btn-outline)[disabled]:focus, .btn.blue-ebonyclay:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-ebonyclay:not(.btn-outline):hover, fieldset[disabled] .btn.blue-ebonyclay:not(.btn-outline):focus, fieldset[disabled] .btn.blue-ebonyclay:not(.btn-outline).focus {
    background-color: #22313F;
    border-color: #22313F; }
  .btn.blue-ebonyclay:not(.btn-outline) .badge {
    color: #22313F;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-ebonyclay {
  border-color: #22313F;
  color: #22313F;
  background: none; }
  .btn.btn-outline.blue-ebonyclay:hover, .btn.btn-outline.blue-ebonyclay:active, .btn.btn-outline.blue-ebonyclay:active:hover, .btn.btn-outline.blue-ebonyclay:active:focus, .btn.btn-outline.blue-ebonyclay:focus, .btn.btn-outline.blue-ebonyclay.active {
    border-color: #22313F;
    color: #FFFFFF;
    background-color: #22313F; }

.btn.blue-ebonyclay-stripe {
  border-left: 4px solid #22313F !important; }

.btn.blue-ebonyclay.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-hoki:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #67809F;
  border-color: #67809F; }
  .btn.blue-hoki:not(.btn-outline):focus, .btn.blue-hoki:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #526781;
    border-color: #344252; }
  .btn.blue-hoki:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #526781;
    border-color: #4e627b; }
  .btn.blue-hoki:not(.btn-outline):active, .btn.blue-hoki:not(.btn-outline).active, .open > .btn.blue-hoki:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #526781;
    border-color: #4e627b; }
    .btn.blue-hoki:not(.btn-outline):active:hover, .btn.blue-hoki:not(.btn-outline):active:focus, .btn.blue-hoki:not(.btn-outline):active.focus, .btn.blue-hoki:not(.btn-outline).active:hover, .btn.blue-hoki:not(.btn-outline).active:focus, .btn.blue-hoki:not(.btn-outline).active.focus, .open > .btn.blue-hoki:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-hoki:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-hoki:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #44566b;
      border-color: #344252; }
  .btn.blue-hoki:not(.btn-outline):active, .btn.blue-hoki:not(.btn-outline).active, .open > .btn.blue-hoki:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-hoki:not(.btn-outline).disabled:hover, .btn.blue-hoki:not(.btn-outline).disabled:focus, .btn.blue-hoki:not(.btn-outline).disabled.focus, .btn.blue-hoki:not(.btn-outline)[disabled]:hover, .btn.blue-hoki:not(.btn-outline)[disabled]:focus, .btn.blue-hoki:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-hoki:not(.btn-outline):hover, fieldset[disabled] .btn.blue-hoki:not(.btn-outline):focus, fieldset[disabled] .btn.blue-hoki:not(.btn-outline).focus {
    background-color: #67809F;
    border-color: #67809F; }
  .btn.blue-hoki:not(.btn-outline) .badge {
    color: #67809F;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-hoki {
  border-color: #67809F;
  color: #67809F;
  background: none; }
  .btn.btn-outline.blue-hoki:hover, .btn.btn-outline.blue-hoki:active, .btn.btn-outline.blue-hoki:active:hover, .btn.btn-outline.blue-hoki:active:focus, .btn.btn-outline.blue-hoki:focus, .btn.btn-outline.blue-hoki.active {
    border-color: #67809F;
    color: #FFFFFF;
    background-color: #67809F; }

.btn.blue-hoki-stripe {
  border-left: 4px solid #67809F !important; }

.btn.blue-hoki.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-steel:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #4B77BE;
  border-color: #4B77BE; }
  .btn.blue-steel:not(.btn-outline):focus, .btn.blue-steel:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #395f9d;
    border-color: #243d65; }
  .btn.blue-steel:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #395f9d;
    border-color: #365b96; }
  .btn.blue-steel:not(.btn-outline):active, .btn.blue-steel:not(.btn-outline).active, .open > .btn.blue-steel:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #395f9d;
    border-color: #365b96; }
    .btn.blue-steel:not(.btn-outline):active:hover, .btn.blue-steel:not(.btn-outline):active:focus, .btn.blue-steel:not(.btn-outline):active.focus, .btn.blue-steel:not(.btn-outline).active:hover, .btn.blue-steel:not(.btn-outline).active:focus, .btn.blue-steel:not(.btn-outline).active.focus, .open > .btn.blue-steel:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-steel:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-steel:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #2f4f83;
      border-color: #243d65; }
  .btn.blue-steel:not(.btn-outline):active, .btn.blue-steel:not(.btn-outline).active, .open > .btn.blue-steel:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-steel:not(.btn-outline).disabled:hover, .btn.blue-steel:not(.btn-outline).disabled:focus, .btn.blue-steel:not(.btn-outline).disabled.focus, .btn.blue-steel:not(.btn-outline)[disabled]:hover, .btn.blue-steel:not(.btn-outline)[disabled]:focus, .btn.blue-steel:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-steel:not(.btn-outline):hover, fieldset[disabled] .btn.blue-steel:not(.btn-outline):focus, fieldset[disabled] .btn.blue-steel:not(.btn-outline).focus {
    background-color: #4B77BE;
    border-color: #4B77BE; }
  .btn.blue-steel:not(.btn-outline) .badge {
    color: #4B77BE;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-steel {
  border-color: #4B77BE;
  color: #4B77BE;
  background: none; }
  .btn.btn-outline.blue-steel:hover, .btn.btn-outline.blue-steel:active, .btn.btn-outline.blue-steel:active:hover, .btn.btn-outline.blue-steel:active:focus, .btn.btn-outline.blue-steel:focus, .btn.btn-outline.blue-steel.active {
    border-color: #4B77BE;
    color: #FFFFFF;
    background-color: #4B77BE; }

.btn.blue-steel-stripe {
  border-left: 4px solid #4B77BE !important; }

.btn.blue-steel.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-soft:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #4c87b9;
  border-color: #4c87b9; }
  .btn.blue-soft:not(.btn-outline):focus, .btn.blue-soft:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #3b6d97;
    border-color: #264560; }
  .btn.blue-soft:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #3b6d97;
    border-color: #386890; }
  .btn.blue-soft:not(.btn-outline):active, .btn.blue-soft:not(.btn-outline).active, .open > .btn.blue-soft:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #3b6d97;
    border-color: #386890; }
    .btn.blue-soft:not(.btn-outline):active:hover, .btn.blue-soft:not(.btn-outline):active:focus, .btn.blue-soft:not(.btn-outline):active.focus, .btn.blue-soft:not(.btn-outline).active:hover, .btn.blue-soft:not(.btn-outline).active:focus, .btn.blue-soft:not(.btn-outline).active.focus, .open > .btn.blue-soft:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-soft:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-soft:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #315a7d;
      border-color: #264560; }
  .btn.blue-soft:not(.btn-outline):active, .btn.blue-soft:not(.btn-outline).active, .open > .btn.blue-soft:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-soft:not(.btn-outline).disabled:hover, .btn.blue-soft:not(.btn-outline).disabled:focus, .btn.blue-soft:not(.btn-outline).disabled.focus, .btn.blue-soft:not(.btn-outline)[disabled]:hover, .btn.blue-soft:not(.btn-outline)[disabled]:focus, .btn.blue-soft:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-soft:not(.btn-outline):hover, fieldset[disabled] .btn.blue-soft:not(.btn-outline):focus, fieldset[disabled] .btn.blue-soft:not(.btn-outline).focus {
    background-color: #4c87b9;
    border-color: #4c87b9; }
  .btn.blue-soft:not(.btn-outline) .badge {
    color: #4c87b9;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-soft {
  border-color: #4c87b9;
  color: #4c87b9;
  background: none; }
  .btn.btn-outline.blue-soft:hover, .btn.btn-outline.blue-soft:active, .btn.btn-outline.blue-soft:active:hover, .btn.btn-outline.blue-soft:active:focus, .btn.btn-outline.blue-soft:focus, .btn.btn-outline.blue-soft.active {
    border-color: #4c87b9;
    color: #FFFFFF;
    background-color: #4c87b9; }

.btn.blue-soft-stripe {
  border-left: 4px solid #4c87b9 !important; }

.btn.blue-soft.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-dark:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #5e738b;
  border-color: #5e738b; }
  .btn.blue-dark:not(.btn-outline):focus, .btn.blue-dark:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #495a6d;
    border-color: #2b343f; }
  .btn.blue-dark:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #495a6d;
    border-color: #455566; }
  .btn.blue-dark:not(.btn-outline):active, .btn.blue-dark:not(.btn-outline).active, .open > .btn.blue-dark:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #495a6d;
    border-color: #455566; }
    .btn.blue-dark:not(.btn-outline):active:hover, .btn.blue-dark:not(.btn-outline):active:focus, .btn.blue-dark:not(.btn-outline):active.focus, .btn.blue-dark:not(.btn-outline).active:hover, .btn.blue-dark:not(.btn-outline).active:focus, .btn.blue-dark:not(.btn-outline).active.focus, .open > .btn.blue-dark:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-dark:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-dark:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #3b4857;
      border-color: #2b343f; }
  .btn.blue-dark:not(.btn-outline):active, .btn.blue-dark:not(.btn-outline).active, .open > .btn.blue-dark:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-dark:not(.btn-outline).disabled:hover, .btn.blue-dark:not(.btn-outline).disabled:focus, .btn.blue-dark:not(.btn-outline).disabled.focus, .btn.blue-dark:not(.btn-outline)[disabled]:hover, .btn.blue-dark:not(.btn-outline)[disabled]:focus, .btn.blue-dark:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-dark:not(.btn-outline):hover, fieldset[disabled] .btn.blue-dark:not(.btn-outline):focus, fieldset[disabled] .btn.blue-dark:not(.btn-outline).focus {
    background-color: #5e738b;
    border-color: #5e738b; }
  .btn.blue-dark:not(.btn-outline) .badge {
    color: #5e738b;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-dark {
  border-color: #5e738b;
  color: #5e738b;
  background: none; }
  .btn.btn-outline.blue-dark:hover, .btn.btn-outline.blue-dark:active, .btn.btn-outline.blue-dark:active:hover, .btn.btn-outline.blue-dark:active:focus, .btn.btn-outline.blue-dark:focus, .btn.btn-outline.blue-dark.active {
    border-color: #5e738b;
    color: #FFFFFF;
    background-color: #5e738b; }

.btn.blue-dark-stripe {
  border-left: 4px solid #5e738b !important; }

.btn.blue-dark.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-sharp:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #5C9BD1;
  border-color: #5C9BD1; }
  .btn.blue-sharp:not(.btn-outline):focus, .btn.blue-sharp:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #3782c3;
    border-color: #265a87; }
  .btn.blue-sharp:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #3782c3;
    border-color: #357dbb; }
  .btn.blue-sharp:not(.btn-outline):active, .btn.blue-sharp:not(.btn-outline).active, .open > .btn.blue-sharp:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #3782c3;
    border-color: #357dbb; }
    .btn.blue-sharp:not(.btn-outline):active:hover, .btn.blue-sharp:not(.btn-outline):active:focus, .btn.blue-sharp:not(.btn-outline):active.focus, .btn.blue-sharp:not(.btn-outline).active:hover, .btn.blue-sharp:not(.btn-outline).active:focus, .btn.blue-sharp:not(.btn-outline).active.focus, .open > .btn.blue-sharp:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-sharp:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-sharp:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #2f70a7;
      border-color: #265a87; }
  .btn.blue-sharp:not(.btn-outline):active, .btn.blue-sharp:not(.btn-outline).active, .open > .btn.blue-sharp:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-sharp:not(.btn-outline).disabled:hover, .btn.blue-sharp:not(.btn-outline).disabled:focus, .btn.blue-sharp:not(.btn-outline).disabled.focus, .btn.blue-sharp:not(.btn-outline)[disabled]:hover, .btn.blue-sharp:not(.btn-outline)[disabled]:focus, .btn.blue-sharp:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-sharp:not(.btn-outline):hover, fieldset[disabled] .btn.blue-sharp:not(.btn-outline):focus, fieldset[disabled] .btn.blue-sharp:not(.btn-outline).focus {
    background-color: #5C9BD1;
    border-color: #5C9BD1; }
  .btn.blue-sharp:not(.btn-outline) .badge {
    color: #5C9BD1;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-sharp {
  border-color: #5C9BD1;
  color: #5C9BD1;
  background: none; }
  .btn.btn-outline.blue-sharp:hover, .btn.btn-outline.blue-sharp:active, .btn.btn-outline.blue-sharp:active:hover, .btn.btn-outline.blue-sharp:active:focus, .btn.btn-outline.blue-sharp:focus, .btn.btn-outline.blue-sharp.active {
    border-color: #5C9BD1;
    color: #FFFFFF;
    background-color: #5C9BD1; }

.btn.blue-sharp-stripe {
  border-left: 4px solid #5C9BD1 !important; }

.btn.blue-sharp.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.blue-oleo:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #94A0B2;
  border-color: #94A0B2; }
  .btn.blue-oleo:not(.btn-outline):focus, .btn.blue-oleo:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #76869d;
    border-color: #536073; }
  .btn.blue-oleo:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #76869d;
    border-color: #708098; }
  .btn.blue-oleo:not(.btn-outline):active, .btn.blue-oleo:not(.btn-outline).active, .open > .btn.blue-oleo:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #76869d;
    border-color: #708098; }
    .btn.blue-oleo:not(.btn-outline):active:hover, .btn.blue-oleo:not(.btn-outline):active:focus, .btn.blue-oleo:not(.btn-outline):active.focus, .btn.blue-oleo:not(.btn-outline).active:hover, .btn.blue-oleo:not(.btn-outline).active:focus, .btn.blue-oleo:not(.btn-outline).active.focus, .open > .btn.blue-oleo:not(.btn-outline).dropdown-toggle:hover, .open > .btn.blue-oleo:not(.btn-outline).dropdown-toggle:focus, .open > .btn.blue-oleo:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #64748b;
      border-color: #536073; }
  .btn.blue-oleo:not(.btn-outline):active, .btn.blue-oleo:not(.btn-outline).active, .open > .btn.blue-oleo:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.blue-oleo:not(.btn-outline).disabled:hover, .btn.blue-oleo:not(.btn-outline).disabled:focus, .btn.blue-oleo:not(.btn-outline).disabled.focus, .btn.blue-oleo:not(.btn-outline)[disabled]:hover, .btn.blue-oleo:not(.btn-outline)[disabled]:focus, .btn.blue-oleo:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.blue-oleo:not(.btn-outline):hover, fieldset[disabled] .btn.blue-oleo:not(.btn-outline):focus, fieldset[disabled] .btn.blue-oleo:not(.btn-outline).focus {
    background-color: #94A0B2;
    border-color: #94A0B2; }
  .btn.blue-oleo:not(.btn-outline) .badge {
    color: #94A0B2;
    background-color: #FFFFFF; }

.btn.btn-outline.blue-oleo {
  border-color: #94A0B2;
  color: #94A0B2;
  background: none; }
  .btn.btn-outline.blue-oleo:hover, .btn.btn-outline.blue-oleo:active, .btn.btn-outline.blue-oleo:active:hover, .btn.btn-outline.blue-oleo:active:focus, .btn.btn-outline.blue-oleo:focus, .btn.btn-outline.blue-oleo.active {
    border-color: #94A0B2;
    color: #FFFFFF;
    background-color: #94A0B2; }

.btn.blue-oleo-stripe {
  border-left: 4px solid #94A0B2 !important; }

.btn.blue-oleo.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #32c5d2;
  border-color: #32c5d2; }
  .btn.green:not(.btn-outline):focus, .btn.green:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #26a1ab;
    border-color: #18666d; }
  .btn.green:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #26a1ab;
    border-color: #2499a3; }
  .btn.green:not(.btn-outline):active, .btn.green:not(.btn-outline).active, .open > .btn.green:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #26a1ab;
    border-color: #2499a3; }
    .btn.green:not(.btn-outline):active:hover, .btn.green:not(.btn-outline):active:focus, .btn.green:not(.btn-outline):active.focus, .btn.green:not(.btn-outline).active:hover, .btn.green:not(.btn-outline).active:focus, .btn.green:not(.btn-outline).active.focus, .open > .btn.green:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #1f858e;
      border-color: #18666d; }
  .btn.green:not(.btn-outline):active, .btn.green:not(.btn-outline).active, .open > .btn.green:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green:not(.btn-outline).disabled:hover, .btn.green:not(.btn-outline).disabled:focus, .btn.green:not(.btn-outline).disabled.focus, .btn.green:not(.btn-outline)[disabled]:hover, .btn.green:not(.btn-outline)[disabled]:focus, .btn.green:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green:not(.btn-outline):hover, fieldset[disabled] .btn.green:not(.btn-outline):focus, fieldset[disabled] .btn.green:not(.btn-outline).focus {
    background-color: #32c5d2;
    border-color: #32c5d2; }
  .btn.green:not(.btn-outline) .badge {
    color: #32c5d2;
    background-color: #FFFFFF; }

.btn.btn-outline.green {
  border-color: #32c5d2;
  color: #32c5d2;
  background: none; }
  .btn.btn-outline.green:hover, .btn.btn-outline.green:active, .btn.btn-outline.green:active:hover, .btn.btn-outline.green:active:focus, .btn.btn-outline.green:focus, .btn.btn-outline.green.active {
    border-color: #32c5d2;
    color: #FFFFFF;
    background-color: #32c5d2; }

.btn.green-stripe {
  border-left: 4px solid #32c5d2 !important; }

.btn.green.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-meadow:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #1BBC9B;
  border-color: #1BBC9B; }
  .btn.green-meadow:not(.btn-outline):focus, .btn.green-meadow:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #158f76;
    border-color: #0b4d3f; }
  .btn.green-meadow:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #158f76;
    border-color: #13866f; }
  .btn.green-meadow:not(.btn-outline):active, .btn.green-meadow:not(.btn-outline).active, .open > .btn.green-meadow:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #158f76;
    border-color: #13866f; }
    .btn.green-meadow:not(.btn-outline):active:hover, .btn.green-meadow:not(.btn-outline):active:focus, .btn.green-meadow:not(.btn-outline):active.focus, .btn.green-meadow:not(.btn-outline).active:hover, .btn.green-meadow:not(.btn-outline).active:focus, .btn.green-meadow:not(.btn-outline).active.focus, .open > .btn.green-meadow:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-meadow:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-meadow:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #10705c;
      border-color: #0b4d3f; }
  .btn.green-meadow:not(.btn-outline):active, .btn.green-meadow:not(.btn-outline).active, .open > .btn.green-meadow:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-meadow:not(.btn-outline).disabled:hover, .btn.green-meadow:not(.btn-outline).disabled:focus, .btn.green-meadow:not(.btn-outline).disabled.focus, .btn.green-meadow:not(.btn-outline)[disabled]:hover, .btn.green-meadow:not(.btn-outline)[disabled]:focus, .btn.green-meadow:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-meadow:not(.btn-outline):hover, fieldset[disabled] .btn.green-meadow:not(.btn-outline):focus, fieldset[disabled] .btn.green-meadow:not(.btn-outline).focus {
    background-color: #1BBC9B;
    border-color: #1BBC9B; }
  .btn.green-meadow:not(.btn-outline) .badge {
    color: #1BBC9B;
    background-color: #FFFFFF; }

.btn.btn-outline.green-meadow {
  border-color: #1BBC9B;
  color: #1BBC9B;
  background: none; }
  .btn.btn-outline.green-meadow:hover, .btn.btn-outline.green-meadow:active, .btn.btn-outline.green-meadow:active:hover, .btn.btn-outline.green-meadow:active:focus, .btn.btn-outline.green-meadow:focus, .btn.btn-outline.green-meadow.active {
    border-color: #1BBC9B;
    color: #FFFFFF;
    background-color: #1BBC9B; }

.btn.green-meadow-stripe {
  border-left: 4px solid #1BBC9B !important; }

.btn.green-meadow.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-seagreen:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #1BA39C;
  border-color: #1BA39C; }
  .btn.green-seagreen:not(.btn-outline):focus, .btn.green-seagreen:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #147772;
    border-color: #093633; }
  .btn.green-seagreen:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #147772;
    border-color: #126e6a; }
  .btn.green-seagreen:not(.btn-outline):active, .btn.green-seagreen:not(.btn-outline).active, .open > .btn.green-seagreen:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #147772;
    border-color: #126e6a; }
    .btn.green-seagreen:not(.btn-outline):active:hover, .btn.green-seagreen:not(.btn-outline):active:focus, .btn.green-seagreen:not(.btn-outline):active.focus, .btn.green-seagreen:not(.btn-outline).active:hover, .btn.green-seagreen:not(.btn-outline).active:focus, .btn.green-seagreen:not(.btn-outline).active.focus, .open > .btn.green-seagreen:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-seagreen:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-seagreen:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #0f5955;
      border-color: #093633; }
  .btn.green-seagreen:not(.btn-outline):active, .btn.green-seagreen:not(.btn-outline).active, .open > .btn.green-seagreen:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-seagreen:not(.btn-outline).disabled:hover, .btn.green-seagreen:not(.btn-outline).disabled:focus, .btn.green-seagreen:not(.btn-outline).disabled.focus, .btn.green-seagreen:not(.btn-outline)[disabled]:hover, .btn.green-seagreen:not(.btn-outline)[disabled]:focus, .btn.green-seagreen:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-seagreen:not(.btn-outline):hover, fieldset[disabled] .btn.green-seagreen:not(.btn-outline):focus, fieldset[disabled] .btn.green-seagreen:not(.btn-outline).focus {
    background-color: #1BA39C;
    border-color: #1BA39C; }
  .btn.green-seagreen:not(.btn-outline) .badge {
    color: #1BA39C;
    background-color: #FFFFFF; }

.btn.btn-outline.green-seagreen {
  border-color: #1BA39C;
  color: #1BA39C;
  background: none; }
  .btn.btn-outline.green-seagreen:hover, .btn.btn-outline.green-seagreen:active, .btn.btn-outline.green-seagreen:active:hover, .btn.btn-outline.green-seagreen:active:focus, .btn.btn-outline.green-seagreen:focus, .btn.btn-outline.green-seagreen.active {
    border-color: #1BA39C;
    color: #FFFFFF;
    background-color: #1BA39C; }

.btn.green-seagreen-stripe {
  border-left: 4px solid #1BA39C !important; }

.btn.green-seagreen.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-turquoise:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #36D7B7;
  border-color: #36D7B7; }
  .btn.green-turquoise:not(.btn-outline):focus, .btn.green-turquoise:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #24b699;
    border-color: #177663; }
  .btn.green-turquoise:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #24b699;
    border-color: #22ad92; }
  .btn.green-turquoise:not(.btn-outline):active, .btn.green-turquoise:not(.btn-outline).active, .open > .btn.green-turquoise:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #24b699;
    border-color: #22ad92; }
    .btn.green-turquoise:not(.btn-outline):active:hover, .btn.green-turquoise:not(.btn-outline):active:focus, .btn.green-turquoise:not(.btn-outline):active.focus, .btn.green-turquoise:not(.btn-outline).active:hover, .btn.green-turquoise:not(.btn-outline).active:focus, .btn.green-turquoise:not(.btn-outline).active.focus, .open > .btn.green-turquoise:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-turquoise:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-turquoise:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #1e9880;
      border-color: #177663; }
  .btn.green-turquoise:not(.btn-outline):active, .btn.green-turquoise:not(.btn-outline).active, .open > .btn.green-turquoise:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-turquoise:not(.btn-outline).disabled:hover, .btn.green-turquoise:not(.btn-outline).disabled:focus, .btn.green-turquoise:not(.btn-outline).disabled.focus, .btn.green-turquoise:not(.btn-outline)[disabled]:hover, .btn.green-turquoise:not(.btn-outline)[disabled]:focus, .btn.green-turquoise:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-turquoise:not(.btn-outline):hover, fieldset[disabled] .btn.green-turquoise:not(.btn-outline):focus, fieldset[disabled] .btn.green-turquoise:not(.btn-outline).focus {
    background-color: #36D7B7;
    border-color: #36D7B7; }
  .btn.green-turquoise:not(.btn-outline) .badge {
    color: #36D7B7;
    background-color: #FFFFFF; }

.btn.btn-outline.green-turquoise {
  border-color: #36D7B7;
  color: #36D7B7;
  background: none; }
  .btn.btn-outline.green-turquoise:hover, .btn.btn-outline.green-turquoise:active, .btn.btn-outline.green-turquoise:active:hover, .btn.btn-outline.green-turquoise:active:focus, .btn.btn-outline.green-turquoise:focus, .btn.btn-outline.green-turquoise.active {
    border-color: #36D7B7;
    color: #FFFFFF;
    background-color: #36D7B7; }

.btn.green-turquoise-stripe {
  border-left: 4px solid #36D7B7 !important; }

.btn.green-turquoise.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-haze:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #44b6ae;
  border-color: #44b6ae; }
  .btn.green-haze:not(.btn-outline):focus, .btn.green-haze:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #36918b;
    border-color: #215955; }
  .btn.green-haze:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #36918b;
    border-color: #338983; }
  .btn.green-haze:not(.btn-outline):active, .btn.green-haze:not(.btn-outline).active, .open > .btn.green-haze:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #36918b;
    border-color: #338983; }
    .btn.green-haze:not(.btn-outline):active:hover, .btn.green-haze:not(.btn-outline):active:focus, .btn.green-haze:not(.btn-outline):active.focus, .btn.green-haze:not(.btn-outline).active:hover, .btn.green-haze:not(.btn-outline).active:focus, .btn.green-haze:not(.btn-outline).active.focus, .open > .btn.green-haze:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-haze:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-haze:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #2c7772;
      border-color: #215955; }
  .btn.green-haze:not(.btn-outline):active, .btn.green-haze:not(.btn-outline).active, .open > .btn.green-haze:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-haze:not(.btn-outline).disabled:hover, .btn.green-haze:not(.btn-outline).disabled:focus, .btn.green-haze:not(.btn-outline).disabled.focus, .btn.green-haze:not(.btn-outline)[disabled]:hover, .btn.green-haze:not(.btn-outline)[disabled]:focus, .btn.green-haze:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-haze:not(.btn-outline):hover, fieldset[disabled] .btn.green-haze:not(.btn-outline):focus, fieldset[disabled] .btn.green-haze:not(.btn-outline).focus {
    background-color: #44b6ae;
    border-color: #44b6ae; }
  .btn.green-haze:not(.btn-outline) .badge {
    color: #44b6ae;
    background-color: #FFFFFF; }

.btn.btn-outline.green-haze {
  border-color: #44b6ae;
  color: #44b6ae;
  background: none; }
  .btn.btn-outline.green-haze:hover, .btn.btn-outline.green-haze:active, .btn.btn-outline.green-haze:active:hover, .btn.btn-outline.green-haze:active:focus, .btn.btn-outline.green-haze:focus, .btn.btn-outline.green-haze.active {
    border-color: #44b6ae;
    color: #FFFFFF;
    background-color: #44b6ae; }

.btn.green-haze-stripe {
  border-left: 4px solid #44b6ae !important; }

.btn.green-haze.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-jungle:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #26C281;
  border-color: #26C281; }
  .btn.green-jungle:not(.btn-outline):focus, .btn.green-jungle:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #1e9765;
    border-color: #11573a; }
  .btn.green-jungle:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #1e9765;
    border-color: #1c8f5f; }
  .btn.green-jungle:not(.btn-outline):active, .btn.green-jungle:not(.btn-outline).active, .open > .btn.green-jungle:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #1e9765;
    border-color: #1c8f5f; }
    .btn.green-jungle:not(.btn-outline):active:hover, .btn.green-jungle:not(.btn-outline):active:focus, .btn.green-jungle:not(.btn-outline):active.focus, .btn.green-jungle:not(.btn-outline).active:hover, .btn.green-jungle:not(.btn-outline).active:focus, .btn.green-jungle:not(.btn-outline).active.focus, .open > .btn.green-jungle:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-jungle:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-jungle:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #187a51;
      border-color: #11573a; }
  .btn.green-jungle:not(.btn-outline):active, .btn.green-jungle:not(.btn-outline).active, .open > .btn.green-jungle:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-jungle:not(.btn-outline).disabled:hover, .btn.green-jungle:not(.btn-outline).disabled:focus, .btn.green-jungle:not(.btn-outline).disabled.focus, .btn.green-jungle:not(.btn-outline)[disabled]:hover, .btn.green-jungle:not(.btn-outline)[disabled]:focus, .btn.green-jungle:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-jungle:not(.btn-outline):hover, fieldset[disabled] .btn.green-jungle:not(.btn-outline):focus, fieldset[disabled] .btn.green-jungle:not(.btn-outline).focus {
    background-color: #26C281;
    border-color: #26C281; }
  .btn.green-jungle:not(.btn-outline) .badge {
    color: #26C281;
    background-color: #FFFFFF; }

.btn.btn-outline.green-jungle {
  border-color: #26C281;
  color: #26C281;
  background: none; }
  .btn.btn-outline.green-jungle:hover, .btn.btn-outline.green-jungle:active, .btn.btn-outline.green-jungle:active:hover, .btn.btn-outline.green-jungle:active:focus, .btn.btn-outline.green-jungle:focus, .btn.btn-outline.green-jungle.active {
    border-color: #26C281;
    color: #FFFFFF;
    background-color: #26C281; }

.btn.green-jungle-stripe {
  border-left: 4px solid #26C281 !important; }

.btn.green-jungle.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-soft:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #3faba4;
  border-color: #3faba4; }
  .btn.green-soft:not(.btn-outline):focus, .btn.green-soft:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #318680;
    border-color: #1d4e4b; }
  .btn.green-soft:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #318680;
    border-color: #2f7e79; }
  .btn.green-soft:not(.btn-outline):active, .btn.green-soft:not(.btn-outline).active, .open > .btn.green-soft:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #318680;
    border-color: #2f7e79; }
    .btn.green-soft:not(.btn-outline):active:hover, .btn.green-soft:not(.btn-outline):active:focus, .btn.green-soft:not(.btn-outline):active.focus, .btn.green-soft:not(.btn-outline).active:hover, .btn.green-soft:not(.btn-outline).active:focus, .btn.green-soft:not(.btn-outline).active.focus, .open > .btn.green-soft:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-soft:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-soft:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #286c67;
      border-color: #1d4e4b; }
  .btn.green-soft:not(.btn-outline):active, .btn.green-soft:not(.btn-outline).active, .open > .btn.green-soft:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-soft:not(.btn-outline).disabled:hover, .btn.green-soft:not(.btn-outline).disabled:focus, .btn.green-soft:not(.btn-outline).disabled.focus, .btn.green-soft:not(.btn-outline)[disabled]:hover, .btn.green-soft:not(.btn-outline)[disabled]:focus, .btn.green-soft:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-soft:not(.btn-outline):hover, fieldset[disabled] .btn.green-soft:not(.btn-outline):focus, fieldset[disabled] .btn.green-soft:not(.btn-outline).focus {
    background-color: #3faba4;
    border-color: #3faba4; }
  .btn.green-soft:not(.btn-outline) .badge {
    color: #3faba4;
    background-color: #FFFFFF; }

.btn.btn-outline.green-soft {
  border-color: #3faba4;
  color: #3faba4;
  background: none; }
  .btn.btn-outline.green-soft:hover, .btn.btn-outline.green-soft:active, .btn.btn-outline.green-soft:active:hover, .btn.btn-outline.green-soft:active:focus, .btn.btn-outline.green-soft:focus, .btn.btn-outline.green-soft.active {
    border-color: #3faba4;
    color: #FFFFFF;
    background-color: #3faba4; }

.btn.green-soft-stripe {
  border-left: 4px solid #3faba4 !important; }

.btn.green-soft.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-dark:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #4DB3A2;
  border-color: #4DB3A2; }
  .btn.green-dark:not(.btn-outline):focus, .btn.green-dark:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #3d9082;
    border-color: #265a51; }
  .btn.green-dark:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #3d9082;
    border-color: #3a897b; }
  .btn.green-dark:not(.btn-outline):active, .btn.green-dark:not(.btn-outline).active, .open > .btn.green-dark:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #3d9082;
    border-color: #3a897b; }
    .btn.green-dark:not(.btn-outline):active:hover, .btn.green-dark:not(.btn-outline):active:focus, .btn.green-dark:not(.btn-outline):active.focus, .btn.green-dark:not(.btn-outline).active:hover, .btn.green-dark:not(.btn-outline).active:focus, .btn.green-dark:not(.btn-outline).active.focus, .open > .btn.green-dark:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-dark:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-dark:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #33776b;
      border-color: #265a51; }
  .btn.green-dark:not(.btn-outline):active, .btn.green-dark:not(.btn-outline).active, .open > .btn.green-dark:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-dark:not(.btn-outline).disabled:hover, .btn.green-dark:not(.btn-outline).disabled:focus, .btn.green-dark:not(.btn-outline).disabled.focus, .btn.green-dark:not(.btn-outline)[disabled]:hover, .btn.green-dark:not(.btn-outline)[disabled]:focus, .btn.green-dark:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-dark:not(.btn-outline):hover, fieldset[disabled] .btn.green-dark:not(.btn-outline):focus, fieldset[disabled] .btn.green-dark:not(.btn-outline).focus {
    background-color: #4DB3A2;
    border-color: #4DB3A2; }
  .btn.green-dark:not(.btn-outline) .badge {
    color: #4DB3A2;
    background-color: #FFFFFF; }

.btn.btn-outline.green-dark {
  border-color: #4DB3A2;
  color: #4DB3A2;
  background: none; }
  .btn.btn-outline.green-dark:hover, .btn.btn-outline.green-dark:active, .btn.btn-outline.green-dark:active:hover, .btn.btn-outline.green-dark:active:focus, .btn.btn-outline.green-dark:focus, .btn.btn-outline.green-dark.active {
    border-color: #4DB3A2;
    color: #FFFFFF;
    background-color: #4DB3A2; }

.btn.green-dark-stripe {
  border-left: 4px solid #4DB3A2 !important; }

.btn.green-dark.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-sharp:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #2ab4c0;
  border-color: #2ab4c0; }
  .btn.green-sharp:not(.btn-outline):focus, .btn.green-sharp:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #218d96;
    border-color: #135257; }
  .btn.green-sharp:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #218d96;
    border-color: #1f858e; }
  .btn.green-sharp:not(.btn-outline):active, .btn.green-sharp:not(.btn-outline).active, .open > .btn.green-sharp:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #218d96;
    border-color: #1f858e; }
    .btn.green-sharp:not(.btn-outline):active:hover, .btn.green-sharp:not(.btn-outline):active:focus, .btn.green-sharp:not(.btn-outline):active.focus, .btn.green-sharp:not(.btn-outline).active:hover, .btn.green-sharp:not(.btn-outline).active:focus, .btn.green-sharp:not(.btn-outline).active.focus, .open > .btn.green-sharp:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-sharp:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-sharp:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #1a7179;
      border-color: #135257; }
  .btn.green-sharp:not(.btn-outline):active, .btn.green-sharp:not(.btn-outline).active, .open > .btn.green-sharp:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-sharp:not(.btn-outline).disabled:hover, .btn.green-sharp:not(.btn-outline).disabled:focus, .btn.green-sharp:not(.btn-outline).disabled.focus, .btn.green-sharp:not(.btn-outline)[disabled]:hover, .btn.green-sharp:not(.btn-outline)[disabled]:focus, .btn.green-sharp:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-sharp:not(.btn-outline):hover, fieldset[disabled] .btn.green-sharp:not(.btn-outline):focus, fieldset[disabled] .btn.green-sharp:not(.btn-outline).focus {
    background-color: #2ab4c0;
    border-color: #2ab4c0; }
  .btn.green-sharp:not(.btn-outline) .badge {
    color: #2ab4c0;
    background-color: #FFFFFF; }

.btn.btn-outline.green-sharp {
  border-color: #2ab4c0;
  color: #2ab4c0;
  background: none; }
  .btn.btn-outline.green-sharp:hover, .btn.btn-outline.green-sharp:active, .btn.btn-outline.green-sharp:active:hover, .btn.btn-outline.green-sharp:active:focus, .btn.btn-outline.green-sharp:focus, .btn.btn-outline.green-sharp.active {
    border-color: #2ab4c0;
    color: #FFFFFF;
    background-color: #2ab4c0; }

.btn.green-sharp-stripe {
  border-left: 4px solid #2ab4c0 !important; }

.btn.green-sharp.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.green-steel:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #29b4b6;
  border-color: #29b4b6; }
  .btn.green-steel:not(.btn-outline):focus, .btn.green-steel:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #208b8c;
    border-color: #124d4e; }
  .btn.green-steel:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #208b8c;
    border-color: #1e8384; }
  .btn.green-steel:not(.btn-outline):active, .btn.green-steel:not(.btn-outline).active, .open > .btn.green-steel:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #208b8c;
    border-color: #1e8384; }
    .btn.green-steel:not(.btn-outline):active:hover, .btn.green-steel:not(.btn-outline):active:focus, .btn.green-steel:not(.btn-outline):active.focus, .btn.green-steel:not(.btn-outline).active:hover, .btn.green-steel:not(.btn-outline).active:focus, .btn.green-steel:not(.btn-outline).active.focus, .open > .btn.green-steel:not(.btn-outline).dropdown-toggle:hover, .open > .btn.green-steel:not(.btn-outline).dropdown-toggle:focus, .open > .btn.green-steel:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #196e6f;
      border-color: #124d4e; }
  .btn.green-steel:not(.btn-outline):active, .btn.green-steel:not(.btn-outline).active, .open > .btn.green-steel:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.green-steel:not(.btn-outline).disabled:hover, .btn.green-steel:not(.btn-outline).disabled:focus, .btn.green-steel:not(.btn-outline).disabled.focus, .btn.green-steel:not(.btn-outline)[disabled]:hover, .btn.green-steel:not(.btn-outline)[disabled]:focus, .btn.green-steel:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.green-steel:not(.btn-outline):hover, fieldset[disabled] .btn.green-steel:not(.btn-outline):focus, fieldset[disabled] .btn.green-steel:not(.btn-outline).focus {
    background-color: #29b4b6;
    border-color: #29b4b6; }
  .btn.green-steel:not(.btn-outline) .badge {
    color: #29b4b6;
    background-color: #FFFFFF; }

.btn.btn-outline.green-steel {
  border-color: #29b4b6;
  color: #29b4b6;
  background: none; }
  .btn.btn-outline.green-steel:hover, .btn.btn-outline.green-steel:active, .btn.btn-outline.green-steel:active:hover, .btn.btn-outline.green-steel:active:focus, .btn.btn-outline.green-steel:focus, .btn.btn-outline.green-steel.active {
    border-color: #29b4b6;
    color: #FFFFFF;
    background-color: #29b4b6; }

.btn.green-steel-stripe {
  border-left: 4px solid #29b4b6 !important; }

.btn.green-steel.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey:not(.btn-outline) {
  color: #333333;
  background-color: #E5E5E5;
  border-color: #E5E5E5; }
  .btn.grey:not(.btn-outline):focus, .btn.grey:not(.btn-outline).focus {
    color: #333333;
    background-color: #cccccc;
    border-color: #a5a5a5; }
  .btn.grey:not(.btn-outline):hover {
    color: #333333;
    background-color: #cccccc;
    border-color: #c6c6c6; }
  .btn.grey:not(.btn-outline):active, .btn.grey:not(.btn-outline).active, .open > .btn.grey:not(.btn-outline).dropdown-toggle {
    color: #333333;
    background-color: #cccccc;
    border-color: #c6c6c6; }
    .btn.grey:not(.btn-outline):active:hover, .btn.grey:not(.btn-outline):active:focus, .btn.grey:not(.btn-outline):active.focus, .btn.grey:not(.btn-outline).active:hover, .btn.grey:not(.btn-outline).active:focus, .btn.grey:not(.btn-outline).active.focus, .open > .btn.grey:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey:not(.btn-outline).dropdown-toggle.focus {
      color: #333333;
      background-color: #bababa;
      border-color: #a5a5a5; }
  .btn.grey:not(.btn-outline):active, .btn.grey:not(.btn-outline).active, .open > .btn.grey:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey:not(.btn-outline).disabled:hover, .btn.grey:not(.btn-outline).disabled:focus, .btn.grey:not(.btn-outline).disabled.focus, .btn.grey:not(.btn-outline)[disabled]:hover, .btn.grey:not(.btn-outline)[disabled]:focus, .btn.grey:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey:not(.btn-outline):hover, fieldset[disabled] .btn.grey:not(.btn-outline):focus, fieldset[disabled] .btn.grey:not(.btn-outline).focus {
    background-color: #E5E5E5;
    border-color: #E5E5E5; }
  .btn.grey:not(.btn-outline) .badge {
    color: #E5E5E5;
    background-color: #333333; }

.btn.btn-outline.grey {
  border-color: #E5E5E5;
  color: #E5E5E5;
  background: none; }
  .btn.btn-outline.grey:hover, .btn.btn-outline.grey:active, .btn.btn-outline.grey:active:hover, .btn.btn-outline.grey:active:focus, .btn.btn-outline.grey:focus, .btn.btn-outline.grey.active {
    border-color: #E5E5E5;
    color: #333333;
    background-color: #E5E5E5; }

.btn.grey-stripe {
  border-left: 4px solid #E5E5E5 !important; }

.btn.grey.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-steel:not(.btn-outline) {
  color: #80898e;
  background-color: #e9edef;
  border-color: #e9edef; }
  .btn.grey-steel:not(.btn-outline):focus, .btn.grey-steel:not(.btn-outline).focus {
    color: #80898e;
    background-color: #cbd5da;
    border-color: #9fb1b9; }
  .btn.grey-steel:not(.btn-outline):hover {
    color: #80898e;
    background-color: #cbd5da;
    border-color: #c6d0d5; }
  .btn.grey-steel:not(.btn-outline):active, .btn.grey-steel:not(.btn-outline).active, .open > .btn.grey-steel:not(.btn-outline).dropdown-toggle {
    color: #80898e;
    background-color: #cbd5da;
    border-color: #c6d0d5; }
    .btn.grey-steel:not(.btn-outline):active:hover, .btn.grey-steel:not(.btn-outline):active:focus, .btn.grey-steel:not(.btn-outline):active.focus, .btn.grey-steel:not(.btn-outline).active:hover, .btn.grey-steel:not(.btn-outline).active:focus, .btn.grey-steel:not(.btn-outline).active.focus, .open > .btn.grey-steel:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-steel:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-steel:not(.btn-outline).dropdown-toggle.focus {
      color: #80898e;
      background-color: #b7c4ca;
      border-color: #9fb1b9; }
  .btn.grey-steel:not(.btn-outline):active, .btn.grey-steel:not(.btn-outline).active, .open > .btn.grey-steel:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-steel:not(.btn-outline).disabled:hover, .btn.grey-steel:not(.btn-outline).disabled:focus, .btn.grey-steel:not(.btn-outline).disabled.focus, .btn.grey-steel:not(.btn-outline)[disabled]:hover, .btn.grey-steel:not(.btn-outline)[disabled]:focus, .btn.grey-steel:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-steel:not(.btn-outline):hover, fieldset[disabled] .btn.grey-steel:not(.btn-outline):focus, fieldset[disabled] .btn.grey-steel:not(.btn-outline).focus {
    background-color: #e9edef;
    border-color: #e9edef; }
  .btn.grey-steel:not(.btn-outline) .badge {
    color: #e9edef;
    background-color: #80898e; }

.btn.btn-outline.grey-steel {
  border-color: #e9edef;
  color: #e9edef;
  background: none; }
  .btn.btn-outline.grey-steel:hover, .btn.btn-outline.grey-steel:active, .btn.btn-outline.grey-steel:active:hover, .btn.btn-outline.grey-steel:active:focus, .btn.btn-outline.grey-steel:focus, .btn.btn-outline.grey-steel.active {
    border-color: #e9edef;
    color: #80898e;
    background-color: #e9edef; }

.btn.grey-steel-stripe {
  border-left: 4px solid #e9edef !important; }

.btn.grey-steel.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-cararra:not(.btn-outline) {
  color: #333333;
  background-color: #fafafa;
  border-color: #fafafa; }
  .btn.grey-cararra:not(.btn-outline):focus, .btn.grey-cararra:not(.btn-outline).focus {
    color: #333333;
    background-color: #e1e1e1;
    border-color: #bababa; }
  .btn.grey-cararra:not(.btn-outline):hover {
    color: #333333;
    background-color: #e1e1e1;
    border-color: #dbdbdb; }
  .btn.grey-cararra:not(.btn-outline):active, .btn.grey-cararra:not(.btn-outline).active, .open > .btn.grey-cararra:not(.btn-outline).dropdown-toggle {
    color: #333333;
    background-color: #e1e1e1;
    border-color: #dbdbdb; }
    .btn.grey-cararra:not(.btn-outline):active:hover, .btn.grey-cararra:not(.btn-outline):active:focus, .btn.grey-cararra:not(.btn-outline):active.focus, .btn.grey-cararra:not(.btn-outline).active:hover, .btn.grey-cararra:not(.btn-outline).active:focus, .btn.grey-cararra:not(.btn-outline).active.focus, .open > .btn.grey-cararra:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-cararra:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-cararra:not(.btn-outline).dropdown-toggle.focus {
      color: #333333;
      background-color: #cfcfcf;
      border-color: #bababa; }
  .btn.grey-cararra:not(.btn-outline):active, .btn.grey-cararra:not(.btn-outline).active, .open > .btn.grey-cararra:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-cararra:not(.btn-outline).disabled:hover, .btn.grey-cararra:not(.btn-outline).disabled:focus, .btn.grey-cararra:not(.btn-outline).disabled.focus, .btn.grey-cararra:not(.btn-outline)[disabled]:hover, .btn.grey-cararra:not(.btn-outline)[disabled]:focus, .btn.grey-cararra:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-cararra:not(.btn-outline):hover, fieldset[disabled] .btn.grey-cararra:not(.btn-outline):focus, fieldset[disabled] .btn.grey-cararra:not(.btn-outline).focus {
    background-color: #fafafa;
    border-color: #fafafa; }
  .btn.grey-cararra:not(.btn-outline) .badge {
    color: #fafafa;
    background-color: #333333; }

.btn.btn-outline.grey-cararra {
  border-color: #fafafa;
  color: #fafafa;
  background: none; }
  .btn.btn-outline.grey-cararra:hover, .btn.btn-outline.grey-cararra:active, .btn.btn-outline.grey-cararra:active:hover, .btn.btn-outline.grey-cararra:active:focus, .btn.btn-outline.grey-cararra:focus, .btn.btn-outline.grey-cararra.active {
    border-color: #fafafa;
    color: #333333;
    background-color: #fafafa; }

.btn.grey-cararra-stripe {
  border-left: 4px solid #fafafa !important; }

.btn.grey-cararra.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-gallery:not(.btn-outline) {
  color: #ffffff;
  background-color: #555555;
  border-color: #555555; }
  .btn.grey-gallery:not(.btn-outline):focus, .btn.grey-gallery:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #3c3c3c;
    border-color: #151515; }
  .btn.grey-gallery:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #3c3c3c;
    border-color: #363636; }
  .btn.grey-gallery:not(.btn-outline):active, .btn.grey-gallery:not(.btn-outline).active, .open > .btn.grey-gallery:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #3c3c3c;
    border-color: #363636; }
    .btn.grey-gallery:not(.btn-outline):active:hover, .btn.grey-gallery:not(.btn-outline):active:focus, .btn.grey-gallery:not(.btn-outline):active.focus, .btn.grey-gallery:not(.btn-outline).active:hover, .btn.grey-gallery:not(.btn-outline).active:focus, .btn.grey-gallery:not(.btn-outline).active.focus, .open > .btn.grey-gallery:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-gallery:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-gallery:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #2a2a2a;
      border-color: #151515; }
  .btn.grey-gallery:not(.btn-outline):active, .btn.grey-gallery:not(.btn-outline).active, .open > .btn.grey-gallery:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-gallery:not(.btn-outline).disabled:hover, .btn.grey-gallery:not(.btn-outline).disabled:focus, .btn.grey-gallery:not(.btn-outline).disabled.focus, .btn.grey-gallery:not(.btn-outline)[disabled]:hover, .btn.grey-gallery:not(.btn-outline)[disabled]:focus, .btn.grey-gallery:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-gallery:not(.btn-outline):hover, fieldset[disabled] .btn.grey-gallery:not(.btn-outline):focus, fieldset[disabled] .btn.grey-gallery:not(.btn-outline).focus {
    background-color: #555555;
    border-color: #555555; }
  .btn.grey-gallery:not(.btn-outline) .badge {
    color: #555555;
    background-color: #ffffff; }

.btn.btn-outline.grey-gallery {
  border-color: #555555;
  color: #555555;
  background: none; }
  .btn.btn-outline.grey-gallery:hover, .btn.btn-outline.grey-gallery:active, .btn.btn-outline.grey-gallery:active:hover, .btn.btn-outline.grey-gallery:active:focus, .btn.btn-outline.grey-gallery:focus, .btn.btn-outline.grey-gallery.active {
    border-color: #555555;
    color: #ffffff;
    background-color: #555555; }

.btn.grey-gallery-stripe {
  border-left: 4px solid #555555 !important; }

.btn.grey-gallery.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-cascade:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #95A5A6;
  border-color: #95A5A6; }
  .btn.grey-cascade:not(.btn-outline):focus, .btn.grey-cascade:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #798d8f;
    border-color: #566566; }
  .btn.grey-cascade:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #798d8f;
    border-color: #74898a; }
  .btn.grey-cascade:not(.btn-outline):active, .btn.grey-cascade:not(.btn-outline).active, .open > .btn.grey-cascade:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #798d8f;
    border-color: #74898a; }
    .btn.grey-cascade:not(.btn-outline):active:hover, .btn.grey-cascade:not(.btn-outline):active:focus, .btn.grey-cascade:not(.btn-outline):active.focus, .btn.grey-cascade:not(.btn-outline).active:hover, .btn.grey-cascade:not(.btn-outline).active:focus, .btn.grey-cascade:not(.btn-outline).active.focus, .open > .btn.grey-cascade:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-cascade:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-cascade:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #687b7c;
      border-color: #566566; }
  .btn.grey-cascade:not(.btn-outline):active, .btn.grey-cascade:not(.btn-outline).active, .open > .btn.grey-cascade:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-cascade:not(.btn-outline).disabled:hover, .btn.grey-cascade:not(.btn-outline).disabled:focus, .btn.grey-cascade:not(.btn-outline).disabled.focus, .btn.grey-cascade:not(.btn-outline)[disabled]:hover, .btn.grey-cascade:not(.btn-outline)[disabled]:focus, .btn.grey-cascade:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-cascade:not(.btn-outline):hover, fieldset[disabled] .btn.grey-cascade:not(.btn-outline):focus, fieldset[disabled] .btn.grey-cascade:not(.btn-outline).focus {
    background-color: #95A5A6;
    border-color: #95A5A6; }
  .btn.grey-cascade:not(.btn-outline) .badge {
    color: #95A5A6;
    background-color: #FFFFFF; }

.btn.btn-outline.grey-cascade {
  border-color: #95A5A6;
  color: #95A5A6;
  background: none; }
  .btn.btn-outline.grey-cascade:hover, .btn.btn-outline.grey-cascade:active, .btn.btn-outline.grey-cascade:active:hover, .btn.btn-outline.grey-cascade:active:focus, .btn.btn-outline.grey-cascade:focus, .btn.btn-outline.grey-cascade.active {
    border-color: #95A5A6;
    color: #FFFFFF;
    background-color: #95A5A6; }

.btn.grey-cascade-stripe {
  border-left: 4px solid #95A5A6 !important; }

.btn.grey-cascade.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-silver:not(.btn-outline) {
  color: #FAFCFB;
  background-color: #BFBFBF;
  border-color: #BFBFBF; }
  .btn.grey-silver:not(.btn-outline):focus, .btn.grey-silver:not(.btn-outline).focus {
    color: #FAFCFB;
    background-color: #a6a6a6;
    border-color: #7f7f7f; }
  .btn.grey-silver:not(.btn-outline):hover {
    color: #FAFCFB;
    background-color: #a6a6a6;
    border-color: #a0a0a0; }
  .btn.grey-silver:not(.btn-outline):active, .btn.grey-silver:not(.btn-outline).active, .open > .btn.grey-silver:not(.btn-outline).dropdown-toggle {
    color: #FAFCFB;
    background-color: #a6a6a6;
    border-color: #a0a0a0; }
    .btn.grey-silver:not(.btn-outline):active:hover, .btn.grey-silver:not(.btn-outline):active:focus, .btn.grey-silver:not(.btn-outline):active.focus, .btn.grey-silver:not(.btn-outline).active:hover, .btn.grey-silver:not(.btn-outline).active:focus, .btn.grey-silver:not(.btn-outline).active.focus, .open > .btn.grey-silver:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-silver:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-silver:not(.btn-outline).dropdown-toggle.focus {
      color: #FAFCFB;
      background-color: #949494;
      border-color: #7f7f7f; }
  .btn.grey-silver:not(.btn-outline):active, .btn.grey-silver:not(.btn-outline).active, .open > .btn.grey-silver:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-silver:not(.btn-outline).disabled:hover, .btn.grey-silver:not(.btn-outline).disabled:focus, .btn.grey-silver:not(.btn-outline).disabled.focus, .btn.grey-silver:not(.btn-outline)[disabled]:hover, .btn.grey-silver:not(.btn-outline)[disabled]:focus, .btn.grey-silver:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-silver:not(.btn-outline):hover, fieldset[disabled] .btn.grey-silver:not(.btn-outline):focus, fieldset[disabled] .btn.grey-silver:not(.btn-outline).focus {
    background-color: #BFBFBF;
    border-color: #BFBFBF; }
  .btn.grey-silver:not(.btn-outline) .badge {
    color: #BFBFBF;
    background-color: #FAFCFB; }

.btn.btn-outline.grey-silver {
  border-color: #BFBFBF;
  color: #BFBFBF;
  background: none; }
  .btn.btn-outline.grey-silver:hover, .btn.btn-outline.grey-silver:active, .btn.btn-outline.grey-silver:active:hover, .btn.btn-outline.grey-silver:active:focus, .btn.btn-outline.grey-silver:focus, .btn.btn-outline.grey-silver.active {
    border-color: #BFBFBF;
    color: #FAFCFB;
    background-color: #BFBFBF; }

.btn.grey-silver-stripe {
  border-left: 4px solid #BFBFBF !important; }

.btn.grey-silver.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-salsa:not(.btn-outline) {
  color: #FAFCFB;
  background-color: #ACB5C3;
  border-color: #ACB5C3; }
  .btn.grey-salsa:not(.btn-outline):focus, .btn.grey-salsa:not(.btn-outline).focus {
    color: #FAFCFB;
    background-color: #8e9bae;
    border-color: #64748b; }
  .btn.grey-salsa:not(.btn-outline):hover {
    color: #FAFCFB;
    background-color: #8e9bae;
    border-color: #8895a9; }
  .btn.grey-salsa:not(.btn-outline):active, .btn.grey-salsa:not(.btn-outline).active, .open > .btn.grey-salsa:not(.btn-outline).dropdown-toggle {
    color: #FAFCFB;
    background-color: #8e9bae;
    border-color: #8895a9; }
    .btn.grey-salsa:not(.btn-outline):active:hover, .btn.grey-salsa:not(.btn-outline):active:focus, .btn.grey-salsa:not(.btn-outline):active.focus, .btn.grey-salsa:not(.btn-outline).active:hover, .btn.grey-salsa:not(.btn-outline).active:focus, .btn.grey-salsa:not(.btn-outline).active.focus, .open > .btn.grey-salsa:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-salsa:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-salsa:not(.btn-outline).dropdown-toggle.focus {
      color: #FAFCFB;
      background-color: #7a889f;
      border-color: #64748b; }
  .btn.grey-salsa:not(.btn-outline):active, .btn.grey-salsa:not(.btn-outline).active, .open > .btn.grey-salsa:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-salsa:not(.btn-outline).disabled:hover, .btn.grey-salsa:not(.btn-outline).disabled:focus, .btn.grey-salsa:not(.btn-outline).disabled.focus, .btn.grey-salsa:not(.btn-outline)[disabled]:hover, .btn.grey-salsa:not(.btn-outline)[disabled]:focus, .btn.grey-salsa:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-salsa:not(.btn-outline):hover, fieldset[disabled] .btn.grey-salsa:not(.btn-outline):focus, fieldset[disabled] .btn.grey-salsa:not(.btn-outline).focus {
    background-color: #ACB5C3;
    border-color: #ACB5C3; }
  .btn.grey-salsa:not(.btn-outline) .badge {
    color: #ACB5C3;
    background-color: #FAFCFB; }

.btn.btn-outline.grey-salsa {
  border-color: #ACB5C3;
  color: #ACB5C3;
  background: none; }
  .btn.btn-outline.grey-salsa:hover, .btn.btn-outline.grey-salsa:active, .btn.btn-outline.grey-salsa:active:hover, .btn.btn-outline.grey-salsa:active:focus, .btn.btn-outline.grey-salsa:focus, .btn.btn-outline.grey-salsa.active {
    border-color: #ACB5C3;
    color: #FAFCFB;
    background-color: #ACB5C3; }

.btn.grey-salsa-stripe {
  border-left: 4px solid #ACB5C3 !important; }

.btn.grey-salsa.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-salt:not(.btn-outline) {
  color: #FAFCFB;
  background-color: #bfcad1;
  border-color: #bfcad1; }
  .btn.grey-salt:not(.btn-outline):focus, .btn.grey-salt:not(.btn-outline).focus {
    color: #FAFCFB;
    background-color: #a1b1bc;
    border-color: #758d9c; }
  .btn.grey-salt:not(.btn-outline):hover {
    color: #FAFCFB;
    background-color: #a1b1bc;
    border-color: #9badb7; }
  .btn.grey-salt:not(.btn-outline):active, .btn.grey-salt:not(.btn-outline).active, .open > .btn.grey-salt:not(.btn-outline).dropdown-toggle {
    color: #FAFCFB;
    background-color: #a1b1bc;
    border-color: #9badb7; }
    .btn.grey-salt:not(.btn-outline):active:hover, .btn.grey-salt:not(.btn-outline):active:focus, .btn.grey-salt:not(.btn-outline):active.focus, .btn.grey-salt:not(.btn-outline).active:hover, .btn.grey-salt:not(.btn-outline).active:focus, .btn.grey-salt:not(.btn-outline).active.focus, .open > .btn.grey-salt:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-salt:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-salt:not(.btn-outline).dropdown-toggle.focus {
      color: #FAFCFB;
      background-color: #8da0ad;
      border-color: #758d9c; }
  .btn.grey-salt:not(.btn-outline):active, .btn.grey-salt:not(.btn-outline).active, .open > .btn.grey-salt:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-salt:not(.btn-outline).disabled:hover, .btn.grey-salt:not(.btn-outline).disabled:focus, .btn.grey-salt:not(.btn-outline).disabled.focus, .btn.grey-salt:not(.btn-outline)[disabled]:hover, .btn.grey-salt:not(.btn-outline)[disabled]:focus, .btn.grey-salt:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-salt:not(.btn-outline):hover, fieldset[disabled] .btn.grey-salt:not(.btn-outline):focus, fieldset[disabled] .btn.grey-salt:not(.btn-outline).focus {
    background-color: #bfcad1;
    border-color: #bfcad1; }
  .btn.grey-salt:not(.btn-outline) .badge {
    color: #bfcad1;
    background-color: #FAFCFB; }

.btn.btn-outline.grey-salt {
  border-color: #bfcad1;
  color: #bfcad1;
  background: none; }
  .btn.btn-outline.grey-salt:hover, .btn.btn-outline.grey-salt:active, .btn.btn-outline.grey-salt:active:hover, .btn.btn-outline.grey-salt:active:focus, .btn.btn-outline.grey-salt:focus, .btn.btn-outline.grey-salt.active {
    border-color: #bfcad1;
    color: #FAFCFB;
    background-color: #bfcad1; }

.btn.grey-salt-stripe {
  border-left: 4px solid #bfcad1 !important; }

.btn.grey-salt.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.grey-mint:not(.btn-outline) {
  color: #FFFFFF;
  background-color: #525e64;
  border-color: #525e64; }
  .btn.grey-mint:not(.btn-outline):focus, .btn.grey-mint:not(.btn-outline).focus {
    color: #FFFFFF;
    background-color: #3b4448;
    border-color: #191c1e; }
  .btn.grey-mint:not(.btn-outline):hover {
    color: #FFFFFF;
    background-color: #3b4448;
    border-color: #363e42; }
  .btn.grey-mint:not(.btn-outline):active, .btn.grey-mint:not(.btn-outline).active, .open > .btn.grey-mint:not(.btn-outline).dropdown-toggle {
    color: #FFFFFF;
    background-color: #3b4448;
    border-color: #363e42; }
    .btn.grey-mint:not(.btn-outline):active:hover, .btn.grey-mint:not(.btn-outline):active:focus, .btn.grey-mint:not(.btn-outline):active.focus, .btn.grey-mint:not(.btn-outline).active:hover, .btn.grey-mint:not(.btn-outline).active:focus, .btn.grey-mint:not(.btn-outline).active.focus, .open > .btn.grey-mint:not(.btn-outline).dropdown-toggle:hover, .open > .btn.grey-mint:not(.btn-outline).dropdown-toggle:focus, .open > .btn.grey-mint:not(.btn-outline).dropdown-toggle.focus {
      color: #FFFFFF;
      background-color: #2b3134;
      border-color: #191c1e; }
  .btn.grey-mint:not(.btn-outline):active, .btn.grey-mint:not(.btn-outline).active, .open > .btn.grey-mint:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.grey-mint:not(.btn-outline).disabled:hover, .btn.grey-mint:not(.btn-outline).disabled:focus, .btn.grey-mint:not(.btn-outline).disabled.focus, .btn.grey-mint:not(.btn-outline)[disabled]:hover, .btn.grey-mint:not(.btn-outline)[disabled]:focus, .btn.grey-mint:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.grey-mint:not(.btn-outline):hover, fieldset[disabled] .btn.grey-mint:not(.btn-outline):focus, fieldset[disabled] .btn.grey-mint:not(.btn-outline).focus {
    background-color: #525e64;
    border-color: #525e64; }
  .btn.grey-mint:not(.btn-outline) .badge {
    color: #525e64;
    background-color: #FFFFFF; }

.btn.btn-outline.grey-mint {
  border-color: #525e64;
  color: #525e64;
  background: none; }
  .btn.btn-outline.grey-mint:hover, .btn.btn-outline.grey-mint:active, .btn.btn-outline.grey-mint:active:hover, .btn.btn-outline.grey-mint:active:focus, .btn.btn-outline.grey-mint:focus, .btn.btn-outline.grey-mint.active {
    border-color: #525e64;
    color: #FFFFFF;
    background-color: #525e64; }

.btn.grey-mint-stripe {
  border-left: 4px solid #525e64 !important; }

.btn.grey-mint.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red:not(.btn-outline) {
  color: #ffffff;
  background-color: #e7505a;
  border-color: #e7505a; }
  .btn.red:not(.btn-outline):focus, .btn.red:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #e12330;
    border-color: #a1161f; }
  .btn.red:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #e12330;
    border-color: #dc1e2b; }
  .btn.red:not(.btn-outline):active, .btn.red:not(.btn-outline).active, .open > .btn.red:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #e12330;
    border-color: #dc1e2b; }
    .btn.red:not(.btn-outline):active:hover, .btn.red:not(.btn-outline):active:focus, .btn.red:not(.btn-outline):active.focus, .btn.red:not(.btn-outline).active:hover, .btn.red:not(.btn-outline).active:focus, .btn.red:not(.btn-outline).active.focus, .open > .btn.red:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #c51b26;
      border-color: #a1161f; }
  .btn.red:not(.btn-outline):active, .btn.red:not(.btn-outline).active, .open > .btn.red:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red:not(.btn-outline).disabled:hover, .btn.red:not(.btn-outline).disabled:focus, .btn.red:not(.btn-outline).disabled.focus, .btn.red:not(.btn-outline)[disabled]:hover, .btn.red:not(.btn-outline)[disabled]:focus, .btn.red:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red:not(.btn-outline):hover, fieldset[disabled] .btn.red:not(.btn-outline):focus, fieldset[disabled] .btn.red:not(.btn-outline).focus {
    background-color: #e7505a;
    border-color: #e7505a; }
  .btn.red:not(.btn-outline) .badge {
    color: #e7505a;
    background-color: #ffffff; }

.btn.btn-outline.red {
  border-color: #e7505a;
  color: #e7505a;
  background: none; }
  .btn.btn-outline.red:hover, .btn.btn-outline.red:active, .btn.btn-outline.red:active:hover, .btn.btn-outline.red:active:focus, .btn.btn-outline.red:focus, .btn.btn-outline.red.active {
    border-color: #e7505a;
    color: #ffffff;
    background-color: #e7505a; }

.btn.red-stripe {
  border-left: 4px solid #e7505a !important; }

.btn.red.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-pink:not(.btn-outline) {
  color: #ffffff;
  background-color: #E08283;
  border-color: #E08283; }
  .btn.red-pink:not(.btn-outline):focus, .btn.red-pink:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #d6595a;
    border-color: #b52d2e; }
  .btn.red-pink:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #d6595a;
    border-color: #d45152; }
  .btn.red-pink:not(.btn-outline):active, .btn.red-pink:not(.btn-outline).active, .open > .btn.red-pink:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #d6595a;
    border-color: #d45152; }
    .btn.red-pink:not(.btn-outline):active:hover, .btn.red-pink:not(.btn-outline):active:focus, .btn.red-pink:not(.btn-outline):active.focus, .btn.red-pink:not(.btn-outline).active:hover, .btn.red-pink:not(.btn-outline).active:focus, .btn.red-pink:not(.btn-outline).active.focus, .open > .btn.red-pink:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-pink:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-pink:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #cf3d3e;
      border-color: #b52d2e; }
  .btn.red-pink:not(.btn-outline):active, .btn.red-pink:not(.btn-outline).active, .open > .btn.red-pink:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-pink:not(.btn-outline).disabled:hover, .btn.red-pink:not(.btn-outline).disabled:focus, .btn.red-pink:not(.btn-outline).disabled.focus, .btn.red-pink:not(.btn-outline)[disabled]:hover, .btn.red-pink:not(.btn-outline)[disabled]:focus, .btn.red-pink:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-pink:not(.btn-outline):hover, fieldset[disabled] .btn.red-pink:not(.btn-outline):focus, fieldset[disabled] .btn.red-pink:not(.btn-outline).focus {
    background-color: #E08283;
    border-color: #E08283; }
  .btn.red-pink:not(.btn-outline) .badge {
    color: #E08283;
    background-color: #ffffff; }

.btn.btn-outline.red-pink {
  border-color: #E08283;
  color: #E08283;
  background: none; }
  .btn.btn-outline.red-pink:hover, .btn.btn-outline.red-pink:active, .btn.btn-outline.red-pink:active:hover, .btn.btn-outline.red-pink:active:focus, .btn.btn-outline.red-pink:focus, .btn.btn-outline.red-pink.active {
    border-color: #E08283;
    color: #ffffff;
    background-color: #E08283; }

.btn.red-pink-stripe {
  border-left: 4px solid #E08283 !important; }

.btn.red-pink.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-sunglo:not(.btn-outline) {
  color: #ffffff;
  background-color: #E26A6A;
  border-color: #E26A6A; }
  .btn.red-sunglo:not(.btn-outline):focus, .btn.red-sunglo:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #da3f3f;
    border-color: #ab2121; }
  .btn.red-sunglo:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #da3f3f;
    border-color: #d83737; }
  .btn.red-sunglo:not(.btn-outline):active, .btn.red-sunglo:not(.btn-outline).active, .open > .btn.red-sunglo:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #da3f3f;
    border-color: #d83737; }
    .btn.red-sunglo:not(.btn-outline):active:hover, .btn.red-sunglo:not(.btn-outline):active:focus, .btn.red-sunglo:not(.btn-outline):active.focus, .btn.red-sunglo:not(.btn-outline).active:hover, .btn.red-sunglo:not(.btn-outline).active:focus, .btn.red-sunglo:not(.btn-outline).active.focus, .open > .btn.red-sunglo:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-sunglo:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-sunglo:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #cd2828;
      border-color: #ab2121; }
  .btn.red-sunglo:not(.btn-outline):active, .btn.red-sunglo:not(.btn-outline).active, .open > .btn.red-sunglo:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-sunglo:not(.btn-outline).disabled:hover, .btn.red-sunglo:not(.btn-outline).disabled:focus, .btn.red-sunglo:not(.btn-outline).disabled.focus, .btn.red-sunglo:not(.btn-outline)[disabled]:hover, .btn.red-sunglo:not(.btn-outline)[disabled]:focus, .btn.red-sunglo:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-sunglo:not(.btn-outline):hover, fieldset[disabled] .btn.red-sunglo:not(.btn-outline):focus, fieldset[disabled] .btn.red-sunglo:not(.btn-outline).focus {
    background-color: #E26A6A;
    border-color: #E26A6A; }
  .btn.red-sunglo:not(.btn-outline) .badge {
    color: #E26A6A;
    background-color: #ffffff; }

.btn.btn-outline.red-sunglo {
  border-color: #E26A6A;
  color: #E26A6A;
  background: none; }
  .btn.btn-outline.red-sunglo:hover, .btn.btn-outline.red-sunglo:active, .btn.btn-outline.red-sunglo:active:hover, .btn.btn-outline.red-sunglo:active:focus, .btn.btn-outline.red-sunglo:focus, .btn.btn-outline.red-sunglo.active {
    border-color: #E26A6A;
    color: #ffffff;
    background-color: #E26A6A; }

.btn.red-sunglo-stripe {
  border-left: 4px solid #E26A6A !important; }

.btn.red-sunglo.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-intense:not(.btn-outline) {
  color: #ffffff;
  background-color: #e35b5a;
  border-color: #e35b5a; }
  .btn.red-intense:not(.btn-outline):focus, .btn.red-intense:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #dc302e;
    border-color: #a21c1b; }
  .btn.red-intense:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #dc302e;
    border-color: #da2726; }
  .btn.red-intense:not(.btn-outline):active, .btn.red-intense:not(.btn-outline).active, .open > .btn.red-intense:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #dc302e;
    border-color: #da2726; }
    .btn.red-intense:not(.btn-outline):active:hover, .btn.red-intense:not(.btn-outline):active:focus, .btn.red-intense:not(.btn-outline):active.focus, .btn.red-intense:not(.btn-outline).active:hover, .btn.red-intense:not(.btn-outline).active:focus, .btn.red-intense:not(.btn-outline).active.focus, .open > .btn.red-intense:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-intense:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-intense:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #c52321;
      border-color: #a21c1b; }
  .btn.red-intense:not(.btn-outline):active, .btn.red-intense:not(.btn-outline).active, .open > .btn.red-intense:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-intense:not(.btn-outline).disabled:hover, .btn.red-intense:not(.btn-outline).disabled:focus, .btn.red-intense:not(.btn-outline).disabled.focus, .btn.red-intense:not(.btn-outline)[disabled]:hover, .btn.red-intense:not(.btn-outline)[disabled]:focus, .btn.red-intense:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-intense:not(.btn-outline):hover, fieldset[disabled] .btn.red-intense:not(.btn-outline):focus, fieldset[disabled] .btn.red-intense:not(.btn-outline).focus {
    background-color: #e35b5a;
    border-color: #e35b5a; }
  .btn.red-intense:not(.btn-outline) .badge {
    color: #e35b5a;
    background-color: #ffffff; }

.btn.btn-outline.red-intense {
  border-color: #e35b5a;
  color: #e35b5a;
  background: none; }
  .btn.btn-outline.red-intense:hover, .btn.btn-outline.red-intense:active, .btn.btn-outline.red-intense:active:hover, .btn.btn-outline.red-intense:active:focus, .btn.btn-outline.red-intense:focus, .btn.btn-outline.red-intense.active {
    border-color: #e35b5a;
    color: #ffffff;
    background-color: #e35b5a; }

.btn.red-intense-stripe {
  border-left: 4px solid #e35b5a !important; }

.btn.red-intense.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-thunderbird:not(.btn-outline) {
  color: #ffffff;
  background-color: #D91E18;
  border-color: #D91E18; }
  .btn.red-thunderbird:not(.btn-outline):focus, .btn.red-thunderbird:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #ab1813;
    border-color: #660e0b; }
  .btn.red-thunderbird:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #ab1813;
    border-color: #a21612; }
  .btn.red-thunderbird:not(.btn-outline):active, .btn.red-thunderbird:not(.btn-outline).active, .open > .btn.red-thunderbird:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #ab1813;
    border-color: #a21612; }
    .btn.red-thunderbird:not(.btn-outline):active:hover, .btn.red-thunderbird:not(.btn-outline):active:focus, .btn.red-thunderbird:not(.btn-outline):active.focus, .btn.red-thunderbird:not(.btn-outline).active:hover, .btn.red-thunderbird:not(.btn-outline).active:focus, .btn.red-thunderbird:not(.btn-outline).active.focus, .open > .btn.red-thunderbird:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-thunderbird:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-thunderbird:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #8b130f;
      border-color: #660e0b; }
  .btn.red-thunderbird:not(.btn-outline):active, .btn.red-thunderbird:not(.btn-outline).active, .open > .btn.red-thunderbird:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-thunderbird:not(.btn-outline).disabled:hover, .btn.red-thunderbird:not(.btn-outline).disabled:focus, .btn.red-thunderbird:not(.btn-outline).disabled.focus, .btn.red-thunderbird:not(.btn-outline)[disabled]:hover, .btn.red-thunderbird:not(.btn-outline)[disabled]:focus, .btn.red-thunderbird:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-thunderbird:not(.btn-outline):hover, fieldset[disabled] .btn.red-thunderbird:not(.btn-outline):focus, fieldset[disabled] .btn.red-thunderbird:not(.btn-outline).focus {
    background-color: #D91E18;
    border-color: #D91E18; }
  .btn.red-thunderbird:not(.btn-outline) .badge {
    color: #D91E18;
    background-color: #ffffff; }

.btn.btn-outline.red-thunderbird {
  border-color: #D91E18;
  color: #D91E18;
  background: none; }
  .btn.btn-outline.red-thunderbird:hover, .btn.btn-outline.red-thunderbird:active, .btn.btn-outline.red-thunderbird:active:hover, .btn.btn-outline.red-thunderbird:active:focus, .btn.btn-outline.red-thunderbird:focus, .btn.btn-outline.red-thunderbird.active {
    border-color: #D91E18;
    color: #ffffff;
    background-color: #D91E18; }

.btn.red-thunderbird-stripe {
  border-left: 4px solid #D91E18 !important; }

.btn.red-thunderbird.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-flamingo:not(.btn-outline) {
  color: #ffffff;
  background-color: #EF4836;
  border-color: #EF4836; }
  .btn.red-flamingo:not(.btn-outline):focus, .btn.red-flamingo:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #e02612;
    border-color: #991a0c; }
  .btn.red-flamingo:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #e02612;
    border-color: #d72411; }
  .btn.red-flamingo:not(.btn-outline):active, .btn.red-flamingo:not(.btn-outline).active, .open > .btn.red-flamingo:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #e02612;
    border-color: #d72411; }
    .btn.red-flamingo:not(.btn-outline):active:hover, .btn.red-flamingo:not(.btn-outline):active:focus, .btn.red-flamingo:not(.btn-outline):active.focus, .btn.red-flamingo:not(.btn-outline).active:hover, .btn.red-flamingo:not(.btn-outline).active:focus, .btn.red-flamingo:not(.btn-outline).active.focus, .open > .btn.red-flamingo:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-flamingo:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-flamingo:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #bf200f;
      border-color: #991a0c; }
  .btn.red-flamingo:not(.btn-outline):active, .btn.red-flamingo:not(.btn-outline).active, .open > .btn.red-flamingo:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-flamingo:not(.btn-outline).disabled:hover, .btn.red-flamingo:not(.btn-outline).disabled:focus, .btn.red-flamingo:not(.btn-outline).disabled.focus, .btn.red-flamingo:not(.btn-outline)[disabled]:hover, .btn.red-flamingo:not(.btn-outline)[disabled]:focus, .btn.red-flamingo:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-flamingo:not(.btn-outline):hover, fieldset[disabled] .btn.red-flamingo:not(.btn-outline):focus, fieldset[disabled] .btn.red-flamingo:not(.btn-outline).focus {
    background-color: #EF4836;
    border-color: #EF4836; }
  .btn.red-flamingo:not(.btn-outline) .badge {
    color: #EF4836;
    background-color: #ffffff; }

.btn.btn-outline.red-flamingo {
  border-color: #EF4836;
  color: #EF4836;
  background: none; }
  .btn.btn-outline.red-flamingo:hover, .btn.btn-outline.red-flamingo:active, .btn.btn-outline.red-flamingo:active:hover, .btn.btn-outline.red-flamingo:active:focus, .btn.btn-outline.red-flamingo:focus, .btn.btn-outline.red-flamingo.active {
    border-color: #EF4836;
    color: #ffffff;
    background-color: #EF4836; }

.btn.red-flamingo-stripe {
  border-left: 4px solid #EF4836 !important; }

.btn.red-flamingo.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-soft:not(.btn-outline) {
  color: #ffffff;
  background-color: #d05454;
  border-color: #d05454; }
  .btn.red-soft:not(.btn-outline):focus, .btn.red-soft:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #bd3434;
    border-color: #812323; }
  .btn.red-soft:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #bd3434;
    border-color: #b53232; }
  .btn.red-soft:not(.btn-outline):active, .btn.red-soft:not(.btn-outline).active, .open > .btn.red-soft:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #bd3434;
    border-color: #b53232; }
    .btn.red-soft:not(.btn-outline):active:hover, .btn.red-soft:not(.btn-outline):active:focus, .btn.red-soft:not(.btn-outline):active.focus, .btn.red-soft:not(.btn-outline).active:hover, .btn.red-soft:not(.btn-outline).active:focus, .btn.red-soft:not(.btn-outline).active.focus, .open > .btn.red-soft:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-soft:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-soft:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #a12c2c;
      border-color: #812323; }
  .btn.red-soft:not(.btn-outline):active, .btn.red-soft:not(.btn-outline).active, .open > .btn.red-soft:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-soft:not(.btn-outline).disabled:hover, .btn.red-soft:not(.btn-outline).disabled:focus, .btn.red-soft:not(.btn-outline).disabled.focus, .btn.red-soft:not(.btn-outline)[disabled]:hover, .btn.red-soft:not(.btn-outline)[disabled]:focus, .btn.red-soft:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-soft:not(.btn-outline):hover, fieldset[disabled] .btn.red-soft:not(.btn-outline):focus, fieldset[disabled] .btn.red-soft:not(.btn-outline).focus {
    background-color: #d05454;
    border-color: #d05454; }
  .btn.red-soft:not(.btn-outline) .badge {
    color: #d05454;
    background-color: #ffffff; }

.btn.btn-outline.red-soft {
  border-color: #d05454;
  color: #d05454;
  background: none; }
  .btn.btn-outline.red-soft:hover, .btn.btn-outline.red-soft:active, .btn.btn-outline.red-soft:active:hover, .btn.btn-outline.red-soft:active:focus, .btn.btn-outline.red-soft:focus, .btn.btn-outline.red-soft.active {
    border-color: #d05454;
    color: #ffffff;
    background-color: #d05454; }

.btn.red-soft-stripe {
  border-left: 4px solid #d05454 !important; }

.btn.red-soft.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-haze:not(.btn-outline) {
  color: #ffffff;
  background-color: #f36a5a;
  border-color: #f36a5a; }
  .btn.red-haze:not(.btn-outline):focus, .btn.red-haze:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #f03f2a;
    border-color: #c0210e; }
  .btn.red-haze:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #f03f2a;
    border-color: #ef3621; }
  .btn.red-haze:not(.btn-outline):active, .btn.red-haze:not(.btn-outline).active, .open > .btn.red-haze:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #f03f2a;
    border-color: #ef3621; }
    .btn.red-haze:not(.btn-outline):active:hover, .btn.red-haze:not(.btn-outline):active:focus, .btn.red-haze:not(.btn-outline):active.focus, .btn.red-haze:not(.btn-outline).active:hover, .btn.red-haze:not(.btn-outline).active:focus, .btn.red-haze:not(.btn-outline).active.focus, .open > .btn.red-haze:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-haze:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-haze:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #e62711;
      border-color: #c0210e; }
  .btn.red-haze:not(.btn-outline):active, .btn.red-haze:not(.btn-outline).active, .open > .btn.red-haze:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-haze:not(.btn-outline).disabled:hover, .btn.red-haze:not(.btn-outline).disabled:focus, .btn.red-haze:not(.btn-outline).disabled.focus, .btn.red-haze:not(.btn-outline)[disabled]:hover, .btn.red-haze:not(.btn-outline)[disabled]:focus, .btn.red-haze:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-haze:not(.btn-outline):hover, fieldset[disabled] .btn.red-haze:not(.btn-outline):focus, fieldset[disabled] .btn.red-haze:not(.btn-outline).focus {
    background-color: #f36a5a;
    border-color: #f36a5a; }
  .btn.red-haze:not(.btn-outline) .badge {
    color: #f36a5a;
    background-color: #ffffff; }

.btn.btn-outline.red-haze {
  border-color: #f36a5a;
  color: #f36a5a;
  background: none; }
  .btn.btn-outline.red-haze:hover, .btn.btn-outline.red-haze:active, .btn.btn-outline.red-haze:active:hover, .btn.btn-outline.red-haze:active:focus, .btn.btn-outline.red-haze:focus, .btn.btn-outline.red-haze.active {
    border-color: #f36a5a;
    color: #ffffff;
    background-color: #f36a5a; }

.btn.red-haze-stripe {
  border-left: 4px solid #f36a5a !important; }

.btn.red-haze.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.red-mint:not(.btn-outline) {
  color: #ffffff;
  background-color: #e43a45;
  border-color: #e43a45; }
  .btn.red-mint:not(.btn-outline):focus, .btn.red-mint:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #cf1c28;
    border-color: #8b131b; }
  .btn.red-mint:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #cf1c28;
    border-color: #c61b26; }
  .btn.red-mint:not(.btn-outline):active, .btn.red-mint:not(.btn-outline).active, .open > .btn.red-mint:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #cf1c28;
    border-color: #c61b26; }
    .btn.red-mint:not(.btn-outline):active:hover, .btn.red-mint:not(.btn-outline):active:focus, .btn.red-mint:not(.btn-outline):active.focus, .btn.red-mint:not(.btn-outline).active:hover, .btn.red-mint:not(.btn-outline).active:focus, .btn.red-mint:not(.btn-outline).active.focus, .open > .btn.red-mint:not(.btn-outline).dropdown-toggle:hover, .open > .btn.red-mint:not(.btn-outline).dropdown-toggle:focus, .open > .btn.red-mint:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #af1822;
      border-color: #8b131b; }
  .btn.red-mint:not(.btn-outline):active, .btn.red-mint:not(.btn-outline).active, .open > .btn.red-mint:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.red-mint:not(.btn-outline).disabled:hover, .btn.red-mint:not(.btn-outline).disabled:focus, .btn.red-mint:not(.btn-outline).disabled.focus, .btn.red-mint:not(.btn-outline)[disabled]:hover, .btn.red-mint:not(.btn-outline)[disabled]:focus, .btn.red-mint:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.red-mint:not(.btn-outline):hover, fieldset[disabled] .btn.red-mint:not(.btn-outline):focus, fieldset[disabled] .btn.red-mint:not(.btn-outline).focus {
    background-color: #e43a45;
    border-color: #e43a45; }
  .btn.red-mint:not(.btn-outline) .badge {
    color: #e43a45;
    background-color: #ffffff; }

.btn.btn-outline.red-mint {
  border-color: #e43a45;
  color: #e43a45;
  background: none; }
  .btn.btn-outline.red-mint:hover, .btn.btn-outline.red-mint:active, .btn.btn-outline.red-mint:active:hover, .btn.btn-outline.red-mint:active:focus, .btn.btn-outline.red-mint:focus, .btn.btn-outline.red-mint.active {
    border-color: #e43a45;
    color: #ffffff;
    background-color: #e43a45; }

.btn.red-mint-stripe {
  border-left: 4px solid #e43a45 !important; }

.btn.red-mint.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow:not(.btn-outline) {
  color: #ffffff;
  background-color: #c49f47;
  border-color: #c49f47; }
  .btn.yellow:not(.btn-outline):focus, .btn.yellow:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #a48334;
    border-color: #6a5422; }
  .btn.yellow:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #a48334;
    border-color: #9c7c32; }
  .btn.yellow:not(.btn-outline):active, .btn.yellow:not(.btn-outline).active, .open > .btn.yellow:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #a48334;
    border-color: #9c7c32; }
    .btn.yellow:not(.btn-outline):active:hover, .btn.yellow:not(.btn-outline):active:focus, .btn.yellow:not(.btn-outline):active.focus, .btn.yellow:not(.btn-outline).active:hover, .btn.yellow:not(.btn-outline).active:focus, .btn.yellow:not(.btn-outline).active.focus, .open > .btn.yellow:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #896d2c;
      border-color: #6a5422; }
  .btn.yellow:not(.btn-outline):active, .btn.yellow:not(.btn-outline).active, .open > .btn.yellow:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow:not(.btn-outline).disabled:hover, .btn.yellow:not(.btn-outline).disabled:focus, .btn.yellow:not(.btn-outline).disabled.focus, .btn.yellow:not(.btn-outline)[disabled]:hover, .btn.yellow:not(.btn-outline)[disabled]:focus, .btn.yellow:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow:not(.btn-outline):hover, fieldset[disabled] .btn.yellow:not(.btn-outline):focus, fieldset[disabled] .btn.yellow:not(.btn-outline).focus {
    background-color: #c49f47;
    border-color: #c49f47; }
  .btn.yellow:not(.btn-outline) .badge {
    color: #c49f47;
    background-color: #ffffff; }

.btn.btn-outline.yellow {
  border-color: #c49f47;
  color: #c49f47;
  background: none; }
  .btn.btn-outline.yellow:hover, .btn.btn-outline.yellow:active, .btn.btn-outline.yellow:active:hover, .btn.btn-outline.yellow:active:focus, .btn.btn-outline.yellow:focus, .btn.btn-outline.yellow.active {
    border-color: #c49f47;
    color: #ffffff;
    background-color: #c49f47; }

.btn.yellow-stripe {
  border-left: 4px solid #c49f47 !important; }

.btn.yellow.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-gold:not(.btn-outline) {
  color: #ffffff;
  background-color: #E87E04;
  border-color: #E87E04; }
  .btn.yellow-gold:not(.btn-outline):focus, .btn.yellow-gold:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #b66303;
    border-color: #6b3a02; }
  .btn.yellow-gold:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #b66303;
    border-color: #ac5d03; }
  .btn.yellow-gold:not(.btn-outline):active, .btn.yellow-gold:not(.btn-outline).active, .open > .btn.yellow-gold:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #b66303;
    border-color: #ac5d03; }
    .btn.yellow-gold:not(.btn-outline):active:hover, .btn.yellow-gold:not(.btn-outline):active:focus, .btn.yellow-gold:not(.btn-outline):active.focus, .btn.yellow-gold:not(.btn-outline).active:hover, .btn.yellow-gold:not(.btn-outline).active:focus, .btn.yellow-gold:not(.btn-outline).active.focus, .open > .btn.yellow-gold:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-gold:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-gold:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #935003;
      border-color: #6b3a02; }
  .btn.yellow-gold:not(.btn-outline):active, .btn.yellow-gold:not(.btn-outline).active, .open > .btn.yellow-gold:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-gold:not(.btn-outline).disabled:hover, .btn.yellow-gold:not(.btn-outline).disabled:focus, .btn.yellow-gold:not(.btn-outline).disabled.focus, .btn.yellow-gold:not(.btn-outline)[disabled]:hover, .btn.yellow-gold:not(.btn-outline)[disabled]:focus, .btn.yellow-gold:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-gold:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-gold:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-gold:not(.btn-outline).focus {
    background-color: #E87E04;
    border-color: #E87E04; }
  .btn.yellow-gold:not(.btn-outline) .badge {
    color: #E87E04;
    background-color: #ffffff; }

.btn.btn-outline.yellow-gold {
  border-color: #E87E04;
  color: #E87E04;
  background: none; }
  .btn.btn-outline.yellow-gold:hover, .btn.btn-outline.yellow-gold:active, .btn.btn-outline.yellow-gold:active:hover, .btn.btn-outline.yellow-gold:active:focus, .btn.btn-outline.yellow-gold:focus, .btn.btn-outline.yellow-gold.active {
    border-color: #E87E04;
    color: #ffffff;
    background-color: #E87E04; }

.btn.yellow-gold-stripe {
  border-left: 4px solid #E87E04 !important; }

.btn.yellow-gold.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-casablanca:not(.btn-outline) {
  color: #ffffff;
  background-color: #f2784b;
  border-color: #f2784b; }
  .btn.yellow-casablanca:not(.btn-outline):focus, .btn.yellow-casablanca:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #ef541b;
    border-color: #b1390d; }
  .btn.yellow-casablanca:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #ef541b;
    border-color: #ee4d12; }
  .btn.yellow-casablanca:not(.btn-outline):active, .btn.yellow-casablanca:not(.btn-outline).active, .open > .btn.yellow-casablanca:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #ef541b;
    border-color: #ee4d12; }
    .btn.yellow-casablanca:not(.btn-outline):active:hover, .btn.yellow-casablanca:not(.btn-outline):active:focus, .btn.yellow-casablanca:not(.btn-outline):active.focus, .btn.yellow-casablanca:not(.btn-outline).active:hover, .btn.yellow-casablanca:not(.btn-outline).active:focus, .btn.yellow-casablanca:not(.btn-outline).active.focus, .open > .btn.yellow-casablanca:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-casablanca:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-casablanca:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #d74510;
      border-color: #b1390d; }
  .btn.yellow-casablanca:not(.btn-outline):active, .btn.yellow-casablanca:not(.btn-outline).active, .open > .btn.yellow-casablanca:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-casablanca:not(.btn-outline).disabled:hover, .btn.yellow-casablanca:not(.btn-outline).disabled:focus, .btn.yellow-casablanca:not(.btn-outline).disabled.focus, .btn.yellow-casablanca:not(.btn-outline)[disabled]:hover, .btn.yellow-casablanca:not(.btn-outline)[disabled]:focus, .btn.yellow-casablanca:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-casablanca:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-casablanca:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-casablanca:not(.btn-outline).focus {
    background-color: #f2784b;
    border-color: #f2784b; }
  .btn.yellow-casablanca:not(.btn-outline) .badge {
    color: #f2784b;
    background-color: #ffffff; }

.btn.btn-outline.yellow-casablanca {
  border-color: #f2784b;
  color: #f2784b;
  background: none; }
  .btn.btn-outline.yellow-casablanca:hover, .btn.btn-outline.yellow-casablanca:active, .btn.btn-outline.yellow-casablanca:active:hover, .btn.btn-outline.yellow-casablanca:active:focus, .btn.btn-outline.yellow-casablanca:focus, .btn.btn-outline.yellow-casablanca.active {
    border-color: #f2784b;
    color: #ffffff;
    background-color: #f2784b; }

.btn.yellow-casablanca-stripe {
  border-left: 4px solid #f2784b !important; }

.btn.yellow-casablanca.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-crusta:not(.btn-outline) {
  color: #ffffff;
  background-color: #f3c200;
  border-color: #f3c200; }
  .btn.yellow-crusta:not(.btn-outline):focus, .btn.yellow-crusta:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #c09900;
    border-color: #745c00; }
  .btn.yellow-crusta:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #c09900;
    border-color: #b69100; }
  .btn.yellow-crusta:not(.btn-outline):active, .btn.yellow-crusta:not(.btn-outline).active, .open > .btn.yellow-crusta:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #c09900;
    border-color: #b69100; }
    .btn.yellow-crusta:not(.btn-outline):active:hover, .btn.yellow-crusta:not(.btn-outline):active:focus, .btn.yellow-crusta:not(.btn-outline):active.focus, .btn.yellow-crusta:not(.btn-outline).active:hover, .btn.yellow-crusta:not(.btn-outline).active:focus, .btn.yellow-crusta:not(.btn-outline).active.focus, .open > .btn.yellow-crusta:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-crusta:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-crusta:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #9c7d00;
      border-color: #745c00; }
  .btn.yellow-crusta:not(.btn-outline):active, .btn.yellow-crusta:not(.btn-outline).active, .open > .btn.yellow-crusta:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-crusta:not(.btn-outline).disabled:hover, .btn.yellow-crusta:not(.btn-outline).disabled:focus, .btn.yellow-crusta:not(.btn-outline).disabled.focus, .btn.yellow-crusta:not(.btn-outline)[disabled]:hover, .btn.yellow-crusta:not(.btn-outline)[disabled]:focus, .btn.yellow-crusta:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-crusta:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-crusta:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-crusta:not(.btn-outline).focus {
    background-color: #f3c200;
    border-color: #f3c200; }
  .btn.yellow-crusta:not(.btn-outline) .badge {
    color: #f3c200;
    background-color: #ffffff; }

.btn.btn-outline.yellow-crusta {
  border-color: #f3c200;
  color: #f3c200;
  background: none; }
  .btn.btn-outline.yellow-crusta:hover, .btn.btn-outline.yellow-crusta:active, .btn.btn-outline.yellow-crusta:active:hover, .btn.btn-outline.yellow-crusta:active:focus, .btn.btn-outline.yellow-crusta:focus, .btn.btn-outline.yellow-crusta.active {
    border-color: #f3c200;
    color: #ffffff;
    background-color: #f3c200; }

.btn.yellow-crusta-stripe {
  border-left: 4px solid #f3c200 !important; }

.btn.yellow-crusta.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-lemon:not(.btn-outline) {
  color: #ffffff;
  background-color: #F7CA18;
  border-color: #F7CA18; }
  .btn.yellow-lemon:not(.btn-outline):focus, .btn.yellow-lemon:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #d5ab07;
    border-color: #8b7005; }
  .btn.yellow-lemon:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #d5ab07;
    border-color: #cba307; }
  .btn.yellow-lemon:not(.btn-outline):active, .btn.yellow-lemon:not(.btn-outline).active, .open > .btn.yellow-lemon:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #d5ab07;
    border-color: #cba307; }
    .btn.yellow-lemon:not(.btn-outline):active:hover, .btn.yellow-lemon:not(.btn-outline):active:focus, .btn.yellow-lemon:not(.btn-outline):active.focus, .btn.yellow-lemon:not(.btn-outline).active:hover, .btn.yellow-lemon:not(.btn-outline).active:focus, .btn.yellow-lemon:not(.btn-outline).active.focus, .open > .btn.yellow-lemon:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-lemon:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-lemon:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #b28f06;
      border-color: #8b7005; }
  .btn.yellow-lemon:not(.btn-outline):active, .btn.yellow-lemon:not(.btn-outline).active, .open > .btn.yellow-lemon:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-lemon:not(.btn-outline).disabled:hover, .btn.yellow-lemon:not(.btn-outline).disabled:focus, .btn.yellow-lemon:not(.btn-outline).disabled.focus, .btn.yellow-lemon:not(.btn-outline)[disabled]:hover, .btn.yellow-lemon:not(.btn-outline)[disabled]:focus, .btn.yellow-lemon:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-lemon:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-lemon:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-lemon:not(.btn-outline).focus {
    background-color: #F7CA18;
    border-color: #F7CA18; }
  .btn.yellow-lemon:not(.btn-outline) .badge {
    color: #F7CA18;
    background-color: #ffffff; }

.btn.btn-outline.yellow-lemon {
  border-color: #F7CA18;
  color: #F7CA18;
  background: none; }
  .btn.btn-outline.yellow-lemon:hover, .btn.btn-outline.yellow-lemon:active, .btn.btn-outline.yellow-lemon:active:hover, .btn.btn-outline.yellow-lemon:active:focus, .btn.btn-outline.yellow-lemon:focus, .btn.btn-outline.yellow-lemon.active {
    border-color: #F7CA18;
    color: #ffffff;
    background-color: #F7CA18; }

.btn.yellow-lemon-stripe {
  border-left: 4px solid #F7CA18 !important; }

.btn.yellow-lemon.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-saffron:not(.btn-outline) {
  color: #ffffff;
  background-color: #F4D03F;
  border-color: #F4D03F; }
  .btn.yellow-saffron:not(.btn-outline):focus, .btn.yellow-saffron:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #f1c40f;
    border-color: #aa8a0a; }
  .btn.yellow-saffron:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #f1c40f;
    border-color: #e8bd0d; }
  .btn.yellow-saffron:not(.btn-outline):active, .btn.yellow-saffron:not(.btn-outline).active, .open > .btn.yellow-saffron:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #f1c40f;
    border-color: #e8bd0d; }
    .btn.yellow-saffron:not(.btn-outline):active:hover, .btn.yellow-saffron:not(.btn-outline):active:focus, .btn.yellow-saffron:not(.btn-outline):active.focus, .btn.yellow-saffron:not(.btn-outline).active:hover, .btn.yellow-saffron:not(.btn-outline).active:focus, .btn.yellow-saffron:not(.btn-outline).active.focus, .open > .btn.yellow-saffron:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-saffron:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-saffron:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #d0a90c;
      border-color: #aa8a0a; }
  .btn.yellow-saffron:not(.btn-outline):active, .btn.yellow-saffron:not(.btn-outline).active, .open > .btn.yellow-saffron:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-saffron:not(.btn-outline).disabled:hover, .btn.yellow-saffron:not(.btn-outline).disabled:focus, .btn.yellow-saffron:not(.btn-outline).disabled.focus, .btn.yellow-saffron:not(.btn-outline)[disabled]:hover, .btn.yellow-saffron:not(.btn-outline)[disabled]:focus, .btn.yellow-saffron:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-saffron:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-saffron:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-saffron:not(.btn-outline).focus {
    background-color: #F4D03F;
    border-color: #F4D03F; }
  .btn.yellow-saffron:not(.btn-outline) .badge {
    color: #F4D03F;
    background-color: #ffffff; }

.btn.btn-outline.yellow-saffron {
  border-color: #F4D03F;
  color: #F4D03F;
  background: none; }
  .btn.btn-outline.yellow-saffron:hover, .btn.btn-outline.yellow-saffron:active, .btn.btn-outline.yellow-saffron:active:hover, .btn.btn-outline.yellow-saffron:active:focus, .btn.btn-outline.yellow-saffron:focus, .btn.btn-outline.yellow-saffron.active {
    border-color: #F4D03F;
    color: #ffffff;
    background-color: #F4D03F; }

.btn.yellow-saffron-stripe {
  border-left: 4px solid #F4D03F !important; }

.btn.yellow-saffron.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-soft:not(.btn-outline) {
  color: #ffffff;
  background-color: #c8d046;
  border-color: #c8d046; }
  .btn.yellow-soft:not(.btn-outline):focus, .btn.yellow-soft:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #adb52e;
    border-color: #73781e; }
  .btn.yellow-soft:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #adb52e;
    border-color: #a5ad2c; }
  .btn.yellow-soft:not(.btn-outline):active, .btn.yellow-soft:not(.btn-outline).active, .open > .btn.yellow-soft:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #adb52e;
    border-color: #a5ad2c; }
    .btn.yellow-soft:not(.btn-outline):active:hover, .btn.yellow-soft:not(.btn-outline):active:focus, .btn.yellow-soft:not(.btn-outline):active.focus, .btn.yellow-soft:not(.btn-outline).active:hover, .btn.yellow-soft:not(.btn-outline).active:focus, .btn.yellow-soft:not(.btn-outline).active.focus, .open > .btn.yellow-soft:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-soft:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-soft:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #929927;
      border-color: #73781e; }
  .btn.yellow-soft:not(.btn-outline):active, .btn.yellow-soft:not(.btn-outline).active, .open > .btn.yellow-soft:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-soft:not(.btn-outline).disabled:hover, .btn.yellow-soft:not(.btn-outline).disabled:focus, .btn.yellow-soft:not(.btn-outline).disabled.focus, .btn.yellow-soft:not(.btn-outline)[disabled]:hover, .btn.yellow-soft:not(.btn-outline)[disabled]:focus, .btn.yellow-soft:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-soft:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-soft:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-soft:not(.btn-outline).focus {
    background-color: #c8d046;
    border-color: #c8d046; }
  .btn.yellow-soft:not(.btn-outline) .badge {
    color: #c8d046;
    background-color: #ffffff; }

.btn.btn-outline.yellow-soft {
  border-color: #c8d046;
  color: #c8d046;
  background: none; }
  .btn.btn-outline.yellow-soft:hover, .btn.btn-outline.yellow-soft:active, .btn.btn-outline.yellow-soft:active:hover, .btn.btn-outline.yellow-soft:active:focus, .btn.btn-outline.yellow-soft:focus, .btn.btn-outline.yellow-soft.active {
    border-color: #c8d046;
    color: #ffffff;
    background-color: #c8d046; }

.btn.yellow-soft-stripe {
  border-left: 4px solid #c8d046 !important; }

.btn.yellow-soft.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-haze:not(.btn-outline) {
  color: #ffffff;
  background-color: #c5bf66;
  border-color: #c5bf66; }
  .btn.yellow-haze:not(.btn-outline):focus, .btn.yellow-haze:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #b4ad44;
    border-color: #7c772f; }
  .btn.yellow-haze:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #b4ad44;
    border-color: #aca641; }
  .btn.yellow-haze:not(.btn-outline):active, .btn.yellow-haze:not(.btn-outline).active, .open > .btn.yellow-haze:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #b4ad44;
    border-color: #aca641; }
    .btn.yellow-haze:not(.btn-outline):active:hover, .btn.yellow-haze:not(.btn-outline):active:focus, .btn.yellow-haze:not(.btn-outline):active.focus, .btn.yellow-haze:not(.btn-outline).active:hover, .btn.yellow-haze:not(.btn-outline).active:focus, .btn.yellow-haze:not(.btn-outline).active.focus, .open > .btn.yellow-haze:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-haze:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-haze:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #9a943a;
      border-color: #7c772f; }
  .btn.yellow-haze:not(.btn-outline):active, .btn.yellow-haze:not(.btn-outline).active, .open > .btn.yellow-haze:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-haze:not(.btn-outline).disabled:hover, .btn.yellow-haze:not(.btn-outline).disabled:focus, .btn.yellow-haze:not(.btn-outline).disabled.focus, .btn.yellow-haze:not(.btn-outline)[disabled]:hover, .btn.yellow-haze:not(.btn-outline)[disabled]:focus, .btn.yellow-haze:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-haze:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-haze:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-haze:not(.btn-outline).focus {
    background-color: #c5bf66;
    border-color: #c5bf66; }
  .btn.yellow-haze:not(.btn-outline) .badge {
    color: #c5bf66;
    background-color: #ffffff; }

.btn.btn-outline.yellow-haze {
  border-color: #c5bf66;
  color: #c5bf66;
  background: none; }
  .btn.btn-outline.yellow-haze:hover, .btn.btn-outline.yellow-haze:active, .btn.btn-outline.yellow-haze:active:hover, .btn.btn-outline.yellow-haze:active:focus, .btn.btn-outline.yellow-haze:focus, .btn.btn-outline.yellow-haze.active {
    border-color: #c5bf66;
    color: #ffffff;
    background-color: #c5bf66; }

.btn.yellow-haze-stripe {
  border-left: 4px solid #c5bf66 !important; }

.btn.yellow-haze.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.yellow-mint:not(.btn-outline) {
  color: #ffffff;
  background-color: #c5b96b;
  border-color: #c5b96b; }
  .btn.yellow-mint:not(.btn-outline):focus, .btn.yellow-mint:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #b6a747;
    border-color: #7f7532; }
  .btn.yellow-mint:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #b6a747;
    border-color: #aea044; }
  .btn.yellow-mint:not(.btn-outline):active, .btn.yellow-mint:not(.btn-outline).active, .open > .btn.yellow-mint:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #b6a747;
    border-color: #aea044; }
    .btn.yellow-mint:not(.btn-outline):active:hover, .btn.yellow-mint:not(.btn-outline):active:focus, .btn.yellow-mint:not(.btn-outline):active.focus, .btn.yellow-mint:not(.btn-outline).active:hover, .btn.yellow-mint:not(.btn-outline).active:focus, .btn.yellow-mint:not(.btn-outline).active.focus, .open > .btn.yellow-mint:not(.btn-outline).dropdown-toggle:hover, .open > .btn.yellow-mint:not(.btn-outline).dropdown-toggle:focus, .open > .btn.yellow-mint:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #9c8f3d;
      border-color: #7f7532; }
  .btn.yellow-mint:not(.btn-outline):active, .btn.yellow-mint:not(.btn-outline).active, .open > .btn.yellow-mint:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.yellow-mint:not(.btn-outline).disabled:hover, .btn.yellow-mint:not(.btn-outline).disabled:focus, .btn.yellow-mint:not(.btn-outline).disabled.focus, .btn.yellow-mint:not(.btn-outline)[disabled]:hover, .btn.yellow-mint:not(.btn-outline)[disabled]:focus, .btn.yellow-mint:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.yellow-mint:not(.btn-outline):hover, fieldset[disabled] .btn.yellow-mint:not(.btn-outline):focus, fieldset[disabled] .btn.yellow-mint:not(.btn-outline).focus {
    background-color: #c5b96b;
    border-color: #c5b96b; }
  .btn.yellow-mint:not(.btn-outline) .badge {
    color: #c5b96b;
    background-color: #ffffff; }

.btn.btn-outline.yellow-mint {
  border-color: #c5b96b;
  color: #c5b96b;
  background: none; }
  .btn.btn-outline.yellow-mint:hover, .btn.btn-outline.yellow-mint:active, .btn.btn-outline.yellow-mint:active:hover, .btn.btn-outline.yellow-mint:active:focus, .btn.btn-outline.yellow-mint:focus, .btn.btn-outline.yellow-mint.active {
    border-color: #c5b96b;
    color: #ffffff;
    background-color: #c5b96b; }

.btn.yellow-mint-stripe {
  border-left: 4px solid #c5b96b !important; }

.btn.yellow-mint.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple:not(.btn-outline) {
  color: #ffffff;
  background-color: #8E44AD;
  border-color: #8E44AD; }
  .btn.purple:not(.btn-outline):focus, .btn.purple:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #703688;
    border-color: #432051; }
  .btn.purple:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #703688;
    border-color: #6a3381; }
  .btn.purple:not(.btn-outline):active, .btn.purple:not(.btn-outline).active, .open > .btn.purple:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #703688;
    border-color: #6a3381; }
    .btn.purple:not(.btn-outline):active:hover, .btn.purple:not(.btn-outline):active:focus, .btn.purple:not(.btn-outline):active.focus, .btn.purple:not(.btn-outline).active:hover, .btn.purple:not(.btn-outline).active:focus, .btn.purple:not(.btn-outline).active.focus, .open > .btn.purple:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #5b2c6f;
      border-color: #432051; }
  .btn.purple:not(.btn-outline):active, .btn.purple:not(.btn-outline).active, .open > .btn.purple:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple:not(.btn-outline).disabled:hover, .btn.purple:not(.btn-outline).disabled:focus, .btn.purple:not(.btn-outline).disabled.focus, .btn.purple:not(.btn-outline)[disabled]:hover, .btn.purple:not(.btn-outline)[disabled]:focus, .btn.purple:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple:not(.btn-outline):hover, fieldset[disabled] .btn.purple:not(.btn-outline):focus, fieldset[disabled] .btn.purple:not(.btn-outline).focus {
    background-color: #8E44AD;
    border-color: #8E44AD; }
  .btn.purple:not(.btn-outline) .badge {
    color: #8E44AD;
    background-color: #ffffff; }

.btn.btn-outline.purple {
  border-color: #8E44AD;
  color: #8E44AD;
  background: none; }
  .btn.btn-outline.purple:hover, .btn.btn-outline.purple:active, .btn.btn-outline.purple:active:hover, .btn.btn-outline.purple:active:focus, .btn.btn-outline.purple:focus, .btn.btn-outline.purple.active {
    border-color: #8E44AD;
    color: #ffffff;
    background-color: #8E44AD; }

.btn.purple-stripe {
  border-left: 4px solid #8E44AD !important; }

.btn.purple.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-plum:not(.btn-outline) {
  color: #ffffff;
  background-color: #8775a7;
  border-color: #8775a7; }
  .btn.purple-plum:not(.btn-outline):focus, .btn.purple-plum:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #6d5b8e;
    border-color: #493d60; }
  .btn.purple-plum:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #6d5b8e;
    border-color: #685788; }
  .btn.purple-plum:not(.btn-outline):active, .btn.purple-plum:not(.btn-outline).active, .open > .btn.purple-plum:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #6d5b8e;
    border-color: #685788; }
    .btn.purple-plum:not(.btn-outline):active:hover, .btn.purple-plum:not(.btn-outline):active:focus, .btn.purple-plum:not(.btn-outline):active.focus, .btn.purple-plum:not(.btn-outline).active:hover, .btn.purple-plum:not(.btn-outline).active:focus, .btn.purple-plum:not(.btn-outline).active.focus, .open > .btn.purple-plum:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-plum:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-plum:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #5d4d78;
      border-color: #493d60; }
  .btn.purple-plum:not(.btn-outline):active, .btn.purple-plum:not(.btn-outline).active, .open > .btn.purple-plum:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-plum:not(.btn-outline).disabled:hover, .btn.purple-plum:not(.btn-outline).disabled:focus, .btn.purple-plum:not(.btn-outline).disabled.focus, .btn.purple-plum:not(.btn-outline)[disabled]:hover, .btn.purple-plum:not(.btn-outline)[disabled]:focus, .btn.purple-plum:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-plum:not(.btn-outline):hover, fieldset[disabled] .btn.purple-plum:not(.btn-outline):focus, fieldset[disabled] .btn.purple-plum:not(.btn-outline).focus {
    background-color: #8775a7;
    border-color: #8775a7; }
  .btn.purple-plum:not(.btn-outline) .badge {
    color: #8775a7;
    background-color: #ffffff; }

.btn.btn-outline.purple-plum {
  border-color: #8775a7;
  color: #8775a7;
  background: none; }
  .btn.btn-outline.purple-plum:hover, .btn.btn-outline.purple-plum:active, .btn.btn-outline.purple-plum:active:hover, .btn.btn-outline.purple-plum:active:focus, .btn.btn-outline.purple-plum:focus, .btn.btn-outline.purple-plum.active {
    border-color: #8775a7;
    color: #ffffff;
    background-color: #8775a7; }

.btn.purple-plum-stripe {
  border-left: 4px solid #8775a7 !important; }

.btn.purple-plum.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-medium:not(.btn-outline) {
  color: #ffffff;
  background-color: #BF55EC;
  border-color: #BF55EC; }
  .btn.purple-medium:not(.btn-outline):focus, .btn.purple-medium:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #ae27e7;
    border-color: #8013ae; }
  .btn.purple-medium:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #ae27e7;
    border-color: #aa1ee6; }
  .btn.purple-medium:not(.btn-outline):active, .btn.purple-medium:not(.btn-outline).active, .open > .btn.purple-medium:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #ae27e7;
    border-color: #aa1ee6; }
    .btn.purple-medium:not(.btn-outline):active:hover, .btn.purple-medium:not(.btn-outline):active:focus, .btn.purple-medium:not(.btn-outline):active.focus, .btn.purple-medium:not(.btn-outline).active:hover, .btn.purple-medium:not(.btn-outline).active:focus, .btn.purple-medium:not(.btn-outline).active.focus, .open > .btn.purple-medium:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-medium:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-medium:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #9b18d3;
      border-color: #8013ae; }
  .btn.purple-medium:not(.btn-outline):active, .btn.purple-medium:not(.btn-outline).active, .open > .btn.purple-medium:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-medium:not(.btn-outline).disabled:hover, .btn.purple-medium:not(.btn-outline).disabled:focus, .btn.purple-medium:not(.btn-outline).disabled.focus, .btn.purple-medium:not(.btn-outline)[disabled]:hover, .btn.purple-medium:not(.btn-outline)[disabled]:focus, .btn.purple-medium:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-medium:not(.btn-outline):hover, fieldset[disabled] .btn.purple-medium:not(.btn-outline):focus, fieldset[disabled] .btn.purple-medium:not(.btn-outline).focus {
    background-color: #BF55EC;
    border-color: #BF55EC; }
  .btn.purple-medium:not(.btn-outline) .badge {
    color: #BF55EC;
    background-color: #ffffff; }

.btn.btn-outline.purple-medium {
  border-color: #BF55EC;
  color: #BF55EC;
  background: none; }
  .btn.btn-outline.purple-medium:hover, .btn.btn-outline.purple-medium:active, .btn.btn-outline.purple-medium:active:hover, .btn.btn-outline.purple-medium:active:focus, .btn.btn-outline.purple-medium:focus, .btn.btn-outline.purple-medium.active {
    border-color: #BF55EC;
    color: #ffffff;
    background-color: #BF55EC; }

.btn.purple-medium-stripe {
  border-left: 4px solid #BF55EC !important; }

.btn.purple-medium.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-studio:not(.btn-outline) {
  color: #ffffff;
  background-color: #8E44AD;
  border-color: #8E44AD; }
  .btn.purple-studio:not(.btn-outline):focus, .btn.purple-studio:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #703688;
    border-color: #432051; }
  .btn.purple-studio:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #703688;
    border-color: #6a3381; }
  .btn.purple-studio:not(.btn-outline):active, .btn.purple-studio:not(.btn-outline).active, .open > .btn.purple-studio:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #703688;
    border-color: #6a3381; }
    .btn.purple-studio:not(.btn-outline):active:hover, .btn.purple-studio:not(.btn-outline):active:focus, .btn.purple-studio:not(.btn-outline):active.focus, .btn.purple-studio:not(.btn-outline).active:hover, .btn.purple-studio:not(.btn-outline).active:focus, .btn.purple-studio:not(.btn-outline).active.focus, .open > .btn.purple-studio:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-studio:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-studio:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #5b2c6f;
      border-color: #432051; }
  .btn.purple-studio:not(.btn-outline):active, .btn.purple-studio:not(.btn-outline).active, .open > .btn.purple-studio:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-studio:not(.btn-outline).disabled:hover, .btn.purple-studio:not(.btn-outline).disabled:focus, .btn.purple-studio:not(.btn-outline).disabled.focus, .btn.purple-studio:not(.btn-outline)[disabled]:hover, .btn.purple-studio:not(.btn-outline)[disabled]:focus, .btn.purple-studio:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-studio:not(.btn-outline):hover, fieldset[disabled] .btn.purple-studio:not(.btn-outline):focus, fieldset[disabled] .btn.purple-studio:not(.btn-outline).focus {
    background-color: #8E44AD;
    border-color: #8E44AD; }
  .btn.purple-studio:not(.btn-outline) .badge {
    color: #8E44AD;
    background-color: #ffffff; }

.btn.btn-outline.purple-studio {
  border-color: #8E44AD;
  color: #8E44AD;
  background: none; }
  .btn.btn-outline.purple-studio:hover, .btn.btn-outline.purple-studio:active, .btn.btn-outline.purple-studio:active:hover, .btn.btn-outline.purple-studio:active:focus, .btn.btn-outline.purple-studio:focus, .btn.btn-outline.purple-studio.active {
    border-color: #8E44AD;
    color: #ffffff;
    background-color: #8E44AD; }

.btn.purple-studio-stripe {
  border-left: 4px solid #8E44AD !important; }

.btn.purple-studio.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-wisteria:not(.btn-outline) {
  color: #ffffff;
  background-color: #9B59B6;
  border-color: #9B59B6; }
  .btn.purple-wisteria:not(.btn-outline):focus, .btn.purple-wisteria:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #804399;
    border-color: #532c64; }
  .btn.purple-wisteria:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #804399;
    border-color: #7a4092; }
  .btn.purple-wisteria:not(.btn-outline):active, .btn.purple-wisteria:not(.btn-outline).active, .open > .btn.purple-wisteria:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #804399;
    border-color: #7a4092; }
    .btn.purple-wisteria:not(.btn-outline):active:hover, .btn.purple-wisteria:not(.btn-outline):active:focus, .btn.purple-wisteria:not(.btn-outline):active.focus, .btn.purple-wisteria:not(.btn-outline).active:hover, .btn.purple-wisteria:not(.btn-outline).active:focus, .btn.purple-wisteria:not(.btn-outline).active.focus, .open > .btn.purple-wisteria:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-wisteria:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-wisteria:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #6b3880;
      border-color: #532c64; }
  .btn.purple-wisteria:not(.btn-outline):active, .btn.purple-wisteria:not(.btn-outline).active, .open > .btn.purple-wisteria:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-wisteria:not(.btn-outline).disabled:hover, .btn.purple-wisteria:not(.btn-outline).disabled:focus, .btn.purple-wisteria:not(.btn-outline).disabled.focus, .btn.purple-wisteria:not(.btn-outline)[disabled]:hover, .btn.purple-wisteria:not(.btn-outline)[disabled]:focus, .btn.purple-wisteria:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-wisteria:not(.btn-outline):hover, fieldset[disabled] .btn.purple-wisteria:not(.btn-outline):focus, fieldset[disabled] .btn.purple-wisteria:not(.btn-outline).focus {
    background-color: #9B59B6;
    border-color: #9B59B6; }
  .btn.purple-wisteria:not(.btn-outline) .badge {
    color: #9B59B6;
    background-color: #ffffff; }

.btn.btn-outline.purple-wisteria {
  border-color: #9B59B6;
  color: #9B59B6;
  background: none; }
  .btn.btn-outline.purple-wisteria:hover, .btn.btn-outline.purple-wisteria:active, .btn.btn-outline.purple-wisteria:active:hover, .btn.btn-outline.purple-wisteria:active:focus, .btn.btn-outline.purple-wisteria:focus, .btn.btn-outline.purple-wisteria.active {
    border-color: #9B59B6;
    color: #ffffff;
    background-color: #9B59B6; }

.btn.purple-wisteria-stripe {
  border-left: 4px solid #9B59B6 !important; }

.btn.purple-wisteria.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-seance:not(.btn-outline) {
  color: #ffffff;
  background-color: #9A12B3;
  border-color: #9A12B3; }
  .btn.purple-seance:not(.btn-outline):focus, .btn.purple-seance:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #720d85;
    border-color: #36063f; }
  .btn.purple-seance:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #720d85;
    border-color: #6a0c7b; }
  .btn.purple-seance:not(.btn-outline):active, .btn.purple-seance:not(.btn-outline).active, .open > .btn.purple-seance:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #720d85;
    border-color: #6a0c7b; }
    .btn.purple-seance:not(.btn-outline):active:hover, .btn.purple-seance:not(.btn-outline):active:focus, .btn.purple-seance:not(.btn-outline):active.focus, .btn.purple-seance:not(.btn-outline).active:hover, .btn.purple-seance:not(.btn-outline).active:focus, .btn.purple-seance:not(.btn-outline).active.focus, .open > .btn.purple-seance:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-seance:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-seance:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #560a64;
      border-color: #36063f; }
  .btn.purple-seance:not(.btn-outline):active, .btn.purple-seance:not(.btn-outline).active, .open > .btn.purple-seance:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-seance:not(.btn-outline).disabled:hover, .btn.purple-seance:not(.btn-outline).disabled:focus, .btn.purple-seance:not(.btn-outline).disabled.focus, .btn.purple-seance:not(.btn-outline)[disabled]:hover, .btn.purple-seance:not(.btn-outline)[disabled]:focus, .btn.purple-seance:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-seance:not(.btn-outline):hover, fieldset[disabled] .btn.purple-seance:not(.btn-outline):focus, fieldset[disabled] .btn.purple-seance:not(.btn-outline).focus {
    background-color: #9A12B3;
    border-color: #9A12B3; }
  .btn.purple-seance:not(.btn-outline) .badge {
    color: #9A12B3;
    background-color: #ffffff; }

.btn.btn-outline.purple-seance {
  border-color: #9A12B3;
  color: #9A12B3;
  background: none; }
  .btn.btn-outline.purple-seance:hover, .btn.btn-outline.purple-seance:active, .btn.btn-outline.purple-seance:active:hover, .btn.btn-outline.purple-seance:active:focus, .btn.btn-outline.purple-seance:focus, .btn.btn-outline.purple-seance.active {
    border-color: #9A12B3;
    color: #ffffff;
    background-color: #9A12B3; }

.btn.purple-seance-stripe {
  border-left: 4px solid #9A12B3 !important; }

.btn.purple-seance.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-intense:not(.btn-outline) {
  color: #ffffff;
  background-color: #8775a7;
  border-color: #8775a7; }
  .btn.purple-intense:not(.btn-outline):focus, .btn.purple-intense:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #6d5b8e;
    border-color: #493d60; }
  .btn.purple-intense:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #6d5b8e;
    border-color: #685788; }
  .btn.purple-intense:not(.btn-outline):active, .btn.purple-intense:not(.btn-outline).active, .open > .btn.purple-intense:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #6d5b8e;
    border-color: #685788; }
    .btn.purple-intense:not(.btn-outline):active:hover, .btn.purple-intense:not(.btn-outline):active:focus, .btn.purple-intense:not(.btn-outline):active.focus, .btn.purple-intense:not(.btn-outline).active:hover, .btn.purple-intense:not(.btn-outline).active:focus, .btn.purple-intense:not(.btn-outline).active.focus, .open > .btn.purple-intense:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-intense:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-intense:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #5d4d78;
      border-color: #493d60; }
  .btn.purple-intense:not(.btn-outline):active, .btn.purple-intense:not(.btn-outline).active, .open > .btn.purple-intense:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-intense:not(.btn-outline).disabled:hover, .btn.purple-intense:not(.btn-outline).disabled:focus, .btn.purple-intense:not(.btn-outline).disabled.focus, .btn.purple-intense:not(.btn-outline)[disabled]:hover, .btn.purple-intense:not(.btn-outline)[disabled]:focus, .btn.purple-intense:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-intense:not(.btn-outline):hover, fieldset[disabled] .btn.purple-intense:not(.btn-outline):focus, fieldset[disabled] .btn.purple-intense:not(.btn-outline).focus {
    background-color: #8775a7;
    border-color: #8775a7; }
  .btn.purple-intense:not(.btn-outline) .badge {
    color: #8775a7;
    background-color: #ffffff; }

.btn.btn-outline.purple-intense {
  border-color: #8775a7;
  color: #8775a7;
  background: none; }
  .btn.btn-outline.purple-intense:hover, .btn.btn-outline.purple-intense:active, .btn.btn-outline.purple-intense:active:hover, .btn.btn-outline.purple-intense:active:focus, .btn.btn-outline.purple-intense:focus, .btn.btn-outline.purple-intense.active {
    border-color: #8775a7;
    color: #ffffff;
    background-color: #8775a7; }

.btn.purple-intense-stripe {
  border-left: 4px solid #8775a7 !important; }

.btn.purple-intense.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-sharp:not(.btn-outline) {
  color: #ffffff;
  background-color: #796799;
  border-color: #796799; }
  .btn.purple-sharp:not(.btn-outline):focus, .btn.purple-sharp:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #61527b;
    border-color: #3d344d; }
  .btn.purple-sharp:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #61527b;
    border-color: #5c4e75; }
  .btn.purple-sharp:not(.btn-outline):active, .btn.purple-sharp:not(.btn-outline).active, .open > .btn.purple-sharp:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #61527b;
    border-color: #5c4e75; }
    .btn.purple-sharp:not(.btn-outline):active:hover, .btn.purple-sharp:not(.btn-outline):active:focus, .btn.purple-sharp:not(.btn-outline):active.focus, .btn.purple-sharp:not(.btn-outline).active:hover, .btn.purple-sharp:not(.btn-outline).active:focus, .btn.purple-sharp:not(.btn-outline).active.focus, .open > .btn.purple-sharp:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-sharp:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-sharp:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #504465;
      border-color: #3d344d; }
  .btn.purple-sharp:not(.btn-outline):active, .btn.purple-sharp:not(.btn-outline).active, .open > .btn.purple-sharp:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-sharp:not(.btn-outline).disabled:hover, .btn.purple-sharp:not(.btn-outline).disabled:focus, .btn.purple-sharp:not(.btn-outline).disabled.focus, .btn.purple-sharp:not(.btn-outline)[disabled]:hover, .btn.purple-sharp:not(.btn-outline)[disabled]:focus, .btn.purple-sharp:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-sharp:not(.btn-outline):hover, fieldset[disabled] .btn.purple-sharp:not(.btn-outline):focus, fieldset[disabled] .btn.purple-sharp:not(.btn-outline).focus {
    background-color: #796799;
    border-color: #796799; }
  .btn.purple-sharp:not(.btn-outline) .badge {
    color: #796799;
    background-color: #ffffff; }

.btn.btn-outline.purple-sharp {
  border-color: #796799;
  color: #796799;
  background: none; }
  .btn.btn-outline.purple-sharp:hover, .btn.btn-outline.purple-sharp:active, .btn.btn-outline.purple-sharp:active:hover, .btn.btn-outline.purple-sharp:active:focus, .btn.btn-outline.purple-sharp:focus, .btn.btn-outline.purple-sharp.active {
    border-color: #796799;
    color: #ffffff;
    background-color: #796799; }

.btn.purple-sharp-stripe {
  border-left: 4px solid #796799 !important; }

.btn.purple-sharp.btn-no-border:not(.active) {
  border-color: transparent; }

.btn.purple-soft:not(.btn-outline) {
  color: #ffffff;
  background-color: #8877a9;
  border-color: #8877a9; }
  .btn.purple-soft:not(.btn-outline):focus, .btn.purple-soft:not(.btn-outline).focus {
    color: #ffffff;
    background-color: #6e5c91;
    border-color: #4a3e62; }
  .btn.purple-soft:not(.btn-outline):hover {
    color: #ffffff;
    background-color: #6e5c91;
    border-color: #69588b; }
  .btn.purple-soft:not(.btn-outline):active, .btn.purple-soft:not(.btn-outline).active, .open > .btn.purple-soft:not(.btn-outline).dropdown-toggle {
    color: #ffffff;
    background-color: #6e5c91;
    border-color: #69588b; }
    .btn.purple-soft:not(.btn-outline):active:hover, .btn.purple-soft:not(.btn-outline):active:focus, .btn.purple-soft:not(.btn-outline):active.focus, .btn.purple-soft:not(.btn-outline).active:hover, .btn.purple-soft:not(.btn-outline).active:focus, .btn.purple-soft:not(.btn-outline).active.focus, .open > .btn.purple-soft:not(.btn-outline).dropdown-toggle:hover, .open > .btn.purple-soft:not(.btn-outline).dropdown-toggle:focus, .open > .btn.purple-soft:not(.btn-outline).dropdown-toggle.focus {
      color: #ffffff;
      background-color: #5d4e7b;
      border-color: #4a3e62; }
  .btn.purple-soft:not(.btn-outline):active, .btn.purple-soft:not(.btn-outline).active, .open > .btn.purple-soft:not(.btn-outline).dropdown-toggle {
    background-image: none; }
  .btn.purple-soft:not(.btn-outline).disabled:hover, .btn.purple-soft:not(.btn-outline).disabled:focus, .btn.purple-soft:not(.btn-outline).disabled.focus, .btn.purple-soft:not(.btn-outline)[disabled]:hover, .btn.purple-soft:not(.btn-outline)[disabled]:focus, .btn.purple-soft:not(.btn-outline)[disabled].focus, fieldset[disabled] .btn.purple-soft:not(.btn-outline):hover, fieldset[disabled] .btn.purple-soft:not(.btn-outline):focus, fieldset[disabled] .btn.purple-soft:not(.btn-outline).focus {
    background-color: #8877a9;
    border-color: #8877a9; }
  .btn.purple-soft:not(.btn-outline) .badge {
    color: #8877a9;
    background-color: #ffffff; }

.btn.btn-outline.purple-soft {
  border-color: #8877a9;
  color: #8877a9;
  background: none; }
  .btn.btn-outline.purple-soft:hover, .btn.btn-outline.purple-soft:active, .btn.btn-outline.purple-soft:active:hover, .btn.btn-outline.purple-soft:active:focus, .btn.btn-outline.purple-soft:focus, .btn.btn-outline.purple-soft.active {
    border-color: #8877a9;
    color: #ffffff;
    background-color: #8877a9; }

.btn.purple-soft-stripe {
  border-left: 4px solid #8877a9 !important; }

.btn.purple-soft.btn-no-border:not(.active) {
  border-color: transparent; }

/* Circle Buttons */
.btn-circle {
  border-radius: 25px !important;
  overflow: hidden; }

.btn-circle-right {
  border-radius: 0 25px 25px 0 !important; }

.btn-circle-left {
  border-radius: 25px 0 0 25px !important; }

.btn-circle-bottom {
  border-radius: 0 0 25px 25px !important; }

.btn-circle-top {
  border-radius: 25px 25px 0 0 !important; }

.btn-icon-only {
  height: 34px;
  width: 34px;
  text-align: center;
  padding-left: 0;
  padding-right: 0; }
  .btn-icon-only > [class^="icon-"],
  .btn-icon-only > i {
    text-align: center;
    margin-top: 2px; }

.btn-group.btn-group-circle > .btn:first-child {
  border-radius: 25px 0 0 25px !important; }
.btn-group.btn-group-circle > .btn:last-child {
  border-radius: 0 25px 25px 0 !important; }

.btn-group.btn-group-devided > .btn {
  margin-right: 5px; }
  .btn-group.btn-group-devided > .btn:last-child {
    margin-right: 0; }

.btn-group-vertical.btn-group-vertical-circle > .btn:first-child {
  border-radius: 25px 25px 0 0 !important; }
.btn-group-vertical.btn-group-vertical-circle > .btn:last-child {
  border-radius: 0 0 25px 25px !important; }

.btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all) {
  font-size: 12px;
  font-weight: 600;
  text-transform: uppercase;
  transition: box-shadow 0.28s cubic-bezier(0.4, 0, 0.2, 1);
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  overflow: hidden;
  position: relative;
  user-select: none;
  padding: 8px 14px 7px 14px; }
  .search-form .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all), .btn-theme-panel .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all) {
    box-shadow: none !important;
    overflow: visible; }
  .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-link {
    box-shadow: none;
    color: #337ab7; }
    .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-link:hover {
      text-decoration: none; }
  .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all) > i {
    margin-top: 0;
    margin-left: 3px;
    margin-right: 3px; }
  .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-sm {
    font-size: 11px;
    padding: 6px 18px 6px 18px; }
  .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-xs {
    font-size: 11px;
    padding: 3px 8px 3px 8px; }
  .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-lg {
    font-size: 16px;
    padding: 12px 26px 10px 26px; }
  .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-icon-only {
    padding-left: 0;
    padding-right: 0; }
    .btn:not(.md-skip):not(.bs-select-all):not(.bs-deselect-all).btn-icon-only > i {
      margin-left: 0;
      margin-right: 0; }

/***
Image Carousel
***/
.carousel.image-carousel .carousel-inner {
  padding-top: 0;
  padding-bottom: 0; }
.carousel.image-carousel .carousel-control i {
  position: absolute;
  top: 40%; }
.carousel.image-carousel.image-carousel-hoverable .carousel-control i {
  display: none; }
.carousel.image-carousel.image-carousel-hoverable:hover .carousel-control i {
  display: inline-block; }
.carousel.image-carousel .carousel-control.left i {
  left: 10px; }
.carousel.image-carousel .carousel-control.right i {
  right: 10px; }
.carousel.image-carousel .carousel-indicators {
  margin-top: 10px;
  bottom: -7px; }
  .carousel.image-carousel .carousel-indicators li {
    background-color: #666; }
    .carousel.image-carousel .carousel-indicators li.active {
      background-color: #666; }
.carousel.image-carousel .carousel-caption {
  position: absolute;
  right: 0;
  bottom: 0;
  left: 0;
  padding: 15px 15px 25px 15px;
  background: #333333;
  background: rgba(0, 0, 0, 0.75); }
  .carousel.image-carousel .carousel-caption h4,
  .carousel.image-carousel .carousel-caption h3,
  .carousel.image-carousel .carousel-caption h2,
  .carousel.image-carousel .carousel-caption p {
    text-align: left;
    line-height: 20px;
    color: #ffffff; }
  .carousel.image-carousel .carousel-caption h4,
  .carousel.image-carousel .carousel-caption h3,
  .carousel.image-carousel .carousel-caption h2 {
    margin: 0 0 5px; }
    .carousel.image-carousel .carousel-caption h4 a,
    .carousel.image-carousel .carousel-caption h3 a,
    .carousel.image-carousel .carousel-caption h2 a {
      color: #aaa; }
  .carousel.image-carousel .carousel-caption p {
    margin-bottom: 0; }
  .carousel.image-carousel .carousel-caption .item {
    margin: 0; }

/***
Charts and statistics
***/
.chart,
.pie,
.bars {
  overflow: hidden;
  height: 300px;
  width: 100%;
  font-family: "Roboto", sans-serif !important;
  font-size: 14px; }

/***
Statistic lists
***/
.item-list.table .percent {
  width: 30px;
  float: right;
  margin-right: 10px;
  margin-top: 3px; }

/***
Chart tooltips
***/
.chart-tooltip {
  clear: both;
  z-index: 100;
  background-color: #736e6e !important;
  padding: 5px !important;
  color: #fff; }
  .chart-tooltip .label {
    clear: both;
    display: block;
    margin-bottom: 2px; }

/***
Mini chart containers
***/
.bar-chart,
.line-chart {
  display: none; }

/***
Chats
***/
.chats {
  margin: 0;
  padding: 0;
  margin-top: -15px; }
  .chats li {
    list-style: none;
    padding: 5px 0;
    margin: 10px auto;
    font-size: 12px; }
    .chats li .body {
      display: block; }
    .chats li .avatar {
      height: 45px;
      width: 45px;
      -webkit-border-radius: 50% !important;
      -moz-border-radius: 50% !important;
      border-radius: 50% !important; }
    .chats li.in .avatar {
      float: left;
      margin-right: 10px; }
    .chats li.out .avatar {
      float: right;
      margin-left: 10px; }
    .chats li .name {
      color: #3590c1;
      font-size: 13px;
      font-weight: 400; }
    .chats li .datetime {
      color: #333;
      font-size: 13px;
      font-weight: 400; }
    .chats li .message {
      display: block;
      padding: 5px;
      position: relative; }
    .chats li.in .message {
      text-align: left;
      border-left: 2px solid #1BBC9B;
      margin-left: 65px;
      background: #fafafa; }
      .chats li.in .message .arrow {
        display: block;
        position: absolute;
        top: 5px;
        left: -8px;
        width: 0;
        height: 0;
        border-top: 8px solid transparent;
        border-bottom: 8px solid transparent;
        border-right: 8px solid #1BBC9B; }
    .chats li.out .message {
      border-right: 2px solid #F3565D;
      margin-right: 65px;
      background: #fafafa;
      text-align: right; }
      .chats li.out .message .arrow {
        display: block;
        position: absolute;
        top: 5px;
        right: -8px;
        border-top: 8px solid transparent;
        border-bottom: 8px solid transparent;
        border-left: 8px solid #F3565D; }
    .chats li.out .name,
    .chats li.out .datetime {
      text-align: right; }

.chat-form {
  margin-top: 15px;
  padding: 10px;
  background-color: #e9eff3;
  overflow: hidden;
  clear: both; }
  .chat-form .input-cont {
    margin-right: 40px; }
    .chat-form .input-cont .form-control {
      border: 1px solid #ddd;
      width: 100%  !important;
      margin-top: 0;
      background-color: #fff !important; }
      .chat-form .input-cont .form-control:focus {
        border: 1px solid #4b8df9 !important; }
  .chat-form .btn-cont {
    margin-top: -41px;
    position: relative;
    float: right;
    width: 44px; }
    .chat-form .btn-cont .arrow {
      position: absolute;
      top: 17px;
      right: 43px;
      border-top: 8px solid transparent;
      border-bottom: 8px solid transparent;
      border-right: 8px solid #4d90fe;
      -webkit-box-sizing: border-box;
      -moz-box-sizing: border-box;
      box-sizing: border-box; }
    .chat-form .btn-cont .btn {
      margin-top: 7px; }
    .chat-form .btn-cont:hover .arrow {
      border-right-color: #0362fd;
      transition: all 0.3s; }
    .chat-form .btn-cont:hover .btn {
      background-color: #0362fd;
      transition: all 0.3s; }

/***
Customized Bootstrap Close Icon 
***/
.close {
  display: inline-block;
  margin-top: 0px;
  margin-right: 0px;
  width: 9px;
  height: 9px;
  background-repeat: no-repeat !important;
  text-indent: -10000px;
  outline: none;
  background-image: url("../img/remove-icon-small.png") !important; }

/***
Customized Bootstrap Dropdowns
***/
/***
Dropdowns
***/
.dropup.open > .dropdown-toggle,
.dropdown.open > .dropdown-toggle {
  border-color: #ddd; }

/***
Dropdown Menu
***/
.dropdown-menu {
  left: 0/*rtl:auto*/;
  min-width: 175px;
  position: absolute;
  z-index: 1000;
  display: none;
  float: left;
  list-style: none;
  text-shadow: none;
  padding: 0px;
  background-color: #ffffff;
  margin: 10px  0px 0px 0px;
  border: 1px solid #eee;
  font-family: "Roboto", sans-serif;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px; }
  .dropdown-hoverable:hover .dropdown-menu {
    display: block; }
  .dropdown-menu li.divider {
    background: #f1f3f6; }
  .dropdown-menu li.header {
    padding: 8px 14px 2px 14px; }
  .dropdown-menu > li > a {
    padding: 8px 16px;
    color: #6f6f6f;
    text-decoration: none;
    display: block;
    clear: both;
    font-weight: 300;
    line-height: 18px;
    white-space: nowrap; }
    .dropdown-menu > li > a > [class^="fa-"],
    .dropdown-menu > li > a > [class*=" fa-"] {
      color: #888; }
    .dropdown-menu > li > a > [class^="icon-"],
    .dropdown-menu > li > a > [class*=" icon-"] {
      color: #666; }
    .dropdown-menu > li > a > [class^="glyphicon-"],
    .dropdown-menu > li > a > [class*=" glyphicon-"] {
      color: #888; }
  .dropdown-menu > li:hover > a, .dropdown-menu > li.active > a, .dropdown-menu > li.active:hover > a {
    text-decoration: none;
    background-image: none;
    background-color: #f6f6f6;
    color: #555;
    filter: none; }
  .dropdown-menu.bottom-up {
    top: auto;
    bottom: 100%;
    margin-bottom: 2px; }
    .dropdown-menu.bottom-up:before, .dropdown-menu.bottom-up:after {
      display: none !important; }
  .dropdown-menu > li:first-child:hover > a {
    border-radius: 2px 2px 0px 0px; }
  .dropdown-menu > li:last-child:hover > a {
    border-radius: 0px 0px 2px 2px; }

.dropdown-hover:hover > .dropdown-menu {
  display: block; }

.dropdown > .dropdown-menu.pull-left:before,
.dropdown-toggle > .dropdown-menu.pull-left:before,
.btn-group > .dropdown-menu.pull-left:before {
  left: auto;
  right: 9px; }
.dropdown > .dropdown-menu.pull-left:after,
.dropdown-toggle > .dropdown-menu.pull-left:after,
.btn-group > .dropdown-menu.pull-left:after {
  left: auto;
  right: 10px; }
.dropdown > .dropdown-menu.pull-right:before,
.dropdown-toggle > .dropdown-menu.pull-right:before,
.btn-group > .dropdown-menu.pull-right:before {
  left: auto;
  right: 9px; }
.dropdown > .dropdown-menu.pull-right:after,
.dropdown-toggle > .dropdown-menu.pull-right:after,
.btn-group > .dropdown-menu.pull-right:after {
  left: auto;
  right: 10px; }
.dropdown.dropup > .dropdown-menu,
.dropdown-toggle.dropup > .dropdown-menu,
.btn-group.dropup > .dropdown-menu {
  margin-top: 0px;
  margin-bottom: 10px; }
  .dropdown.dropup > .dropdown-menu:after, .dropdown.dropup > .dropdown-menu:before,
  .dropdown-toggle.dropup > .dropdown-menu:after,
  .dropdown-toggle.dropup > .dropdown-menu:before,
  .btn-group.dropup > .dropdown-menu:after,
  .btn-group.dropup > .dropdown-menu:before {
    display: none !important; }

.dropdown-toggle:after {
  display: none; }

/* Dropdown submenu support for Bootsrap 3 */
.dropdown-submenu {
  position: relative; }
  .dropdown-submenu > .dropdown-menu {
    top: 5px;
    left: 100%;
    margin-top: -6px;
    margin-left: -1px; }
  .dropdown-submenu > a:after {
    position: absolute;
    display: inline-block;
    font-size: 14px;
    right: 7px;
    top: 7px;
    font-family: FontAwesome;
    height: auto;
    content: "\f105";
    font-weight: 300; }
  .dropdown-submenu:hover > .dropdown-menu {
    display: block; }
  .dropdown-submenu:hover > a:after {
    border-left-color: #ffffff; }
  .dropdown-submenu.pull-left {
    float: none; }
    .dropdown-submenu.pull-left > .dropdown-menu {
      left: -100%;
      margin-left: 10px; }
  .dropup .dropdown-submenu > .dropdown-menu {
    top: auto;
    bottom: 0;
    margin-top: 0;
    margin-bottom: -2px; }

.nav.pull-right > li > .dropdown-menu,
.nav > li > .dropdown-menu.pull-right {
  right: 0;
  left: auto; }
  .nav.pull-right > li > .dropdown-menu:before,
  .nav > li > .dropdown-menu.pull-right:before {
    right: 12px;
    left: auto; }
  .nav.pull-right > li > .dropdown-menu:after,
  .nav > li > .dropdown-menu.pull-right:after {
    right: 13px;
    left: auto; }
  .nav.pull-right > li > .dropdown-menu .dropdown-menu,
  .nav > li > .dropdown-menu.pull-right .dropdown-menu {
    right: 100%;
    left: auto;
    margin-right: -1px;
    margin-left: 0; }

@media (max-width: 767px) {
  /* 767px */
  .navbar-nav .open .dropdown-menu {
    position: absolute;
    float: left;
    width: auto;
    margin-top: 0;
    background-color: #ffffff;
    border: 1px solid #efefef;
    box-shadow: 5px 5px rgba(102, 102, 102, 0.1); }
    .navbar-nav .open .dropdown-menu > li > a {
      padding: 6px 0 6px 13px;
      color: #333; }
    .navbar-nav .open .dropdown-menu > li > a:hover,
    .navbar-nav .open .dropdown-menu > li > a:active {
      background-color: #eee; } }
/***
Dropdown Checkboxes
***/
.dropdown-content {
  padding: 10px; }
  .dropdown-content form {
    margin: 0; }

.dropdown.inline .dropdown-menu {
  display: inline-block;
  position: relative; }

.dropdown-radiobuttons,
.dropdown-checkboxes {
  padding: 5px; }
  .dropdown-radiobuttons label,
  .dropdown-checkboxes label {
    display: block;
    font-weight: 300;
    color: #333;
    margin-bottom: 4px;
    margin-top: 4px; }
    .dropdown-radiobuttons label .radio,
    .dropdown-checkboxes label .radio {
      margin-right: 3px; }

/*rtl:ignore*/
.dropdown-menu {
  border: 0 !important;
  border-radius: 2px !important;
  margin: 0; }
  .dropdown-menu:before, .dropdown-menu:after {
    display: none !important; }

.btn-group > .dropdown-menu {
  opacity: 0 ;
  filter: alpha(opacity=0) ;
  margin-top: 0px; }
.btn-group.dropup > .dropdown-menu {
  margin-top: 0px;
  margin-bottom: 0px; }

.btn-group.open > .dropdown-menu {
  transition: opacity 1500ms cubic-bezier(0.23, 1, 0.32, 1) 0.1ms;
  opacity: 1 ;
  filter: alpha(opacity=100) ; }

/*--------------------------------------------------
    [Dropdown Menu v2]
----------------------------------------------------*/
.dropdown-menu-v2 {
  top: 100%;
  right: 0;
  z-index: 1001;
  display: none;
  float: left;
  min-width: 225px;
  padding: 20px 0;
  margin: 25px 0 0;
  font-size: 13px;
  text-align: left;
  list-style: none;
  position: absolute;
  background: #242b31;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  -webkit-background-clip: padding-box;
  background-clip: padding-box;
  transition-duration: 300ms;
  transition-property: all;
  transition-timing-function: cubic-bezier(0.7, 1, 0.7, 1); }
  .dropdown-menu-v2:before {
    top: -10px;
    right: 0;
    width: 0;
    height: 0;
    content: ' ';
    position: absolute;
    border-style: solid;
    display: inline-block;
    border-width: 0 0 15px 15px;
    border-color: transparent transparent #242b31 transparent; }
  .dropdown-menu-v2 > li > a {
    clear: both;
    color: #606e7a;
    display: block;
    font-weight: 600;
    padding: 8px 20px;
    position: relative;
    white-space: nowrap;
    line-height: 1.42857143;
    text-transform: uppercase; }
    .dropdown-menu-v2 > li > a:hover, .dropdown-menu-v2 > li > a:focus {
      background: #21282e;
      text-decoration: none;
      color: #009dc7; }
  .dropdown-menu-v2 .active > a,
  .dropdown-menu-v2 .active > a:hover,
  .dropdown-menu-v2 .active > a:focus,
  .dropdown-menu-v2 .active > a,
  .dropdown-menu-v2 .active > a:hover,
  .dropdown-menu-v2 .active > a:focus,
  .dropdown-menu-v2 .active > a,
  .dropdown-menu-v2 .active > a:hover,
  .dropdown-menu-v2 .active > a:focus {
    outline: 0;
    text-decoration: none;
    background-color: #21282e;
    color: #009dc7; }
  .dropdown-menu-v2 .disabled > a,
  .dropdown-menu-v2 .disabled > a:hover,
  .dropdown-menu-v2 .disabled > a:focus,
  .dropdown-menu-v2 .disabled > a,
  .dropdown-menu-v2 .disabled > a:hover,
  .dropdown-menu-v2 .disabled > a:focus,
  .dropdown-menu-v2 .disabled > a,
  .dropdown-menu-v2 .disabled > a:hover,
  .dropdown-menu-v2 .disabled > a:focus {
    color: #009dc7; }
  .dropdown-menu-v2 .disabled > a:hover,
  .dropdown-menu-v2 .disabled > a:focus,
  .dropdown-menu-v2 .disabled > a:hover,
  .dropdown-menu-v2 .disabled > a:focus {
    text-decoration: none;
    cursor: not-allowed;
    background-color: transparent;
    background-image: none; }
  .dropdown-menu-v2 .divider {
    height: 1px;
    margin: 9px 0;
    overflow: hidden;
    background: #2e353c; }
  .dropdown-menu-v2 .badge {
    top: 8px;
    right: 10px;
    position: absolute; }

.dropdown-menu-v2.pull-right {
  right: 0;
  left: auto; }

.open > .dropdown-menu-v2 {
  display: block; }

.pull-right > .dropdown-menu-v2 {
  right: 0;
  left: auto; }

/***
System feeds
***/
.feeds {
  margin: 0px;
  padding: 0px;
  list-style: none; }
  .feeds li {
    background-color: #fafafa;
    color: #82949a;
    margin-bottom: 7px; }
    .feeds li:before, .feeds li:after {
      display: table;
      line-height: 0;
      content: ""; }
    .feeds li:after {
      clear: both; }
    .feeds li:last-child {
      margin-bottom: 0px; }
    .feeds li .col1 {
      float: left;
      width: 100%;
      clear: both; }
      .feeds li .col1 > .cont {
        float: left;
        margin-right: 75px;
        overflow: hidden; }
        .feeds li .col1 > .cont > .cont-col1 {
          float: left;
          margin-right: -100%; }
          .feeds li .col1 > .cont > .cont-col1 > .label {
            display: inline-block;
            padding: 5px 4px 6px 5px;
            vertical-align: middle;
            text-align: center; }
            .feeds li .col1 > .cont > .cont-col1 > .label > i {
              text-align: center;
              font-size: 14px; }
        .feeds li .col1 > .cont > .cont-col2 {
          float: left;
          width: 100%; }
          .feeds li .col1 > .cont > .cont-col2 > .desc {
            margin-left: 35px;
            padding-top: 4px;
            padding-bottom: 5px;
            overflow: hidden; }
    .feeds li .col2 {
      float: left;
      width: 75px;
      margin-left: -75px; }
      .feeds li .col2 > .date {
        padding: 4px 9px 5px 4px;
        text-align: right;
        font-style: italic;
        color: #c1cbd0; }

/***
Form Layouts
****/
/* Static info */
.static-info {
  margin-bottom: 10px; }
  .static-info .name {
    font-size: 14px; }
  .static-info .value {
    font-size: 14px;
    font-weight: 600; }
  .static-info.align-reverse .name, .static-info.align-reverse .value {
    text-align: right; }

/* Help blocks */
.help-block {
  margin-top: 5px;
  margin-bottom: 5px; }

.help-inline {
  font-size: 13px;
  color: #737373;
  display: inline-block;
  padding: 5px; }

.form-inline input {
  margin-bottom: 0px !important; }

/* Control Label */
.control-label {
  margin-top: 1px;
  font-weight: normal; }

.control-label .required,
.form-group .required {
  color: #e02222;
  font-size: 12px;
  padding-left: 2px; }

.form {
  padding: 0 !important; }

.portlet-form .form-body,
.form .form-body {
  padding: 20px; }
  .portlet.light .portlet-form .form-body, .portlet.light
  .form .form-body {
    padding-left: 0;
    padding-right: 0; }
.portlet-form .form-actions,
.form .form-actions {
  padding: 20px 20px;
  margin: 0;
  background-color: #f5f5f5;
  *zoom: 1; }
  .portlet.light .portlet-form .form-actions, .portlet.light
  .form .form-actions {
    background: none;
    padding-left: 0;
    padding-right: 0; }
  .portlet-form .form-actions.noborder,
  .form .form-actions.noborder {
    border-top: 0; }
  .portlet .portlet-form .form-actions, .portlet
  .form .form-actions {
    -webkit-border-radius: 0 0 2px 2px;
    -moz-border-radius: 0 0 2px 2px;
    -ms-border-radius: 0 0 2px 2px;
    -o-border-radius: 0 0 2px 2px;
    border-radius: 0 0 2px 2px; }
  .portlet-form .form-actions:before, .portlet-form .form-actions:after,
  .form .form-actions:before,
  .form .form-actions:after {
    content: " ";
    display: table; }
  .portlet-form .form-actions:after,
  .form .form-actions:after {
    clear: both; }
  .portlet-form .form-actions.right,
  .form .form-actions.right {
    padding-left: 0;
    padding-right: 20px;
    text-align: right; }
    .portlet.light .portlet-form .form-actions.right, .portlet.light
    .form .form-actions.right {
      padding-right: 0; }
  .portlet-form .form-actions.left,
  .form .form-actions.left {
    padding-left: 20px;
    padding-right: 0;
    text-align: left; }
    .portlet.light .portlet-form .form-actions.left, .portlet.light
    .form .form-actions.left {
      padding-left: 0; }
  .portlet-form .form-actions.nobg,
  .form .form-actions.nobg {
    background-color: transparent; }
  .portlet-form .form-actions.top,
  .form .form-actions.top {
    margin-top: 0;
    margin-bottom: 20px;
    border-top: 0; }
    .portlet.light .portlet-form .form-actions.top, .portlet.light
    .form .form-actions.top {
      background: none; }
  .portlet-form .form-actions .btn-set,
  .form .form-actions .btn-set {
    display: inline-block; }
  @media (max-width: 767px) {
    .portlet-form .form-actions,
    .form .form-actions {
      /* 767px */ }
      .portlet-form .form-actions .btn-set,
      .form .form-actions .btn-set {
        margin-bottom: 3px;
        margin-top: 3px;
        float: left !important; } }
.portlet-form .form-section,
.form .form-section {
  margin: 30px 0px 30px 0px;
  padding-bottom: 5px; }
  .form-fit .portlet-form .form-section, .form-fit
  .form .form-section {
    margin-left: 20px;
    margin-right: 20px; }

/* Checkboxes */
.checkbox,
.form-horizontal .checkbox {
  padding: 0; }
  .checkbox > label,
  .form-horizontal .checkbox > label {
    padding-left: 0; }

.checkbox-list > label {
  display: block; }
  .checkbox-list > label.checkbox-inline {
    display: inline-block; }
    .checkbox-list > label.checkbox-inline:first-child {
      padding-left: 0; }

/* Radio buttons */
.radio-list > label {
  display: block; }
  .radio-list > label.radio-inline {
    display: inline-block; }
    .radio-list > label.radio-inline:first-child {
      padding-left: 0; }

/* Radio buttons in horizontal forms */
.form-horizontal .radio-list .radio {
  padding-top: 1px; }
.form-horizontal .radio-list > label {
  margin-bottom: 0; }
.form-horizontal .radio > span {
  margin-top: 2px; }

/* Rows seperated form layout */
.form .form-row-seperated .portlet-body {
  padding: 0; }
.form .form-row-seperated .form-group {
  margin: 0;
  border-bottom: 1px solid #efefef;
  padding: 15px 0; }
  .form .form-row-seperated .form-group.last {
    border-bottom: 0;
    margin-bottom: 0;
    padding-bottom: 13px; }
  .form .form-row-seperated .form-group .help-block {
    margin-bottom: 0; }
.form .form-row-seperated .form-body {
  padding: 0; }
.form .form-row-seperated .form-actions {
  padding-left: 15px !important;
  padding-right: 15px !important; }

/* Form bordered */
.form .form-bordered .form-group {
  margin: 0;
  border-bottom: 1px solid #efefef; }
  .form .form-bordered .form-group > div {
    padding: 15px;
    border-left: 1px solid #efefef; }
    @media (max-width: 991px) {
      .form .form-bordered .form-group > div {
        /* 991px */
        border-left: 0; } }
  .form .form-bordered .form-group.last {
    border-bottom: 0; }
  .form .form-bordered .form-group .control-label {
    padding-top: 20px; }
    @media (max-width: 991px) {
      .form .form-bordered .form-group .control-label {
        /* 991px */
        padding-top: 10px; } }
  .form .form-bordered .form-group .help-block {
    margin-bottom: 0; }
  .form .form-bordered .form-group .form-control {
    margin: 0; }
.form .form-bordered .form-body {
  margin: 0;
  padding: 0; }
.form .form-bordered .form-actions {
  margin-top: 0;
  padding-left: 16px !important;
  padding-right: 16px !important; }
  @media (max-width: 991px) {
    .form .form-bordered .form-actions {
      /* 991px */
      padding-left: 15px !important;
      padding-right: 15px !important; } }

/* Horizontal bordered form */
.form .form-horizontal.form-bordered.form-row-stripped .form-group:nth-child(even) {
  background-color: #fcfcfc; }
.form .form-horizontal.form-bordered.form-row-stripped .form-control {
  background: #fff !important; }
.form .form-horizontal.form-bordered.form-label-stripped .form-group:nth-child(even) {
  background-color: #fcfcfc; }
  .form .form-horizontal.form-bordered.form-label-stripped .form-group:nth-child(even) > div {
    background-color: #ffffff; }
.form .form-horizontal.form-bordered.form-label-stripped .form-group:nth-child(even) {
  background-color: #fcfcfc; }

/* Horizontal form small input issue */
.form-horizontal .form-group .input-sm {
  margin-top: 3px; }
.form-horizontal .form-group .form-control-static {
  margin-top: 1px; }

/***
Form Repeater
****/
.mt-repeater {
  display: table;
  width: 100%; }
  .mt-repeater .mt-repeater-item {
    border-bottom: 1px solid #ddd;
    padding-bottom: 15px;
    margin-bottom: 15px; }
    .mt-repeater .mt-repeater-item.mt-overflow {
      overflow: auto; }
  .mt-repeater .mt-repeater-title {
    font-size: 18px;
    text-transform: uppercase;
    margin-top: 0;
    font-weight: 600; }
  .mt-repeater .mt-repeater-input {
    display: table-cell;
    vertical-align: top;
    padding: 0 10px 10px 10px;
    width: 1%; }
    .mt-repeater .mt-repeater-input input[type="text"], .mt-repeater .mt-repeater-input textarea, .mt-repeater .mt-repeater-input select {
      width: 100%; }
    .mt-repeater .mt-repeater-input .control-label {
      padding-top: 0;
      margin-bottom: 5px; }
    .mt-repeater .mt-repeater-input.mt-repeater-textarea {
      width: 3%; }
    .mt-repeater .mt-repeater-input:first-child {
      padding-left: 0; }
    .mt-repeater .mt-repeater-input:last-child {
      padding-right: 0; }
  .mt-repeater .mt-repeater-delete {
    margin-top: 1.8em; }
    .mt-repeater .mt-repeater-delete.mt-repeater-del-right {
      float: right;
      margin-top: 10px; }
  .mt-repeater .mt-repeater-cell {
    display: table;
    width: 100%; }
    .mt-repeater .mt-repeater-cell .mt-repeater-input-inline,
    .mt-repeater .mt-repeater-cell .mt-repeater-btn-inline {
      display: table-cell; }
    .mt-repeater .mt-repeater-cell .mt-repeater-input-inline {
      width: 100%;
      border-right: none; }
    .mt-repeater .mt-repeater-cell .mt-repeater-btn-inline {
      width: 1%;
      float: none; }
  .mt-repeater .mt-repeater-row {
    margin-right: 0; }

@media (max-width: 991px) {
  .mt-repeater .mt-repeater-input {
    width: 100%;
    display: block;
    padding-left: 0;
    padding-right: 0; }
    .mt-repeater .mt-repeater-input.mt-repeater-textarea {
      width: 100%; }
    .mt-repeater .mt-repeater-input .control-label {
      text-align: left !important; }
    .mt-repeater .mt-repeater-input .mt-repeater-delete {
      margin-top: 0; } }
/***
Forms
***/
.form-control {
  outline: none !important;
  box-shadow: none !important; }
  .form-control.height-auto {
    height: auto; }

.input-group-addon > i {
  color: #c5cdda; }

/***
Custom color buttons 
***/
.form-control.white {
  border-color: #ffffff; }
  .form-control.white:focus {
    border-color: #e6e6e6; }

.form-control.focus-white:focus {
  border-color: #ffffff; }

.form-control.default {
  border-color: #e1e5ec; }
  .form-control.default:focus {
    border-color: #c2cad8; }

.form-control.focus-default:focus {
  border-color: #e1e5ec; }

.form-control.dark {
  border-color: #2f353b; }
  .form-control.dark:focus {
    border-color: #181c1f; }

.form-control.focus-dark:focus {
  border-color: #2f353b; }

.form-control.blue {
  border-color: #3598dc; }
  .form-control.blue:focus {
    border-color: #217ebd; }

.form-control.focus-blue:focus {
  border-color: #3598dc; }

.form-control.blue-madison {
  border-color: #578ebe; }
  .form-control.blue-madison:focus {
    border-color: #3f74a3; }

.form-control.focus-blue-madison:focus {
  border-color: #578ebe; }

.form-control.blue-chambray {
  border-color: #2C3E50; }
  .form-control.blue-chambray:focus {
    border-color: #1a252f; }

.form-control.focus-blue-chambray:focus {
  border-color: #2C3E50; }

.form-control.blue-ebonyclay {
  border-color: #22313F; }
  .form-control.blue-ebonyclay:focus {
    border-color: #10171e; }

.form-control.focus-blue-ebonyclay:focus {
  border-color: #22313F; }

.form-control.blue-hoki {
  border-color: #67809F; }
  .form-control.blue-hoki:focus {
    border-color: #526781; }

.form-control.focus-blue-hoki:focus {
  border-color: #67809F; }

.form-control.blue-steel {
  border-color: #4B77BE; }
  .form-control.blue-steel:focus {
    border-color: #395f9d; }

.form-control.focus-blue-steel:focus {
  border-color: #4B77BE; }

.form-control.blue-soft {
  border-color: #4c87b9; }
  .form-control.blue-soft:focus {
    border-color: #3b6d97; }

.form-control.focus-blue-soft:focus {
  border-color: #4c87b9; }

.form-control.blue-dark {
  border-color: #5e738b; }
  .form-control.blue-dark:focus {
    border-color: #495a6d; }

.form-control.focus-blue-dark:focus {
  border-color: #5e738b; }

.form-control.blue-sharp {
  border-color: #5C9BD1; }
  .form-control.blue-sharp:focus {
    border-color: #3782c3; }

.form-control.focus-blue-sharp:focus {
  border-color: #5C9BD1; }

.form-control.blue-oleo {
  border-color: #94A0B2; }
  .form-control.blue-oleo:focus {
    border-color: #76869d; }

.form-control.focus-blue-oleo:focus {
  border-color: #94A0B2; }

.form-control.green {
  border-color: #32c5d2; }
  .form-control.green:focus {
    border-color: #26a1ab; }

.form-control.focus-green:focus {
  border-color: #32c5d2; }

.form-control.green-meadow {
  border-color: #1BBC9B; }
  .form-control.green-meadow:focus {
    border-color: #158f76; }

.form-control.focus-green-meadow:focus {
  border-color: #1BBC9B; }

.form-control.green-seagreen {
  border-color: #1BA39C; }
  .form-control.green-seagreen:focus {
    border-color: #147772; }

.form-control.focus-green-seagreen:focus {
  border-color: #1BA39C; }

.form-control.green-turquoise {
  border-color: #36D7B7; }
  .form-control.green-turquoise:focus {
    border-color: #24b699; }

.form-control.focus-green-turquoise:focus {
  border-color: #36D7B7; }

.form-control.green-haze {
  border-color: #44b6ae; }
  .form-control.green-haze:focus {
    border-color: #36918b; }

.form-control.focus-green-haze:focus {
  border-color: #44b6ae; }

.form-control.green-jungle {
  border-color: #26C281; }
  .form-control.green-jungle:focus {
    border-color: #1e9765; }

.form-control.focus-green-jungle:focus {
  border-color: #26C281; }

.form-control.green-soft {
  border-color: #3faba4; }
  .form-control.green-soft:focus {
    border-color: #318680; }

.form-control.focus-green-soft:focus {
  border-color: #3faba4; }

.form-control.green-dark {
  border-color: #4DB3A2; }
  .form-control.green-dark:focus {
    border-color: #3d9082; }

.form-control.focus-green-dark:focus {
  border-color: #4DB3A2; }

.form-control.green-sharp {
  border-color: #2ab4c0; }
  .form-control.green-sharp:focus {
    border-color: #218d96; }

.form-control.focus-green-sharp:focus {
  border-color: #2ab4c0; }

.form-control.green-steel {
  border-color: #29b4b6; }
  .form-control.green-steel:focus {
    border-color: #208b8c; }

.form-control.focus-green-steel:focus {
  border-color: #29b4b6; }

.form-control.grey {
  border-color: #E5E5E5; }
  .form-control.grey:focus {
    border-color: #cccccc; }

.form-control.focus-grey:focus {
  border-color: #E5E5E5; }

.form-control.grey-steel {
  border-color: #e9edef; }
  .form-control.grey-steel:focus {
    border-color: #cbd5da; }

.form-control.focus-grey-steel:focus {
  border-color: #e9edef; }

.form-control.grey-cararra {
  border-color: #fafafa; }
  .form-control.grey-cararra:focus {
    border-color: #e1e1e1; }

.form-control.focus-grey-cararra:focus {
  border-color: #fafafa; }

.form-control.grey-gallery {
  border-color: #555555; }
  .form-control.grey-gallery:focus {
    border-color: #3c3c3c; }

.form-control.focus-grey-gallery:focus {
  border-color: #555555; }

.form-control.grey-cascade {
  border-color: #95A5A6; }
  .form-control.grey-cascade:focus {
    border-color: #798d8f; }

.form-control.focus-grey-cascade:focus {
  border-color: #95A5A6; }

.form-control.grey-silver {
  border-color: #BFBFBF; }
  .form-control.grey-silver:focus {
    border-color: #a6a6a6; }

.form-control.focus-grey-silver:focus {
  border-color: #BFBFBF; }

.form-control.grey-salsa {
  border-color: #ACB5C3; }
  .form-control.grey-salsa:focus {
    border-color: #8e9bae; }

.form-control.focus-grey-salsa:focus {
  border-color: #ACB5C3; }

.form-control.grey-salt {
  border-color: #bfcad1; }
  .form-control.grey-salt:focus {
    border-color: #a1b1bc; }

.form-control.focus-grey-salt:focus {
  border-color: #bfcad1; }

.form-control.grey-mint {
  border-color: #525e64; }
  .form-control.grey-mint:focus {
    border-color: #3b4448; }

.form-control.focus-grey-mint:focus {
  border-color: #525e64; }

.form-control.red {
  border-color: #e7505a; }
  .form-control.red:focus {
    border-color: #e12330; }

.form-control.focus-red:focus {
  border-color: #e7505a; }

.form-control.red-pink {
  border-color: #E08283; }
  .form-control.red-pink:focus {
    border-color: #d6595a; }

.form-control.focus-red-pink:focus {
  border-color: #E08283; }

.form-control.red-sunglo {
  border-color: #E26A6A; }
  .form-control.red-sunglo:focus {
    border-color: #da3f3f; }

.form-control.focus-red-sunglo:focus {
  border-color: #E26A6A; }

.form-control.red-intense {
  border-color: #e35b5a; }
  .form-control.red-intense:focus {
    border-color: #dc302e; }

.form-control.focus-red-intense:focus {
  border-color: #e35b5a; }

.form-control.red-thunderbird {
  border-color: #D91E18; }
  .form-control.red-thunderbird:focus {
    border-color: #ab1813; }

.form-control.focus-red-thunderbird:focus {
  border-color: #D91E18; }

.form-control.red-flamingo {
  border-color: #EF4836; }
  .form-control.red-flamingo:focus {
    border-color: #e02612; }

.form-control.focus-red-flamingo:focus {
  border-color: #EF4836; }

.form-control.red-soft {
  border-color: #d05454; }
  .form-control.red-soft:focus {
    border-color: #bd3434; }

.form-control.focus-red-soft:focus {
  border-color: #d05454; }

.form-control.red-haze {
  border-color: #f36a5a; }
  .form-control.red-haze:focus {
    border-color: #f03f2a; }

.form-control.focus-red-haze:focus {
  border-color: #f36a5a; }

.form-control.red-mint {
  border-color: #e43a45; }
  .form-control.red-mint:focus {
    border-color: #cf1c28; }

.form-control.focus-red-mint:focus {
  border-color: #e43a45; }

.form-control.yellow {
  border-color: #c49f47; }
  .form-control.yellow:focus {
    border-color: #a48334; }

.form-control.focus-yellow:focus {
  border-color: #c49f47; }

.form-control.yellow-gold {
  border-color: #E87E04; }
  .form-control.yellow-gold:focus {
    border-color: #b66303; }

.form-control.focus-yellow-gold:focus {
  border-color: #E87E04; }

.form-control.yellow-casablanca {
  border-color: #f2784b; }
  .form-control.yellow-casablanca:focus {
    border-color: #ef541b; }

.form-control.focus-yellow-casablanca:focus {
  border-color: #f2784b; }

.form-control.yellow-crusta {
  border-color: #f3c200; }
  .form-control.yellow-crusta:focus {
    border-color: #c09900; }

.form-control.focus-yellow-crusta:focus {
  border-color: #f3c200; }

.form-control.yellow-lemon {
  border-color: #F7CA18; }
  .form-control.yellow-lemon:focus {
    border-color: #d5ab07; }

.form-control.focus-yellow-lemon:focus {
  border-color: #F7CA18; }

.form-control.yellow-saffron {
  border-color: #F4D03F; }
  .form-control.yellow-saffron:focus {
    border-color: #f1c40f; }

.form-control.focus-yellow-saffron:focus {
  border-color: #F4D03F; }

.form-control.yellow-soft {
  border-color: #c8d046; }
  .form-control.yellow-soft:focus {
    border-color: #adb52e; }

.form-control.focus-yellow-soft:focus {
  border-color: #c8d046; }

.form-control.yellow-haze {
  border-color: #c5bf66; }
  .form-control.yellow-haze:focus {
    border-color: #b4ad44; }

.form-control.focus-yellow-haze:focus {
  border-color: #c5bf66; }

.form-control.yellow-mint {
  border-color: #c5b96b; }
  .form-control.yellow-mint:focus {
    border-color: #b6a747; }

.form-control.focus-yellow-mint:focus {
  border-color: #c5b96b; }

.form-control.purple {
  border-color: #8E44AD; }
  .form-control.purple:focus {
    border-color: #703688; }

.form-control.focus-purple:focus {
  border-color: #8E44AD; }

.form-control.purple-plum {
  border-color: #8775a7; }
  .form-control.purple-plum:focus {
    border-color: #6d5b8e; }

.form-control.focus-purple-plum:focus {
  border-color: #8775a7; }

.form-control.purple-medium {
  border-color: #BF55EC; }
  .form-control.purple-medium:focus {
    border-color: #ae27e7; }

.form-control.focus-purple-medium:focus {
  border-color: #BF55EC; }

.form-control.purple-studio {
  border-color: #8E44AD; }
  .form-control.purple-studio:focus {
    border-color: #703688; }

.form-control.focus-purple-studio:focus {
  border-color: #8E44AD; }

.form-control.purple-wisteria {
  border-color: #9B59B6; }
  .form-control.purple-wisteria:focus {
    border-color: #804399; }

.form-control.focus-purple-wisteria:focus {
  border-color: #9B59B6; }

.form-control.purple-seance {
  border-color: #9A12B3; }
  .form-control.purple-seance:focus {
    border-color: #720d85; }

.form-control.focus-purple-seance:focus {
  border-color: #9A12B3; }

.form-control.purple-intense {
  border-color: #8775a7; }
  .form-control.purple-intense:focus {
    border-color: #6d5b8e; }

.form-control.focus-purple-intense:focus {
  border-color: #8775a7; }

.form-control.purple-sharp {
  border-color: #796799; }
  .form-control.purple-sharp:focus {
    border-color: #61527b; }

.form-control.focus-purple-sharp:focus {
  border-color: #796799; }

.form-control.purple-soft {
  border-color: #8877a9; }
  .form-control.purple-soft:focus {
    border-color: #6e5c91; }

.form-control.focus-purple-soft:focus {
  border-color: #8877a9; }

.input-xxs {
  width: 45px !important; }

/* Form uneditable input */
.uneditable-input {
  padding: 6px 12px;
  min-width: 206px;
  font-size: 14px;
  font-weight: normal;
  height: 34px;
  color: #555555;
  background-color: #fff;
  border: 1px solid #c2cad8;
  -webkit-box-shadow: none;
  box-shadow: none;
  -webkit-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
  transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s; }

.form-control-static {
  display: inline-block;
  margin: 0; }

/* Form input sizing */
.input-mini {
  width: 45px !important; }

.input-xsmall {
  width: 80px !important; }

.input-small {
  width: 145px !important; }

.input-medium {
  width: 240px !important; }

.input-large {
  width: 320px !important; }

.input-xlarge {
  width: 420px !important; }

@media (max-width: 768px) {
  /* 768px */
  .input-large {
    width: 250px !important; }

  .input-xlarge {
    width: 300px !important; } }
.input-inline {
  display: inline-block;
  width: auto;
  vertical-align: middle; }

.input-fixed {
  overflow: hidden; }

.input-fixed {
  overflow: hidden; }

.form-group .input-inline {
  margin-right: 5px; }

@media (max-width: 768px) {
  /* 768px */
  .input-lg {
    width: 250px !important; }

  .input-xlg {
    width: 300px !important; } }
/* Circle Inputs */
.input-circle {
  border-radius: 25px !important; }

.input-circle-right {
  border-radius: 0 25px 25px 0 !important; }

.input-circle-left {
  border-radius: 25px 0 0 25px !important; }

.input-circle-bottom {
  border-radius: 0 0 25px 25px !important; }

.input-circle-top {
  border-radius: 25px 25px 0 0 !important; }

.input-group-btn .btn {
  box-shadow: none; }

.mt-radio,
.mt-checkbox {
  display: inline-block;
  position: relative;
  padding-left: 30px;
  margin-bottom: 15px;
  cursor: pointer;
  font-size: 14px;
  webkit-transition: all 0.3s;
  -moz-transition: all 0.3s;
  -ms-transition: all 0.3s;
  -o-transition: all 0.3s;
  transition: all 0.3s; }
  .mt-radio.mt-radio-disabled, .mt-radio.mt-checkbox-disabled,
  .mt-checkbox.mt-radio-disabled,
  .mt-checkbox.mt-checkbox-disabled {
    opacity: 0.8 ;
    filter: alpha(opacity=80) ;
    cursor: not-allowed; }
  .mt-radio > input,
  .mt-checkbox > input {
    position: absolute;
    z-index: -1;
    opacity: 0 ;
    filter: alpha(opacity=0) ; }
  .mt-radio > span,
  .mt-checkbox > span {
    border: 1px solid transparent;
    position: absolute;
    top: 1px;
    left: 0;
    height: 18px;
    width: 18px;
    background: #E6E6E6; }
    .mt-radio > span:after,
    .mt-checkbox > span:after {
      content: '';
      position: absolute;
      display: none; }
  .mt-radio:hover > input:not([disabled]) ~ span,
  .mt-radio > input:focus ~ span,
  .mt-checkbox:hover > input:not([disabled]) ~ span,
  .mt-checkbox > input:focus ~ span {
    background: #d9d9d9;
    webkit-transition: all 0.3s;
    -moz-transition: all 0.3s;
    -ms-transition: all 0.3s;
    -o-transition: all 0.3s;
    transition: all 0.3s; }
  .mt-radio > input:checked ~ span,
  .mt-checkbox > input:checked ~ span {
    webkit-transition: all 0.3s;
    -moz-transition: all 0.3s;
    -ms-transition: all 0.3s;
    -o-transition: all 0.3s;
    transition: all 0.3s;
    background: #d9d9d9; }
    .mt-radio > input:checked ~ span:after,
    .mt-checkbox > input:checked ~ span:after {
      display: block; }
  .mt-radio:hover > input:not([disabled]):checked ~ span,
  .mt-radio > input:checked ~ span,
  .mt-checkbox:hover > input:not([disabled]):checked ~ span,
  .mt-checkbox > input:checked ~ span {
    webkit-transition: all 0.3s;
    -moz-transition: all 0.3s;
    -ms-transition: all 0.3s;
    -o-transition: all 0.3s;
    transition: all 0.3s;
    background: #d9d9d9; }
  .mt-radio > input:disabled ~ span,
  .mt-checkbox > input:disabled ~ span {
    opacity: 0.6 ;
    filter: alpha(opacity=60) ;
    pointer-events: none; }
  .mt-radio.mt-radio-outline > span, .mt-radio.mt-checkbox-outline > span,
  .mt-checkbox.mt-radio-outline > span,
  .mt-checkbox.mt-checkbox-outline > span {
    border: 1px solid #d9d9d9;
    background: none; }
  .mt-radio.mt-radio-outline:hover > input:not([disabled]) ~ span,
  .mt-radio.mt-radio-outline > input:focus ~ span, .mt-radio.mt-checkbox-outline:hover > input:not([disabled]) ~ span,
  .mt-radio.mt-checkbox-outline > input:focus ~ span,
  .mt-checkbox.mt-radio-outline:hover > input:not([disabled]) ~ span,
  .mt-checkbox.mt-radio-outline > input:focus ~ span,
  .mt-checkbox.mt-checkbox-outline:hover > input:not([disabled]) ~ span,
  .mt-checkbox.mt-checkbox-outline > input:focus ~ span {
    border: 1px solid #d9d9d9;
    background: none; }
  .mt-radio.mt-radio-outline > input:checked ~ span, .mt-radio.mt-checkbox-outline > input:checked ~ span,
  .mt-checkbox.mt-radio-outline > input:checked ~ span,
  .mt-checkbox.mt-checkbox-outline > input:checked ~ span {
    border: 1px solid #d9d9d9;
    background: none; }
  .mt-radio.mt-radio-outline:hover > input:not([disabled]):checked ~ span,
  .mt-radio.mt-radio-outline > input:checked ~ span, .mt-radio.mt-checkbox-outline:hover > input:not([disabled]):checked ~ span,
  .mt-radio.mt-checkbox-outline > input:checked ~ span,
  .mt-checkbox.mt-radio-outline:hover > input:not([disabled]):checked ~ span,
  .mt-checkbox.mt-radio-outline > input:checked ~ span,
  .mt-checkbox.mt-checkbox-outline:hover > input:not([disabled]):checked ~ span,
  .mt-checkbox.mt-checkbox-outline > input:checked ~ span {
    border: 1px solid #d9d9d9;
    background: none; }

.mt-radio > span {
  -webkit-border-radius: 50%!important;
  -moz-border-radius: 50%!important;
  -ms-border-radius: 50%!important;
  -o-border-radius: 50%!important;
  border-radius: 50%!important; }
  .mt-radio > span:after {
    left: 5px;
    top: 5px;
    height: 6px;
    width: 6px;
    border-radius: 100% !important;
    background: #888888; }
.mt-radio > input:disabled ~ span:after {
  background: #888888; }
th > .mt-radio.mt-radio-single, td > .mt-radio.mt-radio-single {
  right: -5px; }

.mt-checkbox > span:after {
  left: 6px;
  top: 2px;
  width: 5px;
  height: 10px;
  border: solid #888888;
  border-width: 0 2px 2px 0;
  transform: rotate(45deg); }
.mt-checkbox > input:disabled ~ span:after {
  border-color: #888888; }
.form-inline .mt-checkbox {
  margin-left: 15px;
  margin-right: 15px; }
th > .mt-checkbox.mt-checkbox-single, td > .mt-checkbox.mt-checkbox-single {
  right: -5px; }

.mt-checkbox-list,
.mt-radio-list {
  padding: 10px 0; }
  .form-horizontal .form-group .mt-checkbox-list, .form-horizontal .form-group
  .mt-radio-list {
    padding-top: 0; }
  .mt-checkbox-list .mt-checkbox,
  .mt-checkbox-list .mt-radio,
  .mt-radio-list .mt-checkbox,
  .mt-radio-list .mt-radio {
    display: block; }

.mt-checkbox-inline,
.mt-radio-inline {
  padding: 10px 0; }
  .form-horizontal .form-group .mt-checkbox-inline, .form-horizontal .form-group
  .mt-radio-inline {
    padding-top: 8px; }
  .mt-checkbox-inline .mt-checkbox,
  .mt-checkbox-inline .mt-radio,
  .mt-radio-inline .mt-checkbox,
  .mt-radio-inline .mt-radio {
    display: inline-block;
    margin-right: 15px; }
    .mt-checkbox-inline .mt-checkbox:last-child,
    .mt-checkbox-inline .mt-radio:last-child,
    .mt-radio-inline .mt-checkbox:last-child,
    .mt-radio-inline .mt-radio:last-child {
      margin-right: 0; }

/***
Custom icon buttons
***/
.icon-btn {
  height: 60px;
  min-width: 80px;
  margin: 5px 5px 0 0;
  border: 1px solid #ddd;
  padding: 12px 0px 0px 0px;
  background-color: #fafafa;
  background-image: none;
  filter: none;
  display: inline-block;
  color: #646464;
  text-shadow: none;
  text-align: center;
  cursor: pointer;
  position: relative;
  -webkit-transition: all 0.3s ease;
  -moz-transition: all 0.3s ease;
  -ms-transition: all 0.3s ease;
  -o-transition: all 0.3s ease;
  transition: all 0.3s ease; }
  .icon-btn:hover {
    text-decoration: none;
    border-color: #999;
    color: #444;
    text-shadow: 0 1px 0px white;
    -webkit-transition: all 0.3s ease;
    -moz-transition: all 0.3s ease;
    -ms-transition: all 0.3s ease;
    -o-transition: all 0.3s ease;
    transition: all 0.3s ease; }
    .icon-btn:hover > .badge {
      -webkit-transition: all 0.3s ease;
      -moz-transition: all 0.3s ease;
      -ms-transition: all 0.3s ease;
      -o-transition: all 0.3s ease;
      transition: all 0.3s ease; }
  .icon-btn > div {
    margin-top: 5px;
    margin-bottom: 20px;
    color: #3f444a;
    font-size: 12px;
    font-weight: 300; }
  .icon-btn > .badge {
    position: absolute;
    font-size: 11px;
    font-weight: 300;
    top: -5px;
    right: -5px;
    padding: 3px 6px 3px 6px;
    color: white;
    text-shadow: none;
    border-width: 0;
    border-style: solid;
    -webkit-border-radius: 12px;
    -moz-border-radius: 12px;
    border-radius: 12px; }
  .icon-btn > i {
    font-size: 18px; }
  .ie8 .icon-btn:hover {
    filter: none; }

.icon-btn {
  border: 0;
  transition: box-shadow 0.28s cubic-bezier(0.4, 0, 0.2, 1); }
  .icon-btn > div {
    text-transform: uppercase;
    font-weight: 600;
    font-size: 11px;
    color: #565d66; }
  .icon-btn:hover {
    text-decoration: none; }

/***
Input icons
***/
.input-icon {
  position: relative;
  left: 0; }
  .input-icon > .form-control {
    padding-left: 33px; }
    .input-group .input-icon > .form-control {
      -webkit-border-radius: 2px 0 0 2px;
      -moz-border-radius: 2px 0 0 2px;
      -ms-border-radius: 2px 0 0 2px;
      -o-border-radius: 2px 0 0 2px;
      border-radius: 2px 0 0 2px; }
  .input-icon > i {
    color: #ccc;
    display: block;
    position: absolute;
    margin: 11px 2px 4px 10px;
    z-index: 3;
    width: 16px;
    font-size: 16px;
    text-align: center;
    left: 0; }
    .modal .input-icon > i {
      z-index: 10055; }
    .has-success .input-icon > i {
      color: #36c6d3; }
    .has-warning .input-icon > i {
      color: #F1C40F; }
    .has-info .input-icon > i {
      color: #659be0; }
    .has-error .input-icon > i {
      color: #ed6b75; }
  .input-icon.right {
    left: auto;
    right: 0; }
    .input-icon.right > .form-control {
      padding-right: 33px;
      padding-left: 12px; }
      .input-group .input-icon.right > .form-control {
        -webkit-border-radius: 0 2px 2px 0;
        -moz-border-radius: 0 2px 2px 0;
        -ms-border-radius: 0 2px 2px 0;
        -o-border-radius: 0 2px 2px 0;
        border-radius: 0 2px 2px 0; }
    .input-icon.right > i {
      left: auto;
      right: 8px;
      float: right; }
  .input-icon.input-icon-lg > i {
    margin-top: 16px; }
  .input-icon.input-icon-sm > i {
    margin-top: 8px;
    font-size: 13px; }

/***
Customized Bootstrap Labels
***/
.label {
  text-shadow: none !important;
  font-size: 14px;
  font-weight: 300;
  padding: 3px 6px 3px 6px;
  color: #fff;
  font-family: "Roboto", sans-serif; }
  .label.label-sm {
    font-size: 13px;
    padding: 2px 5px 2px 5px; }
  h1 .label, h2 .label, h3 .label, h4 .label, h5 .label, h6 .label {
    font-size: 75%; }

/* Labels variants */
.label-default {
  background-color: #bac3d0; }
  .label-default[href]:hover, .label-default[href]:focus {
    background-color: #9ca8bb; }

.label-primary {
  background-color: #17b8b6; }
  .label-primary[href]:hover, .label-primary[href]:focus {
    background-color: #118a89; }

.label-success {
  background-color: #36c6d3; }
  .label-success[href]:hover, .label-success[href]:focus {
    background-color: #27a4b0; }

.label-info {
  background-color: #659be0; }
  .label-info[href]:hover, .label-info[href]:focus {
    background-color: #3a80d7; }

.label-warning {
  background-color: #F1C40F; }
  .label-warning[href]:hover, .label-warning[href]:focus {
    background-color: #c29d0b; }

.label-danger {
  background-color: #ed6b75; }
  .label-danger[href]:hover, .label-danger[href]:focus {
    background-color: #e73d4a; }

/***
Iconic labels
***/
.label.label-icon {
  padding: 4px 0px 4px 4px;
  margin-right: 2px;
  text-align: center !important; }
  .label.label-icon > i {
    font-size: 12px;
    text-align: center !important; }
  .ie8 .label.label-icon, .ie9 .label.label-icon {
    padding: 3px 0px 3px 3px; }

/***
Text states
***/
.text-default {
  color: #bac3d0; }

.text-primary {
  color: #17b8b6; }

.text-success {
  color: #36c6d3; }

.text-info {
  color: #659be0; }

.text-warning {
  color: #F1C40F; }

.text-danger {
  color: #ed6b75; }

.label:not(.md-skip) {
  text-transform: uppercase;
  padding: 2px 6px 4px 6px;
  font-size: 10px;
  font-weight: 600; }
  .label:not(.md-skip).label-sm {
    font-size: 10px;
    font-weight: 600;
    padding: 3px 6px 3px 6px; }

.label:not(.md-skip).label-icon {
  padding: 4px 0px 4px 4px !important;
  font-size: 12px !important; }
  .ie8 .label:not(.md-skip).label-icon, .ie9 .label:not(.md-skip).label-icon {
    padding: 3px 0 3px 3px !important; }

/***
Customized List Group
***/
/* Contextual variants */
.list-group > li:first-child {
  border-radius-topleft: 2px;
  border-radius-topright: 2px; }
.list-group > li:last-child {
  border-radius-bottomleft: 2px;
  border-radius-bottomright: 2px; }

.list-group .list-group-item-success {
  color: #27a4b0;
  background-color: #abe7ed; }
.list-group a.list-group-item-success,
.list-group button.list-group-item-success {
  color: #27a4b0; }
  .list-group a.list-group-item-success .list-group-item-heading,
  .list-group button.list-group-item-success .list-group-item-heading {
    color: inherit; }
  .list-group a.list-group-item-success:hover, .list-group a.list-group-item-success:focus,
  .list-group button.list-group-item-success:hover,
  .list-group button.list-group-item-success:focus {
    color: #27a4b0;
    background-color: #96e1e8; }
  .list-group a.list-group-item-success.active, .list-group a.list-group-item-success.active:hover, .list-group a.list-group-item-success.active:focus,
  .list-group button.list-group-item-success.active,
  .list-group button.list-group-item-success.active:hover,
  .list-group button.list-group-item-success.active:focus {
    color: #fff;
    background-color: #27a4b0;
    border-color: #27a4b0; }

.list-group .list-group-item-info {
  color: #327ad5;
  background-color: #e0ebf9; }
.list-group a.list-group-item-info,
.list-group button.list-group-item-info {
  color: #327ad5; }
  .list-group a.list-group-item-info .list-group-item-heading,
  .list-group button.list-group-item-info .list-group-item-heading {
    color: inherit; }
  .list-group a.list-group-item-info:hover, .list-group a.list-group-item-info:focus,
  .list-group button.list-group-item-info:hover,
  .list-group button.list-group-item-info:focus {
    color: #327ad5;
    background-color: #caddf4; }
  .list-group a.list-group-item-info.active, .list-group a.list-group-item-info.active:hover, .list-group a.list-group-item-info.active:focus,
  .list-group button.list-group-item-info.active,
  .list-group button.list-group-item-info.active:hover,
  .list-group button.list-group-item-info.active:focus {
    color: #fff;
    background-color: #327ad5;
    border-color: #327ad5; }

.list-group .list-group-item-warning {
  color: #c29d0b;
  background-color: #f9e491; }
.list-group a.list-group-item-warning,
.list-group button.list-group-item-warning {
  color: #c29d0b; }
  .list-group a.list-group-item-warning .list-group-item-heading,
  .list-group button.list-group-item-warning .list-group-item-heading {
    color: inherit; }
  .list-group a.list-group-item-warning:hover, .list-group a.list-group-item-warning:focus,
  .list-group button.list-group-item-warning:hover,
  .list-group button.list-group-item-warning:focus {
    color: #c29d0b;
    background-color: #f7de79; }
  .list-group a.list-group-item-warning.active, .list-group a.list-group-item-warning.active:hover, .list-group a.list-group-item-warning.active:focus,
  .list-group button.list-group-item-warning.active,
  .list-group button.list-group-item-warning.active:hover,
  .list-group button.list-group-item-warning.active:focus {
    color: #fff;
    background-color: #c29d0b;
    border-color: #c29d0b; }

.list-group .list-group-item-danger {
  color: #e73d4a;
  background-color: #fbe1e3; }
.list-group a.list-group-item-danger,
.list-group button.list-group-item-danger {
  color: #e73d4a; }
  .list-group a.list-group-item-danger .list-group-item-heading,
  .list-group button.list-group-item-danger .list-group-item-heading {
    color: inherit; }
  .list-group a.list-group-item-danger:hover, .list-group a.list-group-item-danger:focus,
  .list-group button.list-group-item-danger:hover,
  .list-group button.list-group-item-danger:focus {
    color: #e73d4a;
    background-color: #f8cace; }
  .list-group a.list-group-item-danger.active, .list-group a.list-group-item-danger.active:hover, .list-group a.list-group-item-danger.active:focus,
  .list-group button.list-group-item-danger.active,
  .list-group button.list-group-item-danger.active:hover,
  .list-group button.list-group-item-danger.active:focus {
    color: #fff;
    background-color: #e73d4a;
    border-color: #e73d4a; }

/***
UI Loading
***/
.loading-message {
  display: inline-block;
  min-width: 125px;
  margin-left: -60px;
  padding: 10px;
  margin: 0 auto;
  color: #000 !important;
  font-size: 13px;
  font-weight: 400;
  text-align: center;
  vertical-align: middle; }
  .loading-message.loading-message-boxed {
    border: 1px solid #ddd;
    background-color: #eee;
    -webkit-border-radius: 2px;
    -moz-border-radius: 2px;
    -ms-border-radius: 2px;
    -o-border-radius: 2px;
    border-radius: 2px;
    -webkit-box-shadow: 0 1px 8px rgba(0, 0, 0, 0.1);
    -moz-box-shadow: 0 1px 8px rgba(0, 0, 0, 0.1);
    box-shadow: 0 1px 8px rgba(0, 0, 0, 0.1); }
  .loading-message > span {
    line-height: 20px;
    vertical-align: middle; }

.page-loading {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  position: fixed;
  top: 50%;
  left: 50%;
  min-width: 125px;
  margin-left: -60px;
  margin-top: -30px;
  padding: 7px;
  text-align: center;
  color: #333;
  font-size: 13px;
  border: 1px solid #ddd;
  background-color: #eee;
  vertical-align: middle;
  -webkit-box-shadow: 0 1px 8px rgba(0, 0, 0, 0.1);
  -moz-box-shadow: 0 1px 8px rgba(0, 0, 0, 0.1);
  box-shadow: 0 1px 8px rgba(0, 0, 0, 0.1); }
  .page-loading > span {
    line-height: 20px;
    vertical-align: middle; }

.page-spinner-bar {
  position: fixed;
  z-index: 10051;
  width: 100px;
  top: 40%;
  left: 50%;
  margin-left: -55px;
  text-align: center; }
  .page-spinner-bar > div {
    margin: 0 5px;
    width: 18px;
    height: 18px;
    background: #eee;
    border-radius: 100% !important;
    display: inline-block;
    -webkit-animation: bounceDelay 1.4s infinite ease-in-out;
    animation: bounceDelay 1.4s infinite ease-in-out;
    /* Prevent first frame from flickering when animation starts */
    -webkit-animation-fill-mode: both;
    animation-fill-mode: both; }
  .page-spinner-bar .bounce1 {
    -webkit-animation-delay: -0.32s;
    animation-delay: -0.32s; }
  .page-spinner-bar .bounce2 {
    -webkit-animation-delay: -0.16s;
    animation-delay: -0.16s; }

.block-spinner-bar {
  display: inline-block;
  width: 80px;
  text-align: center; }
  .block-spinner-bar > div {
    margin: 0 2px;
    width: 15px;
    height: 15px;
    background: #eee;
    border-radius: 100% !important;
    display: inline-block;
    -webkit-animation: bounceDelay 1.4s infinite ease-in-out;
    animation: bounceDelay 1.4s infinite ease-in-out;
    /* Prevent first frame from flickering when animation starts */
    -webkit-animation-fill-mode: both;
    animation-fill-mode: both; }
  .block-spinner-bar .bounce1 {
    -webkit-animation-delay: -0.32s;
    animation-delay: -0.32s; }
  .block-spinner-bar .bounce2 {
    -webkit-animation-delay: -0.16s;
    animation-delay: -0.16s; }

/***
Metro icons
***/
[class^="m-icon-"] {
  display: inline-block;
  width: 14px;
  height: 14px;
  margin-top: 3px;
  line-height: 14px;
  vertical-align: top;
  background-image: url(../img/syncfusion-icons.png);
  background-position: 0 0;
  background-repeat: no-repeat; }

[class^="m-icon-big-"] {
  display: inline-block;
  width: 30px;
  height: 30px;
  margin: 6px;
  vertical-align: middle;
  background-image: url(../img/syncfusion-icons.png);
  background-position: 0 0px;
  background-repeat: no-repeat; }

/* large icons */
.btn.m-icon-big {
  padding: 9px 16px 8px 16px; }

.btn.m-icon-big.m-icon-only {
  padding: 9px 8px 8px 0px; }

.btn.m-icon-big [class^="m-icon-big-"] {
  margin: 0 0 0 10px; }

.btn.m-icon-ony > i {
  margin-left: 0px; }

/* default icons */
.btn.m-icon {
  padding: 7px 14px 7px 14px; }

.btn.m-icon [class^="m-icon-"] {
  margin: 4px 0 0 5px; }

.btn.m-icon.m-icon-only {
  padding: 7px 10px 7px 6px; }

/* white icon */
.m-icon-white {
  background-image: url(../img/syncfusion-icons-white.png); }

/*  Misc */
.m-icon-swapright {
  background-position: -27px -10px; }

.m-icon-swapdown {
  background-position: -68px -10px; }

.m-icon-swapleft {
  background-position: -8px -10px; }

.m-icon-swapup {
  background-position: -46px -10px; }

.m-icon-big-swapright {
  background-position: -42px -28px; }

.m-icon-big-swapdown {
  background-position: -115px -28px; }

.m-icon-big-swapleft {
  background-position: -6px -28px; }

.m-icon-big-swapup {
  background-position: -78px -28px; }

/***
Customized Bootstrap Modal 
***/
.modal {
  z-index: 10050;
  outline: none;
  overflow-y: auto !important;
  /* Fix content shifting to the right on modal open due to scrollbar closed */ }
  .page-portlet-fullscreen .modal {
    z-index: 10060; }
  .modal .modal-header {
    border-bottom: 1px solid #EFEFEF; }
    .modal .modal-header h3 {
      font-weight: 300; }
    .modal .modal-header .close {
      margin-top: 0px !important; }
  .modal.draggable-modal .modal-header {
    cursor: move; }
  .modal .modal-dialog {
    z-index: 10051; }
  .modal > .loading {
    position: absolute;
    top: 50%;
    left: 50%;
    margin-top: -22px;
    margin-left: -22px; }
  .modal.in .page-loading {
    display: none; }

.modal-open {
  overflow-y: auto !important; }

.modal-open-noscroll {
  overflow-y: hidden !important; }

.modal-backdrop {
  border: 0;
  outline: none; }
  .page-portlet-fullscreen .modal-backdrop {
    z-index: 10059; }
  .modal-backdrop, .modal-backdrop.fade.in {
    background-color: #333 !important; }

body[ng-controller] .modal-backdrop {
  z-index: 10049 !important; }
body[ng-controller] .modal {
  z-index: 10050 !important; }

/* Full width modal */
.modal-full.modal-dialog {
  width: 99%; }

@media (max-width: 768px) {
  .modal-full.modal-dialog {
    width: auto; } }
.modal .modal-content {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  border: 0; }
  .modal .modal-content .modal-title {
    font-weight: 400; }
  .modal .modal-content .modal-footer {
    border: 0; }

.modal-backdrop.in {
  opacity: 0.2 ;
  filter: alpha(opacity=20) ; }

/***
Notes
***/
.note {
  margin: 0 0 20px 0;
  padding: 15px 30px 15px 15px;
  border-left: 5px solid #eee;
  -webkit-border-radius: 0 2px 2px 0;
  -moz-border-radius: 0 2px 2px 0;
  -ms-border-radius: 0 2px 2px 0;
  -o-border-radius: 0 2px 2px 0;
  border-radius: 0 2px 2px 0; }
  .note h1,
  .note h2,
  .note h3,
  .note h4,
  .note h5,
  .note h6 {
    margin-top: 0; }
    .note h1 .close,
    .note h2 .close,
    .note h3 .close,
    .note h4 .close,
    .note h5 .close,
    .note h6 .close {
      margin-right: -10px; }
  .note p {
    margin: 0;
    font-size: 13px; }
    .note p:last-child {
      margin-bottom: 0; }
  .note code,
  .note .highlight {
    background-color: #fff; }
  .note.note-default {
    background-color: white;
    border-color: #b0c1d2;
    color: black; }
    .note.note-default.note-bordered {
      background-color: #eef1f5;
      border-color: #c0cedb; }
    .note.note-default.note-shadow {
      background-color: #f1f4f7;
      border-color: #d1dbe4;
      box-shadow: 5px 5px rgba(212, 221, 230, 0.2); }
  .note.note-success {
    background-color: #c0edf1;
    border-color: #58d0da;
    color: black; }
    .note.note-success.note-bordered {
      background-color: #a7e6ec;
      border-color: #6dd6df; }
    .note.note-success.note-shadow {
      background-color: #abe7ed;
      border-color: #81dbe3;
      box-shadow: 5px 5px rgba(134, 221, 228, 0.2); }
  .note.note-info {
    background-color: #f5f8fd;
    border-color: #8bb4e7;
    color: #010407; }
    .note.note-info.note-bordered {
      background-color: #dbe8f8;
      border-color: #a0c2ec; }
    .note.note-info.note-shadow {
      background-color: #e0ebf9;
      border-color: #b5cff0;
      box-shadow: 5px 5px rgba(185, 210, 241, 0.2); }
  .note.note-warning {
    background-color: #faeaa9;
    border-color: #f3cc31;
    color: black; }
    .note.note-warning.note-bordered {
      background-color: #f8e38c;
      border-color: #f4d249; }
    .note.note-warning.note-shadow {
      background-color: #f9e491;
      border-color: #f6d861;
      box-shadow: 5px 5px rgba(246, 217, 102, 0.2); }
  .note.note-danger {
    background-color: #fef7f8;
    border-color: #f0868e;
    color: #210406; }
    .note.note-danger.note-bordered {
      background-color: #fbdcde;
      border-color: #f39da3; }
    .note.note-danger.note-shadow {
      background-color: #fbe1e3;
      border-color: #f6b3b8;
      box-shadow: 5px 5px rgba(246, 184, 189, 0.2); }

.note {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  border: 0; }

/***
Customized Bootstrap Pagination
***/
.pagination {
  margin: 10px 0; }
  .pagination.pagination-circle > li:first-child > a {
    border-radius: 25px 0 0 25px !important; }
  .pagination.pagination-circle > li:last-child > a {
    border-radius: 0 25px 25px 0 !important; }

/***
Customized Bootstrap Panels
***/
.panel-group .panel {
  overflow: visible; }
.panel .panel-body {
  font-size: 13px; }
.panel .panel-title > a:hover {
  text-decoration: none; }
.accordion .panel .panel-heading {
  padding: 0; }
.accordion .panel .panel-title {
  padding: 0; }
  .accordion .panel .panel-title .accordion-toggle {
    display: block;
    padding: 10px 15px; }
  .accordion .panel .panel-title .accordion-toggle.accordion-toggle-styled {
    background: url("../img/accordion-plusminus.png") no-repeat;
    background-position: right -19px;
    margin-right: 15px; }
  .accordion .panel .panel-title .accordion-toggle.accordion-toggle-styled.collapsed {
    background-position: right 12px; }

/***
Accordions
***/
.panel-heading {
  background: #eee; }
  .panel-heading a {
    text-decoration: none; }
  .panel-heading a:active,
  .panel-heading a:focus,
  .panel-heading a:hover {
    text-decoration: none; }

.panel {
  border: 0; }

/***
Customized Bootstrap Popover
***/
/*rtl:ignore*/
.popover {
  padding: 0; }

.popover .popover-title {
  margin: 0 !important; }

/*rtl:ignore*/
.popover {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  border: 0;
  background: #fff; }

.popover > .popover-title {
  background: #fff;
  font-weight: 600;
  font-size: 12px;
  text-transform: uppercase;
  padding: 10px 14px 6px 14px;
  border: 0; }
.popover .arrow,
.popover .arrow:after {
  display: none !important; }

/***
Portlets
***/
/* Full Screen portlet mode */
.page-portlet-fullscreen {
  overflow: hidden; }

/* Basic portlet */
.portlet {
  margin-top: 0px;
  margin-bottom: 25px;
  padding: 0px;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px; }
  .portlet.portlet-fullscreen {
    z-index: 10060;
    margin: 0;
    position: fixed;
    top: 0;
    left: 0;
    bottom: 0;
    right: 0;
    width: 100%;
    height: 100%;
    background: #fff; }
    .portlet.portlet-fullscreen > .portlet-body {
      overflow-y: auto;
      overflow-x: hidden;
      padding: 0 10px; }
    .portlet.portlet-fullscreen > .portlet-title {
      padding: 0 10px; }
  .portlet > .portlet-title {
    border-bottom: 1px solid #eee;
    padding: 0;
    margin-bottom: 10px;
    min-height: 41px;
    -webkit-border-radius: 2px 2px 0 0;
    -moz-border-radius: 2px 2px 0 0;
    -ms-border-radius: 2px 2px 0 0;
    -o-border-radius: 2px 2px 0 0;
    border-radius: 2px 2px 0 0; }
    .portlet > .portlet-title:before, .portlet > .portlet-title:after {
      content: " ";
      display: table; }
    .portlet > .portlet-title:after {
      clear: both; }
    .portlet > .portlet-title > .caption {
      float: left;
      display: inline-block;
      font-size: 18px;
      line-height: 18px;
      padding: 10px 0; }
      .portlet > .portlet-title > .caption.bold {
        font-weight: 400; }
      .portlet > .portlet-title > .caption > i {
        float: left;
        margin-top: 4px;
        display: inline-block;
        font-size: 13px;
        margin-right: 5px;
        color: #666; }
        .portlet > .portlet-title > .caption > i.glyphicon {
          margin-top: 2px; }
      .portlet > .portlet-title > .caption > .caption-helper {
        padding: 0;
        margin: 0;
        line-height: 13px;
        color: #9eacb4;
        font-size: 13px;
        font-weight: 400; }
    .portlet > .portlet-title > .actions {
      float: right;
      display: inline-block;
      padding: 6px 0; }
      .portlet > .portlet-title > .actions > .dropdown-menu i {
        color: #555555; }
      .portlet > .portlet-title > .actions > .btn,
      .portlet > .portlet-title > .actions > .btn.btn-sm,
      .portlet > .portlet-title > .actions > .btn-group > .btn,
      .portlet > .portlet-title > .actions > .btn-group > .btn.btn-sm {
        padding: 4px 10px;
        font-size: 13px;
        line-height: 1.5; }
        .portlet > .portlet-title > .actions > .btn.btn-default,
        .portlet > .portlet-title > .actions > .btn.btn-sm.btn-default,
        .portlet > .portlet-title > .actions > .btn-group > .btn.btn-default,
        .portlet > .portlet-title > .actions > .btn-group > .btn.btn-sm.btn-default {
          padding: 3px 9px; }
        .portlet > .portlet-title > .actions > .btn > i,
        .portlet > .portlet-title > .actions > .btn.btn-sm > i,
        .portlet > .portlet-title > .actions > .btn-group > .btn > i,
        .portlet > .portlet-title > .actions > .btn-group > .btn.btn-sm > i {
          font-size: 13px; }
      .portlet > .portlet-title > .actions .btn-icon-only {
        padding: 5px 7px 3px 7px; }
        .portlet > .portlet-title > .actions .btn-icon-only.btn-default {
          padding: 4px 6px 2px 6px; }
          .portlet > .portlet-title > .actions .btn-icon-only.btn-default > i {
            font-size: 14px; }
          .portlet > .portlet-title > .actions .btn-icon-only.btn-default.fullscreen {
            font-family: FontAwesome;
            color: #a0a0a0;
            padding-top: 4px; }
            .portlet > .portlet-title > .actions .btn-icon-only.btn-default.fullscreen.btn-sm {
              padding: 3px 3px !important;
              height: 27px;
              width: 27px; }
            .portlet > .portlet-title > .actions .btn-icon-only.btn-default.fullscreen:before {
              content: "\f065"; }
            .portlet > .portlet-title > .actions .btn-icon-only.btn-default.fullscreen.on:before {
              content: "\f066"; }
    .portlet > .portlet-title > .tools {
      float: right;
      display: inline-block;
      padding: 12px 0 8px 0; }
      .portlet > .portlet-title > .tools > a {
        display: inline-block;
        height: 16px;
        margin-left: 5px;
        opacity: 1 ;
        filter: alpha(opacity=100) ; }
      .portlet > .portlet-title > .tools > a.remove {
        background-image: url(../img/portlet-remove-icon.png);
        background-repeat: no-repeat;
        width: 11px; }
      .portlet > .portlet-title > .tools > a.config {
        background-image: url(../img/portlet-config-icon.png);
        background-repeat: no-repeat;
        width: 12px; }
      .portlet > .portlet-title > .tools > a.reload {
        background-image: url(../img/portlet-reload-icon.png);
        width: 13px; }
      .portlet > .portlet-title > .tools > a.expand {
        background-image: url(../img/portlet-expand-icon.png);
        width: 14px;
        visibility: visible; }
      .portlet > .portlet-title > .tools > a.collapse {
        background-image: url(../img/portlet-collapse-icon.png);
        width: 14px;
        visibility: visible; }
      .portlet > .portlet-title > .tools > a.fullscreen {
        display: inline-block;
        top: -3px;
        position: relative;
        font-size: 13px;
        font-family: FontAwesome;
        color: #ACACAC; }
        .portlet > .portlet-title > .tools > a.fullscreen:before {
          content: "\f065"; }
        .portlet > .portlet-title > .tools > a.fullscreen.on:before {
          content: "\f066"; }
      .portlet > .portlet-title > .tools > a:hover {
        text-decoration: none;
        -webkit-transition: all 0.1s ease-in-out;
        -moz-transition: all 0.1s ease-in-out;
        -o-transition: all 0.1s ease-in-out;
        -ms-transition: all 0.1s ease-in-out;
        transition: all 0.1s ease-in-out;
        opacity: 0.8 ;
        filter: alpha(opacity=80) ; }
    .portlet > .portlet-title > .pagination {
      float: right;
      display: inline-block;
      margin: 2px 0 0 0;
      border: 0;
      padding: 4px 0; }
    .portlet > .portlet-title > .nav-tabs {
      background: none;
      margin: 1px 0 0 0;
      float: right;
      display: inline-block;
      border: 0; }
      .portlet > .portlet-title > .nav-tabs > li {
        background: none;
        margin: 0;
        border: 0; }
        .portlet > .portlet-title > .nav-tabs > li > a {
          background: none;
          margin: 5px 0 0 1px;
          border: 0;
          padding: 8px 10px;
          color: #fff; }
        .portlet > .portlet-title > .nav-tabs > li.active > a, .portlet > .portlet-title > .nav-tabs > li:hover > a {
          color: #333;
          background: #fff;
          border: 0; }
  .portlet > .portlet-body {
    clear: both;
    -webkit-border-radius: 0 0 2px 2px;
    -moz-border-radius: 0 0 2px 2px;
    -ms-border-radius: 0 0 2px 2px;
    -o-border-radius: 0 0 2px 2px;
    border-radius: 0 0 2px 2px; }
    .portlet > .portlet-body p {
      margin-top: 0; }
  .portlet > .portlet-empty {
    min-height: 125px; }
  .portlet.full-height-content {
    margin-bottom: 0; }

/* Portlet background colors */
/* Side bordered portlet */
.portlet.bordered > .portlet-title {
  border-bottom: 0; }

/* Solid colored portlet */
.portlet.solid {
  padding: 0 10px 10px 10px;
  border: 0px; }
  .portlet.solid > .portlet-title {
    border-bottom: 0;
    margin-bottom: 10px; }
    .portlet.solid > .portlet-title > .caption {
      padding: 16px 0 2px 0; }
    .portlet.solid > .portlet-title > .actions {
      padding: 12px 0 6px 0; }
    .portlet.solid > .portlet-title > .tools {
      padding: 14px 0 6px 0; }

/* Solid bordered portlet */
.portlet.solid.bordered > .portlet-title {
  margin-bottom: 10px; }

/* Box portlet */
.portlet.box {
  padding: 0px !important; }
  .portlet.box > .portlet-title {
    border-bottom: 0;
    padding: 0 10px;
    margin-bottom: 0;
    color: #fff; }
    .portlet.box > .portlet-title > .caption {
      padding: 11px 0 9px 0; }
    .portlet.box > .portlet-title > .tools > a.remove {
      background-image: url(../img/portlet-remove-icon-white.png); }
    .portlet.box > .portlet-title > .tools > a.config {
      background-image: url(../img/portlet-config-icon-white.png); }
    .portlet.box > .portlet-title > .tools > a.reload {
      background-image: url(../img/portlet-reload-icon-white.png); }
    .portlet.box > .portlet-title > .tools > a.expand {
      background-image: url(../img/portlet-expand-icon-white.png); }
    .portlet.box > .portlet-title > .tools > a.collapse {
      background-image: url(../img/portlet-collapse-icon-white.png); }
    .portlet.box > .portlet-title > .tools > a.fullscreen {
      color: #fdfdfd; }
    .portlet.box > .portlet-title > .actions {
      padding: 7px 0 5px 0; }
  .portlet.box > .portlet-body {
    background-color: #fff;
    padding: 15px; }

/* Light Portlet */
.portlet.light {
  padding: 12px 20px 15px 20px;
  background-color: #fff; }
  .portlet.light.bordered {
    border: 1px solid #e7ecf1 !important; }
    .portlet.light.bordered > .portlet-title {
      border-bottom: 1px solid #eef1f5; }
  .portlet.light.bg-inverse {
    background: #f1f4f7; }
  .portlet.light > .portlet-title {
    padding: 0;
    min-height: 48px; }
    .portlet.light > .portlet-title > .caption {
      color: #666;
      padding: 10px 0; }
      .portlet.light > .portlet-title > .caption > .caption-subject {
        font-size: 16px; }
      .portlet.light > .portlet-title > .caption > i {
        color: #777;
        font-size: 15px;
        font-weight: 300;
        margin-top: 3px; }
      .portlet.light > .portlet-title > .caption.caption-md > .caption-subject {
        font-size: 15px; }
      .portlet.light > .portlet-title > .caption.caption-md > i {
        font-size: 14px; }
    .portlet.light > .portlet-title > .actions {
      padding: 6px 0 14px 0; }
      .portlet.light > .portlet-title > .actions .btn-default {
        color: #666; }
      .portlet.light > .portlet-title > .actions .btn-icon-only {
        height: 27px;
        width: 27px; }
      .portlet.light > .portlet-title > .actions .dropdown-menu li > a {
        color: #555; }
    .portlet.light > .portlet-title > .inputs {
      float: right;
      display: inline-block;
      padding: 4px 0; }
      .portlet.light > .portlet-title > .inputs > .portlet-input .input-icon > i {
        font-size: 14px;
        margin-top: 9px; }
      .portlet.light > .portlet-title > .inputs > .portlet-input .input-icon > .form-control {
        height: 30px;
        padding: 2px 26px 3px 10px;
        font-size: 13px; }
      .portlet.light > .portlet-title > .inputs > .portlet-input > .form-control {
        height: 30px;
        padding: 3px 10px;
        font-size: 13px; }
    .portlet.light > .portlet-title > .pagination {
      padding: 2px 0 13px 0; }
    .portlet.light > .portlet-title > .tools {
      padding: 10px 0 13px 0;
      margin-top: 2px; }
    .portlet.light > .portlet-title > .nav-tabs > li {
      margin: 0;
      padding: 0; }
      .portlet.light > .portlet-title > .nav-tabs > li > a {
        margin: 0;
        padding: 12px 13px 13px 13px;
        font-size: 13px;
        color: #666; }
      .portlet.light > .portlet-title > .nav-tabs > li.active > a, .portlet.light > .portlet-title > .nav-tabs > li:hover > a {
        margin: 0;
        background: none;
        color: #333; }
  .portlet.light.form-fit {
    padding: 0; }
    .portlet.light.form-fit > .portlet-title {
      padding: 17px 20px 10px 20px;
      margin-bottom: 0; }
  .portlet.light .portlet-body {
    padding-top: 8px; }
  .portlet.light.portlet-fullscreen > .portlet-body {
    padding: 8px 0; }
  .portlet.light.portlet-fit {
    padding: 0; }
    .portlet.light.portlet-fit > .portlet-title {
      padding: 15px 20px 10px 20px; }
    .portlet.light.portlet-fit > .portlet-body {
      padding: 10px 20px 20px 20px; }
  .portlet.light.portlet-fit.portlet-form > .portlet-body {
    padding: 0; }
  .portlet.light.portlet-fit.portlet-form > .portlet-body {
    padding: 0; }
    .portlet.light.portlet-fit.portlet-form > .portlet-body .form-actions {
      background: none; }
  .portlet.light.portlet-datatable.portlet-fit > .portlet-body {
    padding-top: 10px;
    padding-bottom: 25px; }

.tab-pane > p:last-child {
  margin-bottom: 0px; }

/* Reverse aligned tabs */
.tabs-reversed > li {
  float: right;
  margin-right: 0; }
  .tabs-reversed > li > a {
    margin-right: 0; }

/* jQuery UI Draggable Portlets */
.portlet-sortable:not(.portlet-fullscreen) > .portlet-title {
  cursor: move; }

.portlet-sortable-placeholder {
  border: 2px dashed #eee;
  margin-bottom: 25px; }

.portlet-sortable-empty {
  box-shadow: none !important;
  height: 45px; }

.portlet-collapsed {
  display: none; }

@media (max-width: 991px) {
  /* 991px */
  .portlet-collapsed-on-mobile {
    display: none; } }
.portlet {
  box-shadow: 0px 2px 3px 2px rgba(0, 0, 0, 0.03); }

/***
Custom colored portlets 
***/
.portlet > .portlet-body.white,
.portlet.white {
  background-color: #ffffff; }

.portlet.solid.white > .portlet-title,
.portlet.solid.white > .portlet-body {
  border: 0;
  color: #666; }
.portlet.solid.white > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.white > .portlet-title > .caption > i {
    color: #666; }
.portlet.solid.white > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.white > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.white > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.white > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.white > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.white > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.white {
  border: 1px solid white;
  border-top: 0; }
  .portlet.box.white > .portlet-title {
    background-color: #ffffff; }
    .portlet.box.white > .portlet-title > .caption {
      color: #666; }
      .portlet.box.white > .portlet-title > .caption > i {
        color: #666; }
    .portlet.box.white > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid white;
      color: white;
      box-shadow: none; }
      .portlet.box.white > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.white > .portlet-title > .actions .btn-default:hover, .portlet.box.white > .portlet-title > .actions .btn-default:focus, .portlet.box.white > .portlet-title > .actions .btn-default:active, .portlet.box.white > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.default,
.portlet.default {
  background-color: #e1e5ec; }

.portlet.solid.default > .portlet-title,
.portlet.solid.default > .portlet-body {
  border: 0;
  color: #666; }
.portlet.solid.default > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.default > .portlet-title > .caption > i {
    color: #666; }
.portlet.solid.default > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.default > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.default > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.default > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.default > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.default > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.default {
  border: 1px solid white;
  border-top: 0; }
  .portlet.box.default > .portlet-title {
    background-color: #e1e5ec; }
    .portlet.box.default > .portlet-title > .caption {
      color: #666; }
      .portlet.box.default > .portlet-title > .caption > i {
        color: #666; }
    .portlet.box.default > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid white;
      color: white;
      box-shadow: none; }
      .portlet.box.default > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.default > .portlet-title > .actions .btn-default:hover, .portlet.box.default > .portlet-title > .actions .btn-default:focus, .portlet.box.default > .portlet-title > .actions .btn-default:active, .portlet.box.default > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.dark,
.portlet.dark {
  background-color: #2f353b; }

.portlet.solid.dark > .portlet-title,
.portlet.solid.dark > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.dark > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.dark > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.dark > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.dark > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.dark > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.dark > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.dark > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.dark > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.dark {
  border: 1px solid #464f57;
  border-top: 0; }
  .portlet.box.dark > .portlet-title {
    background-color: #2f353b; }
    .portlet.box.dark > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.dark > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.dark > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #616d79;
      color: #6c7a88;
      box-shadow: none; }
      .portlet.box.dark > .portlet-title > .actions .btn-default > i {
        color: #738290; }
      .portlet.box.dark > .portlet-title > .actions .btn-default:hover, .portlet.box.dark > .portlet-title > .actions .btn-default:focus, .portlet.box.dark > .portlet-title > .actions .btn-default:active, .portlet.box.dark > .portlet-title > .actions .btn-default.active {
        border: 1px solid #798794;
        color: #8793a0; }

.portlet > .portlet-body.blue,
.portlet.blue {
  background-color: #3598dc; }

.portlet.solid.blue > .portlet-title,
.portlet.solid.blue > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue {
  border: 1px solid #60aee4;
  border-top: 0; }
  .portlet.box.blue > .portlet-title {
    background-color: #3598dc; }
    .portlet.box.blue > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #95c9ed;
      color: #aad4f0;
      box-shadow: none; }
      .portlet.box.blue > .portlet-title > .actions .btn-default > i {
        color: #b7daf3; }
      .portlet.box.blue > .portlet-title > .actions .btn-default:hover, .portlet.box.blue > .portlet-title > .actions .btn-default:focus, .portlet.box.blue > .portlet-title > .actions .btn-default:active, .portlet.box.blue > .portlet-title > .actions .btn-default.active {
        border: 1px solid #c0dff4;
        color: #d6eaf8; }

.portlet > .portlet-body.blue-madison,
.portlet.blue-madison {
  background-color: #578ebe; }

.portlet.solid.blue-madison > .portlet-title,
.portlet.solid.blue-madison > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-madison > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-madison > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-madison > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-madison > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-madison > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-madison > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-madison > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-madison > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-madison {
  border: 1px solid #7ca7cc;
  border-top: 0; }
  .portlet.box.blue-madison > .portlet-title {
    background-color: #578ebe; }
    .portlet.box.blue-madison > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-madison > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-madison > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #a8c4dd;
      color: #bad1e4;
      box-shadow: none; }
      .portlet.box.blue-madison > .portlet-title > .actions .btn-default > i {
        color: #c5d8e9; }
      .portlet.box.blue-madison > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-madison > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-madison > .portlet-title > .actions .btn-default:active, .portlet.box.blue-madison > .portlet-title > .actions .btn-default.active {
        border: 1px solid #cdddec;
        color: #dfeaf3; }

.portlet > .portlet-body.blue-chambray,
.portlet.blue-chambray {
  background-color: #2C3E50; }

.portlet.solid.blue-chambray > .portlet-title,
.portlet.solid.blue-chambray > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-chambray > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-chambray > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-chambray > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-chambray > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-chambray > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-chambray > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-chambray > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-chambray > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-chambray {
  border: 1px solid #3e5871;
  border-top: 0; }
  .portlet.box.blue-chambray > .portlet-title {
    background-color: #2C3E50; }
    .portlet.box.blue-chambray > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-chambray > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-chambray > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #547698;
      color: #5f83a7;
      box-shadow: none; }
      .portlet.box.blue-chambray > .portlet-title > .actions .btn-default > i {
        color: #698bac; }
      .portlet.box.blue-chambray > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-chambray > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-chambray > .portlet-title > .actions .btn-default:active, .portlet.box.blue-chambray > .portlet-title > .actions .btn-default.active {
        border: 1px solid #6f90b0;
        color: #809cb9; }

.portlet > .portlet-body.blue-ebonyclay,
.portlet.blue-ebonyclay {
  background-color: #22313F; }

.portlet.solid.blue-ebonyclay > .portlet-title,
.portlet.solid.blue-ebonyclay > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-ebonyclay > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-ebonyclay > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-ebonyclay > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-ebonyclay > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-ebonyclay > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-ebonyclay > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-ebonyclay > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-ebonyclay > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-ebonyclay {
  border: 1px solid #344b60;
  border-top: 0; }
  .portlet.box.blue-ebonyclay > .portlet-title {
    background-color: #22313F; }
    .portlet.box.blue-ebonyclay > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-ebonyclay > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #496a88;
      color: #527798;
      box-shadow: none; }
      .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default > i {
        color: #587ea2; }
      .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default:active, .portlet.box.blue-ebonyclay > .portlet-title > .actions .btn-default.active {
        border: 1px solid #5d83a7;
        color: #6d90b0; }

.portlet > .portlet-body.blue-hoki,
.portlet.blue-hoki {
  background-color: #67809F; }

.portlet.solid.blue-hoki > .portlet-title,
.portlet.solid.blue-hoki > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-hoki > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-hoki > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-hoki > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-hoki > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-hoki > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-hoki > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-hoki > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-hoki > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-hoki {
  border: 1px solid #869ab3;
  border-top: 0; }
  .portlet.box.blue-hoki > .portlet-title {
    background-color: #67809F; }
    .portlet.box.blue-hoki > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-hoki > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-hoki > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #acb9ca;
      color: #bbc7d4;
      box-shadow: none; }
      .portlet.box.blue-hoki > .portlet-title > .actions .btn-default > i {
        color: #c5ceda; }
      .portlet.box.blue-hoki > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-hoki > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-hoki > .portlet-title > .actions .btn-default:active, .portlet.box.blue-hoki > .portlet-title > .actions .btn-default.active {
        border: 1px solid #cbd4de;
        color: #dbe1e8; }

.portlet > .portlet-body.blue-steel,
.portlet.blue-steel {
  background-color: #4B77BE; }

.portlet.solid.blue-steel > .portlet-title,
.portlet.solid.blue-steel > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-steel > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-steel > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-steel > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-steel > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-steel > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-steel > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-steel > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-steel > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-steel {
  border: 1px solid #7093cc;
  border-top: 0; }
  .portlet.box.blue-steel > .portlet-title {
    background-color: #4B77BE; }
    .portlet.box.blue-steel > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-steel > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-steel > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #9db5dc;
      color: #b0c3e3;
      box-shadow: none; }
      .portlet.box.blue-steel > .portlet-title > .actions .btn-default > i {
        color: #bbcce7; }
      .portlet.box.blue-steel > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-steel > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-steel > .portlet-title > .actions .btn-default:active, .portlet.box.blue-steel > .portlet-title > .actions .btn-default.active {
        border: 1px solid #c3d2e9;
        color: #d6e0f0; }

.portlet > .portlet-body.blue-soft,
.portlet.blue-soft {
  background-color: #4c87b9; }

.portlet.solid.blue-soft > .portlet-title,
.portlet.solid.blue-soft > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-soft > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-soft > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-soft > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-soft > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-soft > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-soft > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-soft > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-soft > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-soft {
  border: 1px solid #71a0c7;
  border-top: 0; }
  .portlet.box.blue-soft > .portlet-title {
    background-color: #4c87b9; }
    .portlet.box.blue-soft > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-soft > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-soft > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #9dbdd9;
      color: #afc9e0;
      box-shadow: none; }
      .portlet.box.blue-soft > .portlet-title > .actions .btn-default > i {
        color: #bad1e4; }
      .portlet.box.blue-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-soft > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-soft > .portlet-title > .actions .btn-default:active, .portlet.box.blue-soft > .portlet-title > .actions .btn-default.active {
        border: 1px solid #c1d6e7;
        color: #d4e2ee; }

.portlet > .portlet-body.blue-dark,
.portlet.blue-dark {
  background-color: #5e738b; }

.portlet.solid.blue-dark > .portlet-title,
.portlet.solid.blue-dark > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-dark > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-dark > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-dark > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-dark > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-dark > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-dark > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-dark > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-dark > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-dark {
  border: 1px solid #788da4;
  border-top: 0; }
  .portlet.box.blue-dark > .portlet-title {
    background-color: #5e738b; }
    .portlet.box.blue-dark > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-dark > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-dark > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #9dacbd;
      color: #acb8c7;
      box-shadow: none; }
      .portlet.box.blue-dark > .portlet-title > .actions .btn-default > i {
        color: #b5c0cd; }
      .portlet.box.blue-dark > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-dark > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-dark > .portlet-title > .actions .btn-default:active, .portlet.box.blue-dark > .portlet-title > .actions .btn-default.active {
        border: 1px solid #bbc5d1;
        color: #cad2db; }

.portlet > .portlet-body.blue-sharp,
.portlet.blue-sharp {
  background-color: #5C9BD1; }

.portlet.solid.blue-sharp > .portlet-title,
.portlet.solid.blue-sharp > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-sharp > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-sharp > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-sharp > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-sharp > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-sharp > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-sharp > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-sharp > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-sharp > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-sharp {
  border: 1px solid #84b3dc;
  border-top: 0; }
  .portlet.box.blue-sharp > .portlet-title {
    background-color: #5C9BD1; }
    .portlet.box.blue-sharp > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-sharp > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-sharp > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #b4d1ea;
      color: #c7ddef;
      box-shadow: none; }
      .portlet.box.blue-sharp > .portlet-title > .actions .btn-default > i {
        color: #d3e4f3; }
      .portlet.box.blue-sharp > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-sharp > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-sharp > .portlet-title > .actions .btn-default:active, .portlet.box.blue-sharp > .portlet-title > .actions .btn-default.active {
        border: 1px solid #dbe9f5;
        color: #eff5fb; }

.portlet > .portlet-body.blue-oleo,
.portlet.blue-oleo {
  background-color: #94A0B2; }

.portlet.solid.blue-oleo > .portlet-title,
.portlet.solid.blue-oleo > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.blue-oleo > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.blue-oleo > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.blue-oleo > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.blue-oleo > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.blue-oleo > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.blue-oleo > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.blue-oleo > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.blue-oleo > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.blue-oleo {
  border: 1px solid #b2bac7;
  border-top: 0; }
  .portlet.box.blue-oleo > .portlet-title {
    background-color: #94A0B2; }
    .portlet.box.blue-oleo > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.blue-oleo > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.blue-oleo > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #d5dae1;
      color: #e4e7ec;
      box-shadow: none; }
      .portlet.box.blue-oleo > .portlet-title > .actions .btn-default > i {
        color: #edeff2; }
      .portlet.box.blue-oleo > .portlet-title > .actions .btn-default:hover, .portlet.box.blue-oleo > .portlet-title > .actions .btn-default:focus, .portlet.box.blue-oleo > .portlet-title > .actions .btn-default:active, .portlet.box.blue-oleo > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f3f4f6;
        color: white; }

.portlet > .portlet-body.green,
.portlet.green {
  background-color: #32c5d2; }

.portlet.solid.green > .portlet-title,
.portlet.solid.green > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green {
  border: 1px solid #5cd1db;
  border-top: 0; }
  .portlet.box.green > .portlet-title {
    background-color: #32c5d2; }
    .portlet.box.green > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #8edfe6;
      color: #a3e5eb;
      box-shadow: none; }
      .portlet.box.green > .portlet-title > .actions .btn-default > i {
        color: #afe8ee; }
      .portlet.box.green > .portlet-title > .actions .btn-default:hover, .portlet.box.green > .portlet-title > .actions .btn-default:focus, .portlet.box.green > .portlet-title > .actions .btn-default:active, .portlet.box.green > .portlet-title > .actions .btn-default.active {
        border: 1px solid #b8ebef;
        color: #cdf1f4; }

.portlet > .portlet-body.green-meadow,
.portlet.green-meadow {
  background-color: #1BBC9B; }

.portlet.solid.green-meadow > .portlet-title,
.portlet.solid.green-meadow > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-meadow > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-meadow > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-meadow > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-meadow > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-meadow > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-meadow > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-meadow > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-meadow > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-meadow {
  border: 1px solid #2ae0bb;
  border-top: 0; }
  .portlet.box.green-meadow > .portlet-title {
    background-color: #1BBC9B; }
    .portlet.box.green-meadow > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-meadow > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-meadow > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #5fe8cc;
      color: #75ebd3;
      box-shadow: none; }
      .portlet.box.green-meadow > .portlet-title > .actions .btn-default > i {
        color: #83edd7; }
      .portlet.box.green-meadow > .portlet-title > .actions .btn-default:hover, .portlet.box.green-meadow > .portlet-title > .actions .btn-default:focus, .portlet.box.green-meadow > .portlet-title > .actions .btn-default:active, .portlet.box.green-meadow > .portlet-title > .actions .btn-default.active {
        border: 1px solid #8ceeda;
        color: #a2f2e1; }

.portlet > .portlet-body.green-seagreen,
.portlet.green-seagreen {
  background-color: #1BA39C; }

.portlet.solid.green-seagreen > .portlet-title,
.portlet.solid.green-seagreen > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-seagreen > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-seagreen > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-seagreen > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-seagreen > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-seagreen > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-seagreen > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-seagreen > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-seagreen > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-seagreen {
  border: 1px solid #22cfc6;
  border-top: 0; }
  .portlet.box.green-seagreen > .portlet-title {
    background-color: #1BA39C; }
    .portlet.box.green-seagreen > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-seagreen > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-seagreen > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #4de1da;
      color: #63e5de;
      box-shadow: none; }
      .portlet.box.green-seagreen > .portlet-title > .actions .btn-default > i {
        color: #70e7e1; }
      .portlet.box.green-seagreen > .portlet-title > .actions .btn-default:hover, .portlet.box.green-seagreen > .portlet-title > .actions .btn-default:focus, .portlet.box.green-seagreen > .portlet-title > .actions .btn-default:active, .portlet.box.green-seagreen > .portlet-title > .actions .btn-default.active {
        border: 1px solid #78e9e3;
        color: #8eece8; }

.portlet > .portlet-body.green-turquoise,
.portlet.green-turquoise {
  background-color: #36D7B7; }

.portlet.solid.green-turquoise > .portlet-title,
.portlet.solid.green-turquoise > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-turquoise > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-turquoise > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-turquoise > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-turquoise > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-turquoise > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-turquoise > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-turquoise > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-turquoise > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-turquoise {
  border: 1px solid #61dfc6;
  border-top: 0; }
  .portlet.box.green-turquoise > .portlet-title {
    background-color: #36D7B7; }
    .portlet.box.green-turquoise > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-turquoise > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-turquoise > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #94ead9;
      color: #a9eee0;
      box-shadow: none; }
      .portlet.box.green-turquoise > .portlet-title > .actions .btn-default > i {
        color: #b6f0e5; }
      .portlet.box.green-turquoise > .portlet-title > .actions .btn-default:hover, .portlet.box.green-turquoise > .portlet-title > .actions .btn-default:focus, .portlet.box.green-turquoise > .portlet-title > .actions .btn-default:active, .portlet.box.green-turquoise > .portlet-title > .actions .btn-default.active {
        border: 1px solid #bef2e8;
        color: #d3f6ef; }

.portlet > .portlet-body.green-haze,
.portlet.green-haze {
  background-color: #44b6ae; }

.portlet.solid.green-haze > .portlet-title,
.portlet.solid.green-haze > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-haze > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-haze > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-haze > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-haze > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-haze > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-haze > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-haze > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-haze > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-haze {
  border: 1px solid #67c6bf;
  border-top: 0; }
  .portlet.box.green-haze > .portlet-title {
    background-color: #44b6ae; }
    .portlet.box.green-haze > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-haze > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-haze > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #93d7d2;
      color: #a6deda;
      box-shadow: none; }
      .portlet.box.green-haze > .portlet-title > .actions .btn-default > i {
        color: #b1e2de; }
      .portlet.box.green-haze > .portlet-title > .actions .btn-default:hover, .portlet.box.green-haze > .portlet-title > .actions .btn-default:focus, .portlet.box.green-haze > .portlet-title > .actions .btn-default:active, .portlet.box.green-haze > .portlet-title > .actions .btn-default.active {
        border: 1px solid #b9e5e2;
        color: #cbece9; }

.portlet > .portlet-body.green-jungle,
.portlet.green-jungle {
  background-color: #26C281; }

.portlet.solid.green-jungle > .portlet-title,
.portlet.solid.green-jungle > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-jungle > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-jungle > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-jungle > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-jungle > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-jungle > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-jungle > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-jungle > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-jungle > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-jungle {
  border: 1px solid #41da9a;
  border-top: 0; }
  .portlet.box.green-jungle > .portlet-title {
    background-color: #26C281; }
    .portlet.box.green-jungle > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-jungle > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-jungle > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #74e4b5;
      color: #8ae8c1;
      box-shadow: none; }
      .portlet.box.green-jungle > .portlet-title > .actions .btn-default > i {
        color: #96ebc8; }
      .portlet.box.green-jungle > .portlet-title > .actions .btn-default:hover, .portlet.box.green-jungle > .portlet-title > .actions .btn-default:focus, .portlet.box.green-jungle > .portlet-title > .actions .btn-default:active, .portlet.box.green-jungle > .portlet-title > .actions .btn-default.active {
        border: 1px solid #9feccc;
        color: #b4f0d7; }

.portlet > .portlet-body.green-soft,
.portlet.green-soft {
  background-color: #3faba4; }

.portlet.solid.green-soft > .portlet-title,
.portlet.solid.green-soft > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-soft > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-soft > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-soft > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-soft > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-soft > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-soft > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-soft > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-soft > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-soft {
  border: 1px solid #5bc2bc;
  border-top: 0; }
  .portlet.box.green-soft > .portlet-title {
    background-color: #3faba4; }
    .portlet.box.green-soft > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-soft > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-soft > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #87d3ce;
      color: #9adad6;
      box-shadow: none; }
      .portlet.box.green-soft > .portlet-title > .actions .btn-default > i {
        color: #a5deda; }
      .portlet.box.green-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.green-soft > .portlet-title > .actions .btn-default:focus, .portlet.box.green-soft > .portlet-title > .actions .btn-default:active, .portlet.box.green-soft > .portlet-title > .actions .btn-default.active {
        border: 1px solid #ade1dd;
        color: #bfe7e5; }

.portlet > .portlet-body.green-dark,
.portlet.green-dark {
  background-color: #4DB3A2; }

.portlet.solid.green-dark > .portlet-title,
.portlet.solid.green-dark > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-dark > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-dark > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-dark > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-dark > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-dark > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-dark > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-dark > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-dark > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-dark {
  border: 1px solid #71c2b5;
  border-top: 0; }
  .portlet.box.green-dark > .portlet-title {
    background-color: #4DB3A2; }
    .portlet.box.green-dark > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-dark > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-dark > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #9cd5cb;
      color: #addcd4;
      box-shadow: none; }
      .portlet.box.green-dark > .portlet-title > .actions .btn-default > i {
        color: #b8e1da; }
      .portlet.box.green-dark > .portlet-title > .actions .btn-default:hover, .portlet.box.green-dark > .portlet-title > .actions .btn-default:focus, .portlet.box.green-dark > .portlet-title > .actions .btn-default:active, .portlet.box.green-dark > .portlet-title > .actions .btn-default.active {
        border: 1px solid #bfe4de;
        color: #d1ebe7; }

.portlet > .portlet-body.green-sharp,
.portlet.green-sharp {
  background-color: #2ab4c0; }

.portlet.solid.green-sharp > .portlet-title,
.portlet.solid.green-sharp > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-sharp > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-sharp > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-sharp > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-sharp > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-sharp > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-sharp > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-sharp > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-sharp > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-sharp {
  border: 1px solid #46cbd7;
  border-top: 0; }
  .portlet.box.green-sharp > .portlet-title {
    background-color: #2ab4c0; }
    .portlet.box.green-sharp > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-sharp > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-sharp > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #79d9e2;
      color: #8edfe6;
      box-shadow: none; }
      .portlet.box.green-sharp > .portlet-title > .actions .btn-default > i {
        color: #9ae3e9; }
      .portlet.box.green-sharp > .portlet-title > .actions .btn-default:hover, .portlet.box.green-sharp > .portlet-title > .actions .btn-default:focus, .portlet.box.green-sharp > .portlet-title > .actions .btn-default:active, .portlet.box.green-sharp > .portlet-title > .actions .btn-default.active {
        border: 1px solid #a2e5eb;
        color: #b7ebef; }

.portlet > .portlet-body.green-steel,
.portlet.green-steel {
  background-color: #29b4b6; }

.portlet.solid.green-steel > .portlet-title,
.portlet.solid.green-steel > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.green-steel > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.green-steel > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.green-steel > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.green-steel > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.green-steel > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.green-steel > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.green-steel > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.green-steel > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.green-steel {
  border: 1px solid #3ed1d4;
  border-top: 0; }
  .portlet.box.green-steel > .portlet-title {
    background-color: #29b4b6; }
    .portlet.box.green-steel > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.green-steel > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.green-steel > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #70dddf;
      color: #85e2e4;
      box-shadow: none; }
      .portlet.box.green-steel > .portlet-title > .actions .btn-default > i {
        color: #92e5e6; }
      .portlet.box.green-steel > .portlet-title > .actions .btn-default:hover, .portlet.box.green-steel > .portlet-title > .actions .btn-default:focus, .portlet.box.green-steel > .portlet-title > .actions .btn-default:active, .portlet.box.green-steel > .portlet-title > .actions .btn-default.active {
        border: 1px solid #9ae7e8;
        color: #afeced; }

.portlet > .portlet-body.grey,
.portlet.grey {
  background-color: #E5E5E5; }

.portlet.solid.grey > .portlet-title,
.portlet.solid.grey > .portlet-body {
  border: 0;
  color: #333333; }
.portlet.solid.grey > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey > .portlet-title > .caption > i {
    color: #333333; }
.portlet.solid.grey > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey {
  border: 1px solid white;
  border-top: 0; }
  .portlet.box.grey > .portlet-title {
    background-color: #E5E5E5; }
    .portlet.box.grey > .portlet-title > .caption {
      color: #333333; }
      .portlet.box.grey > .portlet-title > .caption > i {
        color: #333333; }
    .portlet.box.grey > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid white;
      color: white;
      box-shadow: none; }
      .portlet.box.grey > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.grey > .portlet-title > .actions .btn-default:hover, .portlet.box.grey > .portlet-title > .actions .btn-default:focus, .portlet.box.grey > .portlet-title > .actions .btn-default:active, .portlet.box.grey > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.grey-steel,
.portlet.grey-steel {
  background-color: #e9edef; }

.portlet.solid.grey-steel > .portlet-title,
.portlet.solid.grey-steel > .portlet-body {
  border: 0;
  color: #80898e; }
.portlet.solid.grey-steel > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-steel > .portlet-title > .caption > i {
    color: #80898e; }
.portlet.solid.grey-steel > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-steel > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-steel > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-steel > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-steel > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-steel > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-steel {
  border: 1px solid white;
  border-top: 0; }
  .portlet.box.grey-steel > .portlet-title {
    background-color: #e9edef; }
    .portlet.box.grey-steel > .portlet-title > .caption {
      color: #80898e; }
      .portlet.box.grey-steel > .portlet-title > .caption > i {
        color: #80898e; }
    .portlet.box.grey-steel > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid white;
      color: white;
      box-shadow: none; }
      .portlet.box.grey-steel > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.grey-steel > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-steel > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-steel > .portlet-title > .actions .btn-default:active, .portlet.box.grey-steel > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.grey-cararra,
.portlet.grey-cararra {
  background-color: #fafafa; }

.portlet.solid.grey-cararra > .portlet-title,
.portlet.solid.grey-cararra > .portlet-body {
  border: 0;
  color: #333333; }
.portlet.solid.grey-cararra > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-cararra > .portlet-title > .caption > i {
    color: #333333; }
.portlet.solid.grey-cararra > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-cararra > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-cararra > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-cararra > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-cararra > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-cararra > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-cararra {
  border: 1px solid white;
  border-top: 0; }
  .portlet.box.grey-cararra > .portlet-title {
    background-color: #fafafa; }
    .portlet.box.grey-cararra > .portlet-title > .caption {
      color: #333333; }
      .portlet.box.grey-cararra > .portlet-title > .caption > i {
        color: #333333; }
    .portlet.box.grey-cararra > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid white;
      color: white;
      box-shadow: none; }
      .portlet.box.grey-cararra > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.grey-cararra > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-cararra > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-cararra > .portlet-title > .actions .btn-default:active, .portlet.box.grey-cararra > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.grey-gallery,
.portlet.grey-gallery {
  background-color: #555555; }

.portlet.solid.grey-gallery > .portlet-title,
.portlet.solid.grey-gallery > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.grey-gallery > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-gallery > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.grey-gallery > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-gallery > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-gallery > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-gallery > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-gallery > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-gallery > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-gallery {
  border: 1px solid #6f6f6f;
  border-top: 0; }
  .portlet.box.grey-gallery > .portlet-title {
    background-color: #555555; }
    .portlet.box.grey-gallery > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.grey-gallery > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.grey-gallery > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #8d8d8d;
      color: #9a9a9a;
      box-shadow: none; }
      .portlet.box.grey-gallery > .portlet-title > .actions .btn-default > i {
        color: #a2a2a2; }
      .portlet.box.grey-gallery > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-gallery > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-gallery > .portlet-title > .actions .btn-default:active, .portlet.box.grey-gallery > .portlet-title > .actions .btn-default.active {
        border: 1px solid #a7a7a7;
        color: #b3b3b3; }

.portlet > .portlet-body.grey-cascade,
.portlet.grey-cascade {
  background-color: #95A5A6; }

.portlet.solid.grey-cascade > .portlet-title,
.portlet.solid.grey-cascade > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.grey-cascade > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-cascade > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.grey-cascade > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-cascade > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-cascade > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-cascade > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-cascade > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-cascade > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-cascade {
  border: 1px solid #b1bdbd;
  border-top: 0; }
  .portlet.box.grey-cascade > .portlet-title {
    background-color: #95A5A6; }
    .portlet.box.grey-cascade > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.grey-cascade > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.grey-cascade > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #d2d9d9;
      color: #e0e5e5;
      box-shadow: none; }
      .portlet.box.grey-cascade > .portlet-title > .actions .btn-default > i {
        color: #e8ecec; }
      .portlet.box.grey-cascade > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-cascade > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-cascade > .portlet-title > .actions .btn-default:active, .portlet.box.grey-cascade > .portlet-title > .actions .btn-default.active {
        border: 1px solid #eef0f0;
        color: #fcfcfc; }

.portlet > .portlet-body.grey-silver,
.portlet.grey-silver {
  background-color: #BFBFBF; }

.portlet.solid.grey-silver > .portlet-title,
.portlet.solid.grey-silver > .portlet-body {
  border: 0;
  color: #FAFCFB; }
.portlet.solid.grey-silver > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-silver > .portlet-title > .caption > i {
    color: #FAFCFB; }
.portlet.solid.grey-silver > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-silver > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-silver > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-silver > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-silver > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-silver > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-silver {
  border: 1px solid #d9d9d9;
  border-top: 0; }
  .portlet.box.grey-silver > .portlet-title {
    background-color: #BFBFBF; }
    .portlet.box.grey-silver > .portlet-title > .caption {
      color: #FAFCFB; }
      .portlet.box.grey-silver > .portlet-title > .caption > i {
        color: #FAFCFB; }
    .portlet.box.grey-silver > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f7f7f7;
      color: white;
      box-shadow: none; }
      .portlet.box.grey-silver > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.grey-silver > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-silver > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-silver > .portlet-title > .actions .btn-default:active, .portlet.box.grey-silver > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.grey-salsa,
.portlet.grey-salsa {
  background-color: #ACB5C3; }

.portlet.solid.grey-salsa > .portlet-title,
.portlet.solid.grey-salsa > .portlet-body {
  border: 0;
  color: #FAFCFB; }
.portlet.solid.grey-salsa > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-salsa > .portlet-title > .caption > i {
    color: #FAFCFB; }
.portlet.solid.grey-salsa > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-salsa > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-salsa > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-salsa > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-salsa > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-salsa > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-salsa {
  border: 1px solid #cacfd8;
  border-top: 0; }
  .portlet.box.grey-salsa > .portlet-title {
    background-color: #ACB5C3; }
    .portlet.box.grey-salsa > .portlet-title > .caption {
      color: #FAFCFB; }
      .portlet.box.grey-salsa > .portlet-title > .caption > i {
        color: #FAFCFB; }
    .portlet.box.grey-salsa > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #edeff2;
      color: #fcfcfd;
      box-shadow: none; }
      .portlet.box.grey-salsa > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.grey-salsa > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-salsa > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-salsa > .portlet-title > .actions .btn-default:active, .portlet.box.grey-salsa > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.grey-salt,
.portlet.grey-salt {
  background-color: #bfcad1; }

.portlet.solid.grey-salt > .portlet-title,
.portlet.solid.grey-salt > .portlet-body {
  border: 0;
  color: #FAFCFB; }
.portlet.solid.grey-salt > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-salt > .portlet-title > .caption > i {
    color: #FAFCFB; }
.portlet.solid.grey-salt > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-salt > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-salt > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-salt > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-salt > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-salt > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-salt {
  border: 1px solid #dde3e6;
  border-top: 0; }
  .portlet.box.grey-salt > .portlet-title {
    background-color: #bfcad1; }
    .portlet.box.grey-salt > .portlet-title > .caption {
      color: #FAFCFB; }
      .portlet.box.grey-salt > .portlet-title > .caption > i {
        color: #FAFCFB; }
    .portlet.box.grey-salt > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid white;
      color: white;
      box-shadow: none; }
      .portlet.box.grey-salt > .portlet-title > .actions .btn-default > i {
        color: white; }
      .portlet.box.grey-salt > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-salt > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-salt > .portlet-title > .actions .btn-default:active, .portlet.box.grey-salt > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.grey-mint,
.portlet.grey-mint {
  background-color: #525e64; }

.portlet.solid.grey-mint > .portlet-title,
.portlet.solid.grey-mint > .portlet-body {
  border: 0;
  color: #FFFFFF; }
.portlet.solid.grey-mint > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.grey-mint > .portlet-title > .caption > i {
    color: #FFFFFF; }
.portlet.solid.grey-mint > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.grey-mint > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.grey-mint > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.grey-mint > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.grey-mint > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.grey-mint > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.grey-mint {
  border: 1px solid #697880;
  border-top: 0; }
  .portlet.box.grey-mint > .portlet-title {
    background-color: #525e64; }
    .portlet.box.grey-mint > .portlet-title > .caption {
      color: #FFFFFF; }
      .portlet.box.grey-mint > .portlet-title > .caption > i {
        color: #FFFFFF; }
    .portlet.box.grey-mint > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #88979e;
      color: #96a3a9;
      box-shadow: none; }
      .portlet.box.grey-mint > .portlet-title > .actions .btn-default > i {
        color: #9faab0; }
      .portlet.box.grey-mint > .portlet-title > .actions .btn-default:hover, .portlet.box.grey-mint > .portlet-title > .actions .btn-default:focus, .portlet.box.grey-mint > .portlet-title > .actions .btn-default:active, .portlet.box.grey-mint > .portlet-title > .actions .btn-default.active {
        border: 1px solid #a4afb5;
        color: #b2bcc0; }

.portlet > .portlet-body.red,
.portlet.red {
  background-color: #e7505a; }

.portlet.solid.red > .portlet-title,
.portlet.solid.red > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red {
  border: 1px solid #ed7d84;
  border-top: 0; }
  .portlet.box.red > .portlet-title {
    background-color: #e7505a; }
    .portlet.box.red > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f5b3b7;
      color: #f8c9cc;
      box-shadow: none; }
      .portlet.box.red > .portlet-title > .actions .btn-default > i {
        color: #f9d7d9; }
      .portlet.box.red > .portlet-title > .actions .btn-default:hover, .portlet.box.red > .portlet-title > .actions .btn-default:focus, .portlet.box.red > .portlet-title > .actions .btn-default:active, .portlet.box.red > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fbe0e1;
        color: #fef6f6; }

.portlet > .portlet-body.red-pink,
.portlet.red-pink {
  background-color: #E08283; }

.portlet.solid.red-pink > .portlet-title,
.portlet.solid.red-pink > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-pink > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-pink > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-pink > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-pink > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-pink > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-pink > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-pink > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-pink > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-pink {
  border: 1px solid #eaabac;
  border-top: 0; }
  .portlet.box.red-pink > .portlet-title {
    background-color: #E08283; }
    .portlet.box.red-pink > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-pink > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-pink > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f6dcdc;
      color: #fbf0f0;
      box-shadow: none; }
      .portlet.box.red-pink > .portlet-title > .actions .btn-default > i {
        color: #fefdfd; }
      .portlet.box.red-pink > .portlet-title > .actions .btn-default:hover, .portlet.box.red-pink > .portlet-title > .actions .btn-default:focus, .portlet.box.red-pink > .portlet-title > .actions .btn-default:active, .portlet.box.red-pink > .portlet-title > .actions .btn-default.active {
        border: 1px solid white;
        color: white; }

.portlet > .portlet-body.red-sunglo,
.portlet.red-sunglo {
  background-color: #E26A6A; }

.portlet.solid.red-sunglo > .portlet-title,
.portlet.solid.red-sunglo > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-sunglo > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-sunglo > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-sunglo > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-sunglo > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-sunglo > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-sunglo > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-sunglo > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-sunglo > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-sunglo {
  border: 1px solid #ea9595;
  border-top: 0; }
  .portlet.box.red-sunglo > .portlet-title {
    background-color: #E26A6A; }
    .portlet.box.red-sunglo > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-sunglo > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-sunglo > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f4c8c8;
      color: #f8dddd;
      box-shadow: none; }
      .portlet.box.red-sunglo > .portlet-title > .actions .btn-default > i {
        color: #fbeaea; }
      .portlet.box.red-sunglo > .portlet-title > .actions .btn-default:hover, .portlet.box.red-sunglo > .portlet-title > .actions .btn-default:focus, .portlet.box.red-sunglo > .portlet-title > .actions .btn-default:active, .portlet.box.red-sunglo > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fdf3f3;
        color: white; }

.portlet > .portlet-body.red-intense,
.portlet.red-intense {
  background-color: #e35b5a; }

.portlet.solid.red-intense > .portlet-title,
.portlet.solid.red-intense > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-intense > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-intense > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-intense > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-intense > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-intense > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-intense > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-intense > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-intense > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-intense {
  border: 1px solid #ea8686;
  border-top: 0; }
  .portlet.box.red-intense > .portlet-title {
    background-color: #e35b5a; }
    .portlet.box.red-intense > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-intense > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-intense > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f3baba;
      color: #f7d0d0;
      box-shadow: none; }
      .portlet.box.red-intense > .portlet-title > .actions .btn-default > i {
        color: #f9dddd; }
      .portlet.box.red-intense > .portlet-title > .actions .btn-default:hover, .portlet.box.red-intense > .portlet-title > .actions .btn-default:focus, .portlet.box.red-intense > .portlet-title > .actions .btn-default:active, .portlet.box.red-intense > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fbe6e6;
        color: #fefbfb; }

.portlet > .portlet-body.red-thunderbird,
.portlet.red-thunderbird {
  background-color: #D91E18; }

.portlet.solid.red-thunderbird > .portlet-title,
.portlet.solid.red-thunderbird > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-thunderbird > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-thunderbird > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-thunderbird > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-thunderbird > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-thunderbird > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-thunderbird > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-thunderbird > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-thunderbird > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-thunderbird {
  border: 1px solid #e9403b;
  border-top: 0; }
  .portlet.box.red-thunderbird > .portlet-title {
    background-color: #D91E18; }
    .portlet.box.red-thunderbird > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-thunderbird > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #ef7672;
      color: #f28c89;
      box-shadow: none; }
      .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default > i {
        color: #f39997; }
      .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default:hover, .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default:focus, .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default:active, .portlet.box.red-thunderbird > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f4a2a0;
        color: #f7b9b7; }

.portlet > .portlet-body.red-flamingo,
.portlet.red-flamingo {
  background-color: #EF4836; }

.portlet.solid.red-flamingo > .portlet-title,
.portlet.solid.red-flamingo > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-flamingo > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-flamingo > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-flamingo > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-flamingo > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-flamingo > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-flamingo > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-flamingo > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-flamingo > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-flamingo {
  border: 1px solid #f37365;
  border-top: 0; }
  .portlet.box.red-flamingo > .portlet-title {
    background-color: #EF4836; }
    .portlet.box.red-flamingo > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-flamingo > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-flamingo > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f7a79e;
      color: #f9bcb6;
      box-shadow: none; }
      .portlet.box.red-flamingo > .portlet-title > .actions .btn-default > i {
        color: #fac9c4; }
      .portlet.box.red-flamingo > .portlet-title > .actions .btn-default:hover, .portlet.box.red-flamingo > .portlet-title > .actions .btn-default:focus, .portlet.box.red-flamingo > .portlet-title > .actions .btn-default:active, .portlet.box.red-flamingo > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fbd2cd;
        color: #fde7e5; }

.portlet > .portlet-body.red-soft,
.portlet.red-soft {
  background-color: #d05454; }

.portlet.solid.red-soft > .portlet-title,
.portlet.solid.red-soft > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-soft > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-soft > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-soft > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-soft > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-soft > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-soft > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-soft > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-soft > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-soft {
  border: 1px solid #db7c7c;
  border-top: 0; }
  .portlet.box.red-soft > .portlet-title {
    background-color: #d05454; }
    .portlet.box.red-soft > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-soft > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-soft > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #e8acac;
      color: #eec0c0;
      box-shadow: none; }
      .portlet.box.red-soft > .portlet-title > .actions .btn-default > i {
        color: #f1cccc; }
      .portlet.box.red-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.red-soft > .portlet-title > .actions .btn-default:focus, .portlet.box.red-soft > .portlet-title > .actions .btn-default:active, .portlet.box.red-soft > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f3d4d4;
        color: #f9e8e8; }

.portlet > .portlet-body.red-haze,
.portlet.red-haze {
  background-color: #f36a5a; }

.portlet.solid.red-haze > .portlet-title,
.portlet.solid.red-haze > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-haze > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-haze > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-haze > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-haze > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-haze > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-haze > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-haze > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-haze > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-haze {
  border: 1px solid #f6958a;
  border-top: 0; }
  .portlet.box.red-haze > .portlet-title {
    background-color: #f36a5a; }
    .portlet.box.red-haze > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-haze > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-haze > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #fbc8c3;
      color: #fcdeda;
      box-shadow: none; }
      .portlet.box.red-haze > .portlet-title > .actions .btn-default > i {
        color: #fdebe9; }
      .portlet.box.red-haze > .portlet-title > .actions .btn-default:hover, .portlet.box.red-haze > .portlet-title > .actions .btn-default:focus, .portlet.box.red-haze > .portlet-title > .actions .btn-default:active, .portlet.box.red-haze > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fef3f2;
        color: white; }

.portlet > .portlet-body.red-mint,
.portlet.red-mint {
  background-color: #e43a45; }

.portlet.solid.red-mint > .portlet-title,
.portlet.solid.red-mint > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.red-mint > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.red-mint > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.red-mint > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.red-mint > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.red-mint > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.red-mint > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.red-mint > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.red-mint > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.red-mint {
  border: 1px solid #ea676f;
  border-top: 0; }
  .portlet.box.red-mint > .portlet-title {
    background-color: #e43a45; }
    .portlet.box.red-mint > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.red-mint > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.red-mint > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #f29da2;
      color: #f5b3b7;
      box-shadow: none; }
      .portlet.box.red-mint > .portlet-title > .actions .btn-default > i {
        color: #f6c1c4; }
      .portlet.box.red-mint > .portlet-title > .actions .btn-default:hover, .portlet.box.red-mint > .portlet-title > .actions .btn-default:focus, .portlet.box.red-mint > .portlet-title > .actions .btn-default:active, .portlet.box.red-mint > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f8cacd;
        color: #fbe0e2; }

.portlet > .portlet-body.yellow,
.portlet.yellow {
  background-color: #c49f47; }

.portlet.solid.yellow > .portlet-title,
.portlet.solid.yellow > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow {
  border: 1px solid #d0b36e;
  border-top: 0; }
  .portlet.box.yellow > .portlet-title {
    background-color: #c49f47; }
    .portlet.box.yellow > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #dfcb9c;
      color: #e5d5af;
      box-shadow: none; }
      .portlet.box.yellow > .portlet-title > .actions .btn-default > i {
        color: #e9dbbb; }
      .portlet.box.yellow > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow > .portlet-title > .actions .btn-default:active, .portlet.box.yellow > .portlet-title > .actions .btn-default.active {
        border: 1px solid #ecdfc3;
        color: #f2ead6; }

.portlet > .portlet-body.yellow-gold,
.portlet.yellow-gold {
  background-color: #E87E04; }

.portlet.solid.yellow-gold > .portlet-title,
.portlet.solid.yellow-gold > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-gold > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-gold > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-gold > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-gold > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-gold > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-gold > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-gold > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-gold > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-gold {
  border: 1px solid #fb9724;
  border-top: 0; }
  .portlet.box.yellow-gold > .portlet-title {
    background-color: #E87E04; }
    .portlet.box.yellow-gold > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-gold > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-gold > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #fcb460;
      color: #fdbf79;
      box-shadow: none; }
      .portlet.box.yellow-gold > .portlet-title > .actions .btn-default > i {
        color: #fdc788; }
      .portlet.box.yellow-gold > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-gold > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-gold > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-gold > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fdcb92;
        color: #fed7ab; }

.portlet > .portlet-body.yellow-casablanca,
.portlet.yellow-casablanca {
  background-color: #f2784b; }

.portlet.solid.yellow-casablanca > .portlet-title,
.portlet.solid.yellow-casablanca > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-casablanca > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-casablanca > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-casablanca > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-casablanca > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-casablanca > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-casablanca > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-casablanca > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-casablanca > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-casablanca {
  border: 1px solid #f59c7b;
  border-top: 0; }
  .portlet.box.yellow-casablanca > .portlet-title {
    background-color: #f2784b; }
    .portlet.box.yellow-casablanca > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-casablanca > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #fac6b4;
      color: #fbd8cb;
      box-shadow: none; }
      .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default > i {
        color: #fce3da; }
      .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-casablanca > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fdeae3;
        color: #fffcfb; }

.portlet > .portlet-body.yellow-crusta,
.portlet.yellow-crusta {
  background-color: #f3c200; }

.portlet.solid.yellow-crusta > .portlet-title,
.portlet.solid.yellow-crusta > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-crusta > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-crusta > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-crusta > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-crusta > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-crusta > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-crusta > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-crusta > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-crusta > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-crusta {
  border: 1px solid #ffd327;
  border-top: 0; }
  .portlet.box.yellow-crusta > .portlet-title {
    background-color: #f3c200; }
    .portlet.box.yellow-crusta > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-crusta > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #ffe064;
      color: #ffe57e;
      box-shadow: none; }
      .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default > i {
        color: #ffe88d; }
      .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-crusta > .portlet-title > .actions .btn-default.active {
        border: 1px solid #ffea97;
        color: #ffefb1; }

.portlet > .portlet-body.yellow-lemon,
.portlet.yellow-lemon {
  background-color: #F7CA18; }

.portlet.solid.yellow-lemon > .portlet-title,
.portlet.solid.yellow-lemon > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-lemon > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-lemon > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-lemon > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-lemon > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-lemon > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-lemon > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-lemon > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-lemon > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-lemon {
  border: 1px solid #f9d549;
  border-top: 0; }
  .portlet.box.yellow-lemon > .portlet-title {
    background-color: #F7CA18; }
    .portlet.box.yellow-lemon > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-lemon > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #fbe384;
      color: #fce99d;
      box-shadow: none; }
      .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default > i {
        color: #fcecac; }
      .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-lemon > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fceeb6;
        color: #fdf4ce; }

.portlet > .portlet-body.yellow-saffron,
.portlet.yellow-saffron {
  background-color: #F4D03F; }

.portlet.solid.yellow-saffron > .portlet-title,
.portlet.solid.yellow-saffron > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-saffron > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-saffron > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-saffron > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-saffron > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-saffron > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-saffron > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-saffron > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-saffron > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-saffron {
  border: 1px solid #f7dc6f;
  border-top: 0; }
  .portlet.box.yellow-saffron > .portlet-title {
    background-color: #F4D03F; }
    .portlet.box.yellow-saffron > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-saffron > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #faeaa9;
      color: #fbf0c1;
      box-shadow: none; }
      .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default > i {
        color: #fcf3d0; }
      .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-saffron > .portlet-title > .actions .btn-default.active {
        border: 1px solid #fdf6d9;
        color: #fefcf1; }

.portlet > .portlet-body.yellow-soft,
.portlet.yellow-soft {
  background-color: #c8d046; }

.portlet.solid.yellow-soft > .portlet-title,
.portlet.solid.yellow-soft > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-soft > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-soft > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-soft > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-soft > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-soft > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-soft > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-soft > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-soft > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-soft {
  border: 1px solid #d4da6f;
  border-top: 0; }
  .portlet.box.yellow-soft > .portlet-title {
    background-color: #c8d046; }
    .portlet.box.yellow-soft > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-soft > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-soft > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #e3e79f;
      color: #e9ecb4;
      box-shadow: none; }
      .portlet.box.yellow-soft > .portlet-title > .actions .btn-default > i {
        color: #ecefc0; }
      .portlet.box.yellow-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-soft > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-soft > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-soft > .portlet-title > .actions .btn-default.active {
        border: 1px solid #eff1c8;
        color: #f5f6dc; }

.portlet > .portlet-body.yellow-haze,
.portlet.yellow-haze {
  background-color: #c5bf66; }

.portlet.solid.yellow-haze > .portlet-title,
.portlet.solid.yellow-haze > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-haze > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-haze > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-haze > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-haze > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-haze > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-haze > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-haze > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-haze > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-haze {
  border: 1px solid #d3ce8b;
  border-top: 0; }
  .portlet.box.yellow-haze > .portlet-title {
    background-color: #c5bf66; }
    .portlet.box.yellow-haze > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-haze > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-haze > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #e4e1b7;
      color: #ebe9ca;
      box-shadow: none; }
      .portlet.box.yellow-haze > .portlet-title > .actions .btn-default > i {
        color: #efedd5; }
      .portlet.box.yellow-haze > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-haze > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-haze > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-haze > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f2f1dc;
        color: #f9f8ef; }

.portlet > .portlet-body.yellow-mint,
.portlet.yellow-mint {
  background-color: #c5b96b; }

.portlet.solid.yellow-mint > .portlet-title,
.portlet.solid.yellow-mint > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.yellow-mint > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.yellow-mint > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.yellow-mint > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.yellow-mint > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.yellow-mint > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.yellow-mint > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.yellow-mint > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.yellow-mint > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.yellow-mint {
  border: 1px solid #d3ca90;
  border-top: 0; }
  .portlet.box.yellow-mint > .portlet-title {
    background-color: #c5b96b; }
    .portlet.box.yellow-mint > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.yellow-mint > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.yellow-mint > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #e5dfbc;
      color: #ece8ce;
      box-shadow: none; }
      .portlet.box.yellow-mint > .portlet-title > .actions .btn-default > i {
        color: #f0edd9; }
      .portlet.box.yellow-mint > .portlet-title > .actions .btn-default:hover, .portlet.box.yellow-mint > .portlet-title > .actions .btn-default:focus, .portlet.box.yellow-mint > .portlet-title > .actions .btn-default:active, .portlet.box.yellow-mint > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f3f0e0;
        color: #faf9f3; }

.portlet > .portlet-body.purple,
.portlet.purple {
  background-color: #8E44AD; }

.portlet.solid.purple > .portlet-title,
.portlet.solid.purple > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple {
  border: 1px solid #a563c1;
  border-top: 0; }
  .portlet.box.purple > .portlet-title {
    background-color: #8E44AD; }
    .portlet.box.purple > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #bf8ed3;
      color: #c9a1da;
      box-shadow: none; }
      .portlet.box.purple > .portlet-title > .actions .btn-default > i {
        color: #cfacde; }
      .portlet.box.purple > .portlet-title > .actions .btn-default:hover, .portlet.box.purple > .portlet-title > .actions .btn-default:focus, .portlet.box.purple > .portlet-title > .actions .btn-default:active, .portlet.box.purple > .portlet-title > .actions .btn-default.active {
        border: 1px solid #d4b3e1;
        color: #dec5e8; }

.portlet > .portlet-body.purple-plum,
.portlet.purple-plum {
  background-color: #8775a7; }

.portlet.solid.purple-plum > .portlet-title,
.portlet.solid.purple-plum > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-plum > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-plum > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-plum > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-plum > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-plum > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-plum > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-plum > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-plum > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-plum {
  border: 1px solid #a294bb;
  border-top: 0; }
  .portlet.box.purple-plum > .portlet-title {
    background-color: #8775a7; }
    .portlet.box.purple-plum > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-plum > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-plum > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #c3bad3;
      color: #d0c9dd;
      box-shadow: none; }
      .portlet.box.purple-plum > .portlet-title > .actions .btn-default > i {
        color: #d8d2e3; }
      .portlet.box.purple-plum > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-plum > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-plum > .portlet-title > .actions .btn-default:active, .portlet.box.purple-plum > .portlet-title > .actions .btn-default.active {
        border: 1px solid #ded9e7;
        color: #ebe8f0; }

.portlet > .portlet-body.purple-medium,
.portlet.purple-medium {
  background-color: #BF55EC; }

.portlet.solid.purple-medium > .portlet-title,
.portlet.solid.purple-medium > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-medium > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-medium > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-medium > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-medium > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-medium > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-medium > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-medium > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-medium > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-medium {
  border: 1px solid #d083f1;
  border-top: 0; }
  .portlet.box.purple-medium > .portlet-title {
    background-color: #BF55EC; }
    .portlet.box.purple-medium > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-medium > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-medium > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #e5baf7;
      color: #eed1fa;
      box-shadow: none; }
      .portlet.box.purple-medium > .portlet-title > .actions .btn-default > i {
        color: #f3dffb; }
      .portlet.box.purple-medium > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-medium > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-medium > .portlet-title > .actions .btn-default:active, .portlet.box.purple-medium > .portlet-title > .actions .btn-default.active {
        border: 1px solid #f6e8fc;
        color: white; }

.portlet > .portlet-body.purple-studio,
.portlet.purple-studio {
  background-color: #8E44AD; }

.portlet.solid.purple-studio > .portlet-title,
.portlet.solid.purple-studio > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-studio > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-studio > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-studio > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-studio > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-studio > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-studio > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-studio > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-studio > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-studio {
  border: 1px solid #a563c1;
  border-top: 0; }
  .portlet.box.purple-studio > .portlet-title {
    background-color: #8E44AD; }
    .portlet.box.purple-studio > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-studio > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-studio > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #bf8ed3;
      color: #c9a1da;
      box-shadow: none; }
      .portlet.box.purple-studio > .portlet-title > .actions .btn-default > i {
        color: #cfacde; }
      .portlet.box.purple-studio > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-studio > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-studio > .portlet-title > .actions .btn-default:active, .portlet.box.purple-studio > .portlet-title > .actions .btn-default.active {
        border: 1px solid #d4b3e1;
        color: #dec5e8; }

.portlet > .portlet-body.purple-wisteria,
.portlet.purple-wisteria {
  background-color: #9B59B6; }

.portlet.solid.purple-wisteria > .portlet-title,
.portlet.solid.purple-wisteria > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-wisteria > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-wisteria > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-wisteria > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-wisteria > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-wisteria > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-wisteria > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-wisteria > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-wisteria > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-wisteria {
  border: 1px solid #b07cc6;
  border-top: 0; }
  .portlet.box.purple-wisteria > .portlet-title {
    background-color: #9B59B6; }
    .portlet.box.purple-wisteria > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-wisteria > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #caa7d8;
      color: #d5b9e0;
      box-shadow: none; }
      .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default > i {
        color: #dbc3e5; }
      .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default:active, .portlet.box.purple-wisteria > .portlet-title > .actions .btn-default.active {
        border: 1px solid #dfcae8;
        color: #eadcf0; }

.portlet > .portlet-body.purple-seance,
.portlet.purple-seance {
  background-color: #9A12B3; }

.portlet.solid.purple-seance > .portlet-title,
.portlet.solid.purple-seance > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-seance > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-seance > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-seance > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-seance > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-seance > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-seance > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-seance > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-seance > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-seance {
  border: 1px solid #c217e1;
  border-top: 0; }
  .portlet.box.purple-seance > .portlet-title {
    background-color: #9A12B3; }
    .portlet.box.purple-seance > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-seance > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-seance > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #d349ed;
      color: #d960ef;
      box-shadow: none; }
      .portlet.box.purple-seance > .portlet-title > .actions .btn-default > i {
        color: #dc6ef0; }
      .portlet.box.purple-seance > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-seance > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-seance > .portlet-title > .actions .btn-default:active, .portlet.box.purple-seance > .portlet-title > .actions .btn-default.active {
        border: 1px solid #de77f1;
        color: #e48ef4; }

.portlet > .portlet-body.purple-intense,
.portlet.purple-intense {
  background-color: #8775a7; }

.portlet.solid.purple-intense > .portlet-title,
.portlet.solid.purple-intense > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-intense > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-intense > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-intense > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-intense > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-intense > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-intense > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-intense > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-intense > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-intense {
  border: 1px solid #a294bb;
  border-top: 0; }
  .portlet.box.purple-intense > .portlet-title {
    background-color: #8775a7; }
    .portlet.box.purple-intense > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-intense > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-intense > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #c3bad3;
      color: #d0c9dd;
      box-shadow: none; }
      .portlet.box.purple-intense > .portlet-title > .actions .btn-default > i {
        color: #d8d2e3; }
      .portlet.box.purple-intense > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-intense > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-intense > .portlet-title > .actions .btn-default:active, .portlet.box.purple-intense > .portlet-title > .actions .btn-default.active {
        border: 1px solid #ded9e7;
        color: #ebe8f0; }

.portlet > .portlet-body.purple-sharp,
.portlet.purple-sharp {
  background-color: #796799; }

.portlet.solid.purple-sharp > .portlet-title,
.portlet.solid.purple-sharp > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-sharp > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-sharp > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-sharp > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-sharp > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-sharp > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-sharp > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-sharp > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-sharp > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-sharp {
  border: 1px solid #9486ad;
  border-top: 0; }
  .portlet.box.purple-sharp > .portlet-title {
    background-color: #796799; }
    .portlet.box.purple-sharp > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-sharp > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-sharp > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #b4aac6;
      color: #c2b9d0;
      box-shadow: none; }
      .portlet.box.purple-sharp > .portlet-title > .actions .btn-default > i {
        color: #cac3d6; }
      .portlet.box.purple-sharp > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-sharp > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-sharp > .portlet-title > .actions .btn-default:active, .portlet.box.purple-sharp > .portlet-title > .actions .btn-default.active {
        border: 1px solid #cfc9db;
        color: #ddd8e5; }

.portlet > .portlet-body.purple-soft,
.portlet.purple-soft {
  background-color: #8877a9; }

.portlet.solid.purple-soft > .portlet-title,
.portlet.solid.purple-soft > .portlet-body {
  border: 0;
  color: #ffffff; }
.portlet.solid.purple-soft > .portlet-title > .caption {
  font-weight: 400; }
  .portlet.solid.purple-soft > .portlet-title > .caption > i {
    color: #ffffff; }
.portlet.solid.purple-soft > .portlet-title > .tools > a.remove {
  background-image: url(../img/portlet-remove-icon-white.png); }
.portlet.solid.purple-soft > .portlet-title > .tools > a.config {
  background-image: url(../img/portlet-config-icon-white.png); }
.portlet.solid.purple-soft > .portlet-title > .tools > a.reload {
  background-image: url(../img/portlet-reload-icon-white.png); }
.portlet.solid.purple-soft > .portlet-title > .tools > a.expand {
  background-image: url(../img/portlet-expand-icon-white.png); }
.portlet.solid.purple-soft > .portlet-title > .tools > a.collapse {
  background-image: url(../img/portlet-collapse-icon-white.png); }
.portlet.solid.purple-soft > .portlet-title > .tools > a.fullscreen {
  color: #fdfdfd; }

.portlet.box.purple-soft {
  border: 1px solid #a396bd;
  border-top: 0; }
  .portlet.box.purple-soft > .portlet-title {
    background-color: #8877a9; }
    .portlet.box.purple-soft > .portlet-title > .caption {
      color: #ffffff; }
      .portlet.box.purple-soft > .portlet-title > .caption > i {
        color: #ffffff; }
    .portlet.box.purple-soft > .portlet-title > .actions .btn-default {
      background: transparent !important;
      background-color: transparent !important;
      border: 1px solid #c4bcd4;
      color: #d2cbde;
      box-shadow: none; }
      .portlet.box.purple-soft > .portlet-title > .actions .btn-default > i {
        color: #dad5e4; }
      .portlet.box.purple-soft > .portlet-title > .actions .btn-default:hover, .portlet.box.purple-soft > .portlet-title > .actions .btn-default:focus, .portlet.box.purple-soft > .portlet-title > .actions .btn-default:active, .portlet.box.purple-soft > .portlet-title > .actions .btn-default.active {
        border: 1px solid #dfdbe8;
        color: #edebf2; }

/***
Customized Progress Bars
***/
.progress {
  border: 0;
  background-image: none;
  filter: none;
  box-shadow: none;
  -webkit-box-shadow: none;
  -moz-box-shadow: none;
  box-shadow: none; }
  .progress.progress-sm {
    height: 12px; }
  .page-md .progress {
    text-indent: -99999px; }

/* Custom colors */
.progress-bar.white {
  background: #ffffff !important;
  color: #666 !important; }

.progress-bar.default {
  background: #e1e5ec !important;
  color: #666 !important; }

.progress-bar.dark {
  background: #2f353b !important;
  color: #FFFFFF !important; }

.progress-bar.blue {
  background: #3598dc !important;
  color: #FFFFFF !important; }

.progress-bar.blue-madison {
  background: #578ebe !important;
  color: #FFFFFF !important; }

.progress-bar.blue-chambray {
  background: #2C3E50 !important;
  color: #FFFFFF !important; }

.progress-bar.blue-ebonyclay {
  background: #22313F !important;
  color: #FFFFFF !important; }

.progress-bar.blue-hoki {
  background: #67809F !important;
  color: #FFFFFF !important; }

.progress-bar.blue-steel {
  background: #4B77BE !important;
  color: #FFFFFF !important; }

.progress-bar.blue-soft {
  background: #4c87b9 !important;
  color: #FFFFFF !important; }

.progress-bar.blue-dark {
  background: #5e738b !important;
  color: #FFFFFF !important; }

.progress-bar.blue-sharp {
  background: #5C9BD1 !important;
  color: #FFFFFF !important; }

.progress-bar.blue-oleo {
  background: #94A0B2 !important;
  color: #FFFFFF !important; }

.progress-bar.green {
  background: #32c5d2 !important;
  color: #FFFFFF !important; }

.progress-bar.green-meadow {
  background: #1BBC9B !important;
  color: #FFFFFF !important; }

.progress-bar.green-seagreen {
  background: #1BA39C !important;
  color: #FFFFFF !important; }

.progress-bar.green-turquoise {
  background: #36D7B7 !important;
  color: #FFFFFF !important; }

.progress-bar.green-haze {
  background: #44b6ae !important;
  color: #FFFFFF !important; }

.progress-bar.green-jungle {
  background: #26C281 !important;
  color: #FFFFFF !important; }

.progress-bar.green-soft {
  background: #3faba4 !important;
  color: #FFFFFF !important; }

.progress-bar.green-dark {
  background: #4DB3A2 !important;
  color: #FFFFFF !important; }

.progress-bar.green-sharp {
  background: #2ab4c0 !important;
  color: #FFFFFF !important; }

.progress-bar.green-steel {
  background: #29b4b6 !important;
  color: #FFFFFF !important; }

.progress-bar.grey {
  background: #E5E5E5 !important;
  color: #333333 !important; }

.progress-bar.grey-steel {
  background: #e9edef !important;
  color: #80898e !important; }

.progress-bar.grey-cararra {
  background: #fafafa !important;
  color: #333333 !important; }

.progress-bar.grey-gallery {
  background: #555555 !important;
  color: #ffffff !important; }

.progress-bar.grey-cascade {
  background: #95A5A6 !important;
  color: #FFFFFF !important; }

.progress-bar.grey-silver {
  background: #BFBFBF !important;
  color: #FAFCFB !important; }

.progress-bar.grey-salsa {
  background: #ACB5C3 !important;
  color: #FAFCFB !important; }

.progress-bar.grey-salt {
  background: #bfcad1 !important;
  color: #FAFCFB !important; }

.progress-bar.grey-mint {
  background: #525e64 !important;
  color: #FFFFFF !important; }

.progress-bar.red {
  background: #e7505a !important;
  color: #ffffff !important; }

.progress-bar.red-pink {
  background: #E08283 !important;
  color: #ffffff !important; }

.progress-bar.red-sunglo {
  background: #E26A6A !important;
  color: #ffffff !important; }

.progress-bar.red-intense {
  background: #e35b5a !important;
  color: #ffffff !important; }

.progress-bar.red-thunderbird {
  background: #D91E18 !important;
  color: #ffffff !important; }

.progress-bar.red-flamingo {
  background: #EF4836 !important;
  color: #ffffff !important; }

.progress-bar.red-soft {
  background: #d05454 !important;
  color: #ffffff !important; }

.progress-bar.red-haze {
  background: #f36a5a !important;
  color: #ffffff !important; }

.progress-bar.red-mint {
  background: #e43a45 !important;
  color: #ffffff !important; }

.progress-bar.yellow {
  background: #c49f47 !important;
  color: #ffffff !important; }

.progress-bar.yellow-gold {
  background: #E87E04 !important;
  color: #ffffff !important; }

.progress-bar.yellow-casablanca {
  background: #f2784b !important;
  color: #ffffff !important; }

.progress-bar.yellow-crusta {
  background: #f3c200 !important;
  color: #ffffff !important; }

.progress-bar.yellow-lemon {
  background: #F7CA18 !important;
  color: #ffffff !important; }

.progress-bar.yellow-saffron {
  background: #F4D03F !important;
  color: #ffffff !important; }

.progress-bar.yellow-soft {
  background: #c8d046 !important;
  color: #ffffff !important; }

.progress-bar.yellow-haze {
  background: #c5bf66 !important;
  color: #ffffff !important; }

.progress-bar.yellow-mint {
  background: #c5b96b !important;
  color: #ffffff !important; }

.progress-bar.purple {
  background: #8E44AD !important;
  color: #ffffff !important; }

.progress-bar.purple-plum {
  background: #8775a7 !important;
  color: #ffffff !important; }

.progress-bar.purple-medium {
  background: #BF55EC !important;
  color: #ffffff !important; }

.progress-bar.purple-studio {
  background: #8E44AD !important;
  color: #ffffff !important; }

.progress-bar.purple-wisteria {
  background: #9B59B6 !important;
  color: #ffffff !important; }

.progress-bar.purple-seance {
  background: #9A12B3 !important;
  color: #ffffff !important; }

.progress-bar.purple-intense {
  background: #8775a7 !important;
  color: #ffffff !important; }

.progress-bar.purple-sharp {
  background: #796799 !important;
  color: #ffffff !important; }

.progress-bar.purple-soft {
  background: #8877a9 !important;
  color: #ffffff !important; }

.progress {
  height: 8px;
  border-radius: 0 !important; }
  .progress.progress-sm {
    height: 6px; }

/***
Dashboard Stats
***/
.dashboard-stat {
  display: block;
  margin-bottom: 25px;
  overflow: hidden;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  box-shadow: 0px 2px 3px 2px rgba(0, 0, 0, 0.03); }
  .dashboard-stat:before, .dashboard-stat:after {
    content: " ";
    display: table; }
  .dashboard-stat:after {
    clear: both; }
  .portlet .dashboard-stat:last-child {
    margin-bottom: 0; }
  .dashboard-stat .visual {
    width: 80px;
    height: 80px;
    display: block;
    float: left;
    padding-top: 10px;
    padding-left: 15px;
    margin-bottom: 15px;
    font-size: 35px;
    line-height: 35px; }
    .dashboard-stat .visual > i {
      margin-left: -35px;
      font-size: 110px;
      line-height: 110px; }
  .dashboard-stat .details {
    position: absolute;
    right: 15px;
    padding-right: 15px; }
    .dashboard-stat .details .number {
      padding-top: 25px;
      text-align: right;
      font-size: 34px;
      line-height: 36px;
      letter-spacing: -1px;
      margin-bottom: 0px;
      font-weight: 300; }
    .dashboard-stat .details .desc {
      text-align: right;
      font-size: 16px;
      letter-spacing: 0px;
      font-weight: 300; }
  .dashboard-stat .more {
    clear: both;
    display: block;
    padding: 6px 10px 6px 10px;
    position: relative;
    text-transform: uppercase;
    font-weight: 300;
    font-size: 11px;
    opacity: 0.7;
    filter: alpha(opacity=70); }
    .dashboard-stat .more:hover {
      text-decoration: none;
      opacity: 0.9;
      filter: alpha(opacity=90); }
    .dashboard-stat .more > i {
      display: inline-block;
      margin-top: 1px;
      float: right; }
  .dashboard-stat.dashboard-stat-v2 .visual {
    padding-top: 35px;
    margin-bottom: 40px; }

.dashboard-stat.white {
  background-color: #ffffff; }
  .dashboard-stat.white.dashboard-stat-light:hover {
    background-color: whitesmoke; }
  .dashboard-stat.white .visual > i {
    color: #666;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.white .details .number {
    color: #666; }
  .dashboard-stat.white .details .desc {
    color: #666;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.white .more {
    color: #666;
    background-color: whitesmoke; }

.dashboard-stat.default {
  background-color: #e1e5ec; }
  .dashboard-stat.default.dashboard-stat-light:hover {
    background-color: #d5dae4; }
  .dashboard-stat.default .visual > i {
    color: #666;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.default .details .number {
    color: #666; }
  .dashboard-stat.default .details .desc {
    color: #666;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.default .more {
    color: #666;
    background-color: #d5dae4; }

.dashboard-stat.dark {
  background-color: #2f353b; }
  .dashboard-stat.dark.dashboard-stat-light:hover {
    background-color: #262b30; }
  .dashboard-stat.dark .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.dark .details .number {
    color: #FFFFFF; }
  .dashboard-stat.dark .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.dark .more {
    color: #FFFFFF;
    background-color: #262b30; }

.dashboard-stat.blue {
  background-color: #3598dc; }
  .dashboard-stat.blue.dashboard-stat-light:hover {
    background-color: #258fd7; }
  .dashboard-stat.blue .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue .more {
    color: #FFFFFF;
    background-color: #258fd7; }

.dashboard-stat.blue-madison {
  background-color: #578ebe; }
  .dashboard-stat.blue-madison.dashboard-stat-light:hover {
    background-color: #4884b8; }
  .dashboard-stat.blue-madison .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-madison .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-madison .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-madison .more {
    color: #FFFFFF;
    background-color: #4884b8; }

.dashboard-stat.blue-chambray {
  background-color: #2C3E50; }
  .dashboard-stat.blue-chambray.dashboard-stat-light:hover {
    background-color: #253443; }
  .dashboard-stat.blue-chambray .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-chambray .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-chambray .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-chambray .more {
    color: #FFFFFF;
    background-color: #253443; }

.dashboard-stat.blue-ebonyclay {
  background-color: #22313F; }
  .dashboard-stat.blue-ebonyclay.dashboard-stat-light:hover {
    background-color: #1b2732; }
  .dashboard-stat.blue-ebonyclay .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-ebonyclay .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-ebonyclay .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-ebonyclay .more {
    color: #FFFFFF;
    background-color: #1b2732; }

.dashboard-stat.blue-hoki {
  background-color: #67809F; }
  .dashboard-stat.blue-hoki.dashboard-stat-light:hover {
    background-color: #5e7694; }
  .dashboard-stat.blue-hoki .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-hoki .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-hoki .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-hoki .more {
    color: #FFFFFF;
    background-color: #5e7694; }

.dashboard-stat.blue-steel {
  background-color: #4B77BE; }
  .dashboard-stat.blue-steel.dashboard-stat-light:hover {
    background-color: #416db4; }
  .dashboard-stat.blue-steel .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-steel .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-steel .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-steel .more {
    color: #FFFFFF;
    background-color: #416db4; }

.dashboard-stat.blue-soft {
  background-color: #4c87b9; }
  .dashboard-stat.blue-soft.dashboard-stat-light:hover {
    background-color: #447dad; }
  .dashboard-stat.blue-soft .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-soft .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-soft .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-soft .more {
    color: #FFFFFF;
    background-color: #447dad; }

.dashboard-stat.blue-dark {
  background-color: #5e738b; }
  .dashboard-stat.blue-dark.dashboard-stat-light:hover {
    background-color: #56697f; }
  .dashboard-stat.blue-dark .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-dark .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-dark .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-dark .more {
    color: #FFFFFF;
    background-color: #56697f; }

.dashboard-stat.blue-sharp {
  background-color: #5C9BD1; }
  .dashboard-stat.blue-sharp.dashboard-stat-light:hover {
    background-color: #4c91cd; }
  .dashboard-stat.blue-sharp .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-sharp .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-sharp .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-sharp .more {
    color: #FFFFFF;
    background-color: #4c91cd; }

.dashboard-stat.blue-oleo {
  background-color: #94A0B2; }
  .dashboard-stat.blue-oleo.dashboard-stat-light:hover {
    background-color: #8895a9; }
  .dashboard-stat.blue-oleo .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.blue-oleo .details .number {
    color: #FFFFFF; }
  .dashboard-stat.blue-oleo .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.blue-oleo .more {
    color: #FFFFFF;
    background-color: #8895a9; }

.dashboard-stat.green {
  background-color: #32c5d2; }
  .dashboard-stat.green.dashboard-stat-light:hover {
    background-color: #2bb8c4; }
  .dashboard-stat.green .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green .more {
    color: #FFFFFF;
    background-color: #2bb8c4; }

.dashboard-stat.green-meadow {
  background-color: #1BBC9B; }
  .dashboard-stat.green-meadow.dashboard-stat-light:hover {
    background-color: #18aa8c; }
  .dashboard-stat.green-meadow .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-meadow .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-meadow .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-meadow .more {
    color: #FFFFFF;
    background-color: #18aa8c; }

.dashboard-stat.green-seagreen {
  background-color: #1BA39C; }
  .dashboard-stat.green-seagreen.dashboard-stat-light:hover {
    background-color: #18918b; }
  .dashboard-stat.green-seagreen .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-seagreen .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-seagreen .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-seagreen .more {
    color: #FFFFFF;
    background-color: #18918b; }

.dashboard-stat.green-turquoise {
  background-color: #36D7B7; }
  .dashboard-stat.green-turquoise.dashboard-stat-light:hover {
    background-color: #29cfae; }
  .dashboard-stat.green-turquoise .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-turquoise .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-turquoise .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-turquoise .more {
    color: #FFFFFF;
    background-color: #29cfae; }

.dashboard-stat.green-haze {
  background-color: #44b6ae; }
  .dashboard-stat.green-haze.dashboard-stat-light:hover {
    background-color: #3ea7a0; }
  .dashboard-stat.green-haze .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-haze .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-haze .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-haze .more {
    color: #FFFFFF;
    background-color: #3ea7a0; }

.dashboard-stat.green-jungle {
  background-color: #26C281; }
  .dashboard-stat.green-jungle.dashboard-stat-light:hover {
    background-color: #23b176; }
  .dashboard-stat.green-jungle .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-jungle .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-jungle .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-jungle .more {
    color: #FFFFFF;
    background-color: #23b176; }

.dashboard-stat.green-soft {
  background-color: #3faba4; }
  .dashboard-stat.green-soft.dashboard-stat-light:hover {
    background-color: #3a9c96; }
  .dashboard-stat.green-soft .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-soft .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-soft .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-soft .more {
    color: #FFFFFF;
    background-color: #3a9c96; }

.dashboard-stat.green-dark {
  background-color: #4DB3A2; }
  .dashboard-stat.green-dark.dashboard-stat-light:hover {
    background-color: #46a595; }
  .dashboard-stat.green-dark .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-dark .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-dark .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-dark .more {
    color: #FFFFFF;
    background-color: #46a595; }

.dashboard-stat.green-sharp {
  background-color: #2ab4c0; }
  .dashboard-stat.green-sharp.dashboard-stat-light:hover {
    background-color: #26a4af; }
  .dashboard-stat.green-sharp .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-sharp .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-sharp .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-sharp .more {
    color: #FFFFFF;
    background-color: #26a4af; }

.dashboard-stat.green-steel {
  background-color: #29b4b6; }
  .dashboard-stat.green-steel.dashboard-stat-light:hover {
    background-color: #25a4a5; }
  .dashboard-stat.green-steel .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.green-steel .details .number {
    color: #FFFFFF; }
  .dashboard-stat.green-steel .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.green-steel .more {
    color: #FFFFFF;
    background-color: #25a4a5; }

.dashboard-stat.grey {
  background-color: #E5E5E5; }
  .dashboard-stat.grey.dashboard-stat-light:hover {
    background-color: #dbdbdb; }
  .dashboard-stat.grey .visual > i {
    color: #333333;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey .details .number {
    color: #333333; }
  .dashboard-stat.grey .details .desc {
    color: #333333;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey .more {
    color: #333333;
    background-color: #dbdbdb; }

.dashboard-stat.grey-steel {
  background-color: #e9edef; }
  .dashboard-stat.grey-steel.dashboard-stat-light:hover {
    background-color: #dde3e6; }
  .dashboard-stat.grey-steel .visual > i {
    color: #80898e;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-steel .details .number {
    color: #80898e; }
  .dashboard-stat.grey-steel .details .desc {
    color: #80898e;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-steel .more {
    color: #80898e;
    background-color: #dde3e6; }

.dashboard-stat.grey-cararra {
  background-color: #fafafa; }
  .dashboard-stat.grey-cararra.dashboard-stat-light:hover {
    background-color: #f0f0f0; }
  .dashboard-stat.grey-cararra .visual > i {
    color: #333333;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-cararra .details .number {
    color: #333333; }
  .dashboard-stat.grey-cararra .details .desc {
    color: #333333;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-cararra .more {
    color: #333333;
    background-color: #f0f0f0; }

.dashboard-stat.grey-gallery {
  background-color: #555555; }
  .dashboard-stat.grey-gallery.dashboard-stat-light:hover {
    background-color: #4b4b4b; }
  .dashboard-stat.grey-gallery .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-gallery .details .number {
    color: #ffffff; }
  .dashboard-stat.grey-gallery .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-gallery .more {
    color: #ffffff;
    background-color: #4b4b4b; }

.dashboard-stat.grey-cascade {
  background-color: #95A5A6; }
  .dashboard-stat.grey-cascade.dashboard-stat-light:hover {
    background-color: #8a9c9d; }
  .dashboard-stat.grey-cascade .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-cascade .details .number {
    color: #FFFFFF; }
  .dashboard-stat.grey-cascade .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-cascade .more {
    color: #FFFFFF;
    background-color: #8a9c9d; }

.dashboard-stat.grey-silver {
  background-color: #BFBFBF; }
  .dashboard-stat.grey-silver.dashboard-stat-light:hover {
    background-color: #b5b5b5; }
  .dashboard-stat.grey-silver .visual > i {
    color: #FAFCFB;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-silver .details .number {
    color: #FAFCFB; }
  .dashboard-stat.grey-silver .details .desc {
    color: #FAFCFB;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-silver .more {
    color: #FAFCFB;
    background-color: #b5b5b5; }

.dashboard-stat.grey-salsa {
  background-color: #ACB5C3; }
  .dashboard-stat.grey-salsa.dashboard-stat-light:hover {
    background-color: #a0aaba; }
  .dashboard-stat.grey-salsa .visual > i {
    color: #FAFCFB;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-salsa .details .number {
    color: #FAFCFB; }
  .dashboard-stat.grey-salsa .details .desc {
    color: #FAFCFB;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-salsa .more {
    color: #FAFCFB;
    background-color: #a0aaba; }

.dashboard-stat.grey-salt {
  background-color: #bfcad1; }
  .dashboard-stat.grey-salt.dashboard-stat-light:hover {
    background-color: #b3c0c8; }
  .dashboard-stat.grey-salt .visual > i {
    color: #FAFCFB;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-salt .details .number {
    color: #FAFCFB; }
  .dashboard-stat.grey-salt .details .desc {
    color: #FAFCFB;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-salt .more {
    color: #FAFCFB;
    background-color: #b3c0c8; }

.dashboard-stat.grey-mint {
  background-color: #525e64; }
  .dashboard-stat.grey-mint.dashboard-stat-light:hover {
    background-color: #495359; }
  .dashboard-stat.grey-mint .visual > i {
    color: #FFFFFF;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.grey-mint .details .number {
    color: #FFFFFF; }
  .dashboard-stat.grey-mint .details .desc {
    color: #FFFFFF;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.grey-mint .more {
    color: #FFFFFF;
    background-color: #495359; }

.dashboard-stat.red {
  background-color: #e7505a; }
  .dashboard-stat.red.dashboard-stat-light:hover {
    background-color: #e53e49; }
  .dashboard-stat.red .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red .details .number {
    color: #ffffff; }
  .dashboard-stat.red .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red .more {
    color: #ffffff;
    background-color: #e53e49; }

.dashboard-stat.red-pink {
  background-color: #E08283; }
  .dashboard-stat.red-pink.dashboard-stat-light:hover {
    background-color: #dc7273; }
  .dashboard-stat.red-pink .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-pink .details .number {
    color: #ffffff; }
  .dashboard-stat.red-pink .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-pink .more {
    color: #ffffff;
    background-color: #dc7273; }

.dashboard-stat.red-sunglo {
  background-color: #E26A6A; }
  .dashboard-stat.red-sunglo.dashboard-stat-light:hover {
    background-color: #df5959; }
  .dashboard-stat.red-sunglo .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-sunglo .details .number {
    color: #ffffff; }
  .dashboard-stat.red-sunglo .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-sunglo .more {
    color: #ffffff;
    background-color: #df5959; }

.dashboard-stat.red-intense {
  background-color: #e35b5a; }
  .dashboard-stat.red-intense.dashboard-stat-light:hover {
    background-color: #e04a49; }
  .dashboard-stat.red-intense .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-intense .details .number {
    color: #ffffff; }
  .dashboard-stat.red-intense .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-intense .more {
    color: #ffffff;
    background-color: #e04a49; }

.dashboard-stat.red-thunderbird {
  background-color: #D91E18; }
  .dashboard-stat.red-thunderbird.dashboard-stat-light:hover {
    background-color: #c71b16; }
  .dashboard-stat.red-thunderbird .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-thunderbird .details .number {
    color: #ffffff; }
  .dashboard-stat.red-thunderbird .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-thunderbird .more {
    color: #ffffff;
    background-color: #c71b16; }

.dashboard-stat.red-flamingo {
  background-color: #EF4836; }
  .dashboard-stat.red-flamingo.dashboard-stat-light:hover {
    background-color: #ed3723; }
  .dashboard-stat.red-flamingo .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-flamingo .details .number {
    color: #ffffff; }
  .dashboard-stat.red-flamingo .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-flamingo .more {
    color: #ffffff;
    background-color: #ed3723; }

.dashboard-stat.red-soft {
  background-color: #d05454; }
  .dashboard-stat.red-soft.dashboard-stat-light:hover {
    background-color: #cc4444; }
  .dashboard-stat.red-soft .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-soft .details .number {
    color: #ffffff; }
  .dashboard-stat.red-soft .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-soft .more {
    color: #ffffff;
    background-color: #cc4444; }

.dashboard-stat.red-haze {
  background-color: #f36a5a; }
  .dashboard-stat.red-haze.dashboard-stat-light:hover {
    background-color: #f25947; }
  .dashboard-stat.red-haze .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-haze .details .number {
    color: #ffffff; }
  .dashboard-stat.red-haze .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-haze .more {
    color: #ffffff;
    background-color: #f25947; }

.dashboard-stat.red-mint {
  background-color: #e43a45; }
  .dashboard-stat.red-mint.dashboard-stat-light:hover {
    background-color: #e22834; }
  .dashboard-stat.red-mint .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.red-mint .details .number {
    color: #ffffff; }
  .dashboard-stat.red-mint .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.red-mint .more {
    color: #ffffff;
    background-color: #e22834; }

.dashboard-stat.yellow {
  background-color: #c49f47; }
  .dashboard-stat.yellow.dashboard-stat-light:hover {
    background-color: #bb953c; }
  .dashboard-stat.yellow .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow .more {
    color: #ffffff;
    background-color: #bb953c; }

.dashboard-stat.yellow-gold {
  background-color: #E87E04; }
  .dashboard-stat.yellow-gold.dashboard-stat-light:hover {
    background-color: #d47304; }
  .dashboard-stat.yellow-gold .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-gold .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-gold .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-gold .more {
    color: #ffffff;
    background-color: #d47304; }

.dashboard-stat.yellow-casablanca {
  background-color: #f2784b; }
  .dashboard-stat.yellow-casablanca.dashboard-stat-light:hover {
    background-color: #f16a38; }
  .dashboard-stat.yellow-casablanca .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-casablanca .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-casablanca .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-casablanca .more {
    color: #ffffff;
    background-color: #f16a38; }

.dashboard-stat.yellow-crusta {
  background-color: #f3c200; }
  .dashboard-stat.yellow-crusta.dashboard-stat-light:hover {
    background-color: #dfb200; }
  .dashboard-stat.yellow-crusta .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-crusta .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-crusta .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-crusta .more {
    color: #ffffff;
    background-color: #dfb200; }

.dashboard-stat.yellow-lemon {
  background-color: #F7CA18; }
  .dashboard-stat.yellow-lemon.dashboard-stat-light:hover {
    background-color: #f2c308; }
  .dashboard-stat.yellow-lemon .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-lemon .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-lemon .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-lemon .more {
    color: #ffffff;
    background-color: #f2c308; }

.dashboard-stat.yellow-saffron {
  background-color: #F4D03F; }
  .dashboard-stat.yellow-saffron.dashboard-stat-light:hover {
    background-color: #f3cb2c; }
  .dashboard-stat.yellow-saffron .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-saffron .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-saffron .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-saffron .more {
    color: #ffffff;
    background-color: #f3cb2c; }

.dashboard-stat.yellow-soft {
  background-color: #c8d046; }
  .dashboard-stat.yellow-soft.dashboard-stat-light:hover {
    background-color: #c3cc36; }
  .dashboard-stat.yellow-soft .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-soft .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-soft .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-soft .more {
    color: #ffffff;
    background-color: #c3cc36; }

.dashboard-stat.yellow-haze {
  background-color: #c5bf66; }
  .dashboard-stat.yellow-haze.dashboard-stat-light:hover {
    background-color: #bfb957; }
  .dashboard-stat.yellow-haze .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-haze .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-haze .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-haze .more {
    color: #ffffff;
    background-color: #bfb957; }

.dashboard-stat.yellow-mint {
  background-color: #c5b96b; }
  .dashboard-stat.yellow-mint.dashboard-stat-light:hover {
    background-color: #bfb25c; }
  .dashboard-stat.yellow-mint .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.yellow-mint .details .number {
    color: #ffffff; }
  .dashboard-stat.yellow-mint .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.yellow-mint .more {
    color: #ffffff;
    background-color: #bfb25c; }

.dashboard-stat.purple {
  background-color: #8E44AD; }
  .dashboard-stat.purple.dashboard-stat-light:hover {
    background-color: #823e9e; }
  .dashboard-stat.purple .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple .details .number {
    color: #ffffff; }
  .dashboard-stat.purple .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple .more {
    color: #ffffff;
    background-color: #823e9e; }

.dashboard-stat.purple-plum {
  background-color: #8775a7; }
  .dashboard-stat.purple-plum.dashboard-stat-light:hover {
    background-color: #7c699f; }
  .dashboard-stat.purple-plum .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-plum .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-plum .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-plum .more {
    color: #ffffff;
    background-color: #7c699f; }

.dashboard-stat.purple-medium {
  background-color: #BF55EC; }
  .dashboard-stat.purple-medium.dashboard-stat-light:hover {
    background-color: #b843ea; }
  .dashboard-stat.purple-medium .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-medium .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-medium .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-medium .more {
    color: #ffffff;
    background-color: #b843ea; }

.dashboard-stat.purple-studio {
  background-color: #8E44AD; }
  .dashboard-stat.purple-studio.dashboard-stat-light:hover {
    background-color: #823e9e; }
  .dashboard-stat.purple-studio .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-studio .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-studio .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-studio .more {
    color: #ffffff;
    background-color: #823e9e; }

.dashboard-stat.purple-wisteria {
  background-color: #9B59B6; }
  .dashboard-stat.purple-wisteria.dashboard-stat-light:hover {
    background-color: #924dae; }
  .dashboard-stat.purple-wisteria .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-wisteria .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-wisteria .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-wisteria .more {
    color: #ffffff;
    background-color: #924dae; }

.dashboard-stat.purple-seance {
  background-color: #9A12B3; }
  .dashboard-stat.purple-seance.dashboard-stat-light:hover {
    background-color: #8a10a0; }
  .dashboard-stat.purple-seance .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-seance .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-seance .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-seance .more {
    color: #ffffff;
    background-color: #8a10a0; }

.dashboard-stat.purple-intense {
  background-color: #8775a7; }
  .dashboard-stat.purple-intense.dashboard-stat-light:hover {
    background-color: #7c699f; }
  .dashboard-stat.purple-intense .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-intense .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-intense .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-intense .more {
    color: #ffffff;
    background-color: #7c699f; }

.dashboard-stat.purple-sharp {
  background-color: #796799; }
  .dashboard-stat.purple-sharp.dashboard-stat-light:hover {
    background-color: #6f5f8d; }
  .dashboard-stat.purple-sharp .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-sharp .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-sharp .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-sharp .more {
    color: #ffffff;
    background-color: #6f5f8d; }

.dashboard-stat.purple-soft {
  background-color: #8877a9; }
  .dashboard-stat.purple-soft.dashboard-stat-light:hover {
    background-color: #7d6ba1; }
  .dashboard-stat.purple-soft .visual > i {
    color: #ffffff;
    opacity: 0.1;
    filter: alpha(opacity=10); }
  .dashboard-stat.purple-soft .details .number {
    color: #ffffff; }
  .dashboard-stat.purple-soft .details .desc {
    color: #ffffff;
    opacity: 1;
    filter: alpha(opacity=100); }
  .dashboard-stat.purple-soft .more {
    color: #ffffff;
    background-color: #7d6ba1; }

.dashboard-stat-light {
  padding-bottom: 20px;
  margin-bottom: 20px; }
  .dashboard-stat-light .details {
    margin-bottom: 5px; }
    .dashboard-stat-light .details .number {
      font-weight: 300;
      margin-bottom: 0px; }

/***
Dashboard Stats 2
***/
.dashboard-stat2 {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  background: #fff;
  padding: 15px 15px 30px 15px;
  margin-bottom: 20px;
  box-shadow: 0px 2px 3px 2px rgba(0, 0, 0, 0.03); }
  .dashboard-stat2.bordered {
    border: 1px solid #e7ecf1; }
  .dashboard-stat2 .display {
    margin-bottom: 20px; }
    .dashboard-stat2 .display:before, .dashboard-stat2 .display:after {
      content: " ";
      display: table; }
    .dashboard-stat2 .display:after {
      clear: both; }
    .dashboard-stat2 .display .number {
      float: left;
      display: inline-block; }
      .dashboard-stat2 .display .number h3 {
        margin: 0 0 2px 0;
        padding: 0;
        font-size: 30px;
        font-weight: 400; }
        .dashboard-stat2 .display .number h3 > small {
          font-size: 23px; }
      .dashboard-stat2 .display .number small {
        font-size: 14px;
        color: #AAB5BC;
        font-weight: 600;
        text-transform: uppercase; }
    .dashboard-stat2 .display .icon {
      display: inline-block;
      float: right;
      padding: 7px 0 0 0; }
      .dashboard-stat2 .display .icon > i {
        color: #cbd4e0;
        font-size: 26px; }
  .dashboard-stat2 .progress-info {
    clear: both; }
    .dashboard-stat2 .progress-info .progress {
      margin: 0;
      height: 4px;
      clear: both;
      display: block; }
    .dashboard-stat2 .progress-info .status {
      margin-top: 5px;
      font-size: 11px;
      color: #AAB5BC;
      font-weight: 600;
      text-transform: uppercase; }
      .dashboard-stat2 .progress-info .status .status-title {
        float: left;
        display: inline-block; }
      .dashboard-stat2 .progress-info .status .status-number {
        float: right;
        display: inline-block; }

/***
Text Stats
***/
.text-stat h3 {
  margin-top: 5px;
  margin-bottom: 0px;
  font-size: 18px; }
.text-stat span {
  font-size: 13px !important; }

@media (max-width: 767px) {
  /* 767px */
  .text-stat {
    margin-top: 20px; } }
/***
Social Icons
***/
.social-icons {
  padding: 0;
  margin: 0; }
  .social-icons:before, .social-icons:after {
    content: " ";
    display: table; }
  .social-icons:after {
    clear: both; }
  .social-icons li {
    float: left;
    display: inline;
    list-style: none;
    margin-right: 5px;
    margin-bottom: 5px;
    text-indent: -9999px; }
    .social-icons li > a {
      -webkit-border-radius: 2px;
      -moz-border-radius: 2px;
      -ms-border-radius: 2px;
      -o-border-radius: 2px;
      border-radius: 2px;
      width: 28px;
      height: 28px;
      display: block;
      background-position: 0 0;
      background-repeat: no-repeat;
      transition: all 0.3s ease-in-out;
      -o-transition: all 0.3s ease-in-out;
      -ms-transition: all 0.3s ease-in-out;
      -moz-transition: all 0.3s ease-in-out;
      -webkit-transition: all 0.3s ease-in-out; }
    .social-icons li:hover > a {
      background-position: 0 -38px; }
    .social-icons li .amazon {
      background: url(../img/social/amazon.png) no-repeat; }
    .social-icons li .behance {
      background: url(../img/social/behance.png) no-repeat; }
    .social-icons li .blogger {
      background: url(../img/social/blogger.png) no-repeat; }
    .social-icons li .deviantart {
      background: url(../img/social/deviantart.png) no-repeat; }
    .social-icons li .dribbble {
      background: url(../img/social/dribbble.png) no-repeat; }
    .social-icons li .dropbox {
      background: url(../img/social/dropbox.png) no-repeat; }
    .social-icons li .evernote {
      background: url(../img/social/evernote.png) no-repeat; }
    .social-icons li .facebook {
      background: url(../img/social/facebook.png) no-repeat; }
    .social-icons li .forrst {
      background: url(../img/social/forrst.png) no-repeat; }
    .social-icons li .github {
      background: url(../img/social/github.png) no-repeat; }
    .social-icons li .googleplus {
      background: url(../img/social/googleplus.png) no-repeat; }
    .social-icons li .jolicloud {
      background: url(../img/social/jolicloud.png) no-repeat; }
    .social-icons li .last-fm {
      background: url(../img/social/last-fm.png) no-repeat; }
    .social-icons li .linkedin {
      background: url(../img/social/linkedin.png) no-repeat; }
    .social-icons li .picasa {
      background: url(../img/social/picasa.png) no-repeat; }
    .social-icons li .pintrest {
      background: url(../img/social/pintrest.png) no-repeat; }
    .social-icons li .rss {
      background: url(../img/social/rss.png) no-repeat; }
    .social-icons li .skype {
      background: url(../img/social/skype.png) no-repeat; }
    .social-icons li .spotify {
      background: url(../img/social/spotify.png) no-repeat; }
    .social-icons li .stumbleupon {
      background: url(../img/social/stumbleupon.png) no-repeat; }
    .social-icons li .tumblr {
      background: url(../img/social/tumblr.png) no-repeat; }
    .social-icons li .twitter {
      background: url(../img/social/twitter.png) no-repeat; }
    .social-icons li .vimeo {
      background: url(../img/social/vimeo.png) no-repeat; }
    .social-icons li .wordpress {
      background: url(../img/social/wordpress.png) no-repeat; }
    .social-icons li .xing {
      background: url(../img/social/xing.png) no-repeat; }
    .social-icons li .yahoo {
      background: url(../img/social/yahoo.png) no-repeat; }
    .social-icons li .youtube {
      background: url(../img/social/youtube.png) no-repeat; }
    .social-icons li .vk {
      background: url(../img/social/vk.png) no-repeat; }
    .social-icons li .instagram {
      background: url(../img/social/instagram.png) no-repeat; }
    .social-icons li .reddit {
      background: url(../img/social/reddit.png) no-repeat; }
    .social-icons li .aboutme {
      background: url(../img/social/aboutme.png) no-repeat; }
    .social-icons li .flickr {
      background: url(../img/social/flickr.png) no-repeat; }
    .social-icons li .foursquare {
      background: url(../img/social/foursquare.png) no-repeat; }
    .social-icons li .gravatar {
      background: url(../img/social/gravatar.png) no-repeat; }
    .social-icons li .klout {
      background: url(../img/social/klout.png) no-repeat; }
    .social-icons li .myspace {
      background: url(../img/social/myspace.png) no-repeat; }
    .social-icons li .quora {
      background: url(../img/social/quora.png) no-repeat; }
  .social-icons.social-icons-color > li > a {
    opacity: 0.7;
    background-position: 0 -38px !important; }
    .social-icons.social-icons-color > li > a:hover {
      opacity: 1; }
  .social-icons.social-icons-circle > li > a {
    border-radius: 25px !important; }

/***
Inline Social Icons
***/
.social-icon {
  display: inline-block !important;
  width: 28px;
  height: 28px;
  background-position: 0 0;
  background-repeat: no-repeat;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px;
  transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -webkit-transition: all 0.3s ease-in-out; }
  .social-icon.social-icon-circle {
    border-radius: 25px !important; }

.social-icon.amazon {
  background: url(../img/social/amazon.png) no-repeat; }
.social-icon.behance {
  background: url(../img/social/behance.png) no-repeat; }
.social-icon.blogger {
  background: url(../img/social/blogger.png) no-repeat; }
.social-icon.deviantart {
  background: url(../img/social/deviantart.png) no-repeat; }
.social-icon.dribbble {
  background: url(../img/social/dribbble.png) no-repeat; }
.social-icon.dropbox {
  background: url(../img/social/dropbox.png) no-repeat; }
.social-icon.evernote {
  background: url(../img/social/evernote.png) no-repeat; }
.social-icon.facebook {
  background: url(../img/social/facebook.png) no-repeat; }
.social-icon.forrst {
  background: url(../img/social/forrst.png) no-repeat; }
.social-icon.github {
  background: url(../img/social/github.png) no-repeat; }
.social-icon.googleplus {
  background: url(../img/social/googleplus.png) no-repeat; }
.social-icon.jolicloud {
  background: url(../img/social/jolicloud.png) no-repeat; }
.social-icon.last-fm {
  background: url(../img/social/last-fm.png) no-repeat; }
.social-icon.linkedin {
  background: url(../img/social/linkedin.png) no-repeat; }
.social-icon.picasa {
  background: url(../img/social/picasa.png) no-repeat; }
.social-icon.pintrest {
  background: url(../img/social/pintrest.png) no-repeat; }
.social-icon.rss {
  background: url(../img/social/rss.png) no-repeat; }
.social-icon.skype {
  background: url(../img/social/skype.png) no-repeat; }
.social-icon.spotify {
  background: url(../img/social/spotify.png) no-repeat; }
.social-icon.stumbleupon {
  background: url(../img/social/stumbleupon.png) no-repeat; }
.social-icon.tumblr {
  background: url(../img/social/tumblr.png) no-repeat; }
.social-icon.twitter {
  background: url(../img/social/twitter.png) no-repeat; }
.social-icon.vimeo {
  background: url(../img/social/vimeo.png) no-repeat; }
.social-icon.wordpress {
  background: url(../img/social/wordpress.png) no-repeat; }
.social-icon.xing {
  background: url(../img/social/xing.png) no-repeat; }
.social-icon.yahoo {
  background: url(../img/social/yahoo.png) no-repeat; }
.social-icon.youtube {
  background: url(../img/social/youtube.png) no-repeat; }
.social-icon.vk {
  background: url(../img/social/vk.png) no-repeat; }
.social-icon.instagram {
  background: url(../img/social/instagram.png) no-repeat; }
.social-icon.reddit {
  background: url(../img/social/reddit.png) no-repeat; }
.social-icon.aboutme {
  background: url(../img/social/aboutme.png) no-repeat; }
.social-icon.flickr {
  background: url(../img/social/flickr.png) no-repeat; }
.social-icon.foursquare {
  background: url(../img/social/foursquare.png) no-repeat; }
.social-icon.gravatar {
  background: url(../img/social/gravatar.png) no-repeat; }
.social-icon.klout {
  background: url(../img/social/klout.png) no-repeat; }
.social-icon.myspace {
  background: url(../img/social/myspace.png) no-repeat; }
.social-icon.quora {
  background: url(../img/social/quora.png) no-repeat; }
.social-icon:hover {
  background-position: 0 -38px; }

.social-icon-color {
  opacity: 0.7;
  background-position: 0 -38px !important; }
  .social-icon-color:hover {
    opacity: 1; }

/***
Scrollable Tables
***/
.table-scrollable {
  width: 100%;
  overflow-x: auto;
  overflow-y: hidden;
  border: 1px solid #e7ecf1;
  margin: 10px 0 !important; }
  .DTS .table-scrollable {
    border: 0; }
  .table-scrollable.table-scrollable-borderless {
    border: 0; }
  .table-scrollable > .table {
    width: 100% !important;
    margin: 0 !important;
    margin-bottom: 0;
    background-color: #fff; }
    .table-scrollable > .table > thead > tr > th,
    .table-scrollable > .table > tbody > tr > th,
    .table-scrollable > .table > tfoot > tr > th,
    .table-scrollable > .table > tfoot > tr > th,
    .table-scrollable > .table > tfoot > tr > td {
      white-space: nowrap; }
  .table-scrollable > .table-bordered {
    border: 0; }
    .table-scrollable > .table-bordered > thead > tr > th:first-child,
    .table-scrollable > .table-bordered > tbody > tr > th:first-child,
    .table-scrollable > .table-bordered > tfoot > tr > th:first-child,
    .table-scrollable > .table-bordered > thead > tr > td:first-child,
    .table-scrollable > .table-bordered > tbody > tr > td:first-child,
    .table-scrollable > .table-bordered > tfoot > tr > td:first-child {
      border-left: 0; }
    .table-scrollable > .table-bordered > thead > tr > th:last-child,
    .table-scrollable > .table-bordered > tbody > tr > th:last-child,
    .table-scrollable > .table-bordered > tfoot > tr > th:last-child,
    .table-scrollable > .table-bordered > thead > tr > td:last-child,
    .table-scrollable > .table-bordered > tbody > tr > td:last-child,
    .table-scrollable > .table-bordered > tfoot > tr > td:last-child {
      border-right: 0; }
    .table-scrollable > .table-bordered > thead > tr:last-child > th,
    .table-scrollable > .table-bordered > tbody > tr:last-child > th,
    .table-scrollable > .table-bordered > tfoot > tr:last-child > th,
    .table-scrollable > .table-bordered > thead > tr:last-child > td,
    .table-scrollable > .table-bordered > tbody > tr:last-child > td,
    .table-scrollable > .table-bordered > tfoot > tr:last-child > td {
      border-bottom: 0; }

/***
Customized Bootstrap Tables
***/
.table td,
.table th {
  font-size: 14px; }
.table.table-bordered thead > tr > th {
  border-bottom: 0; }
.table td .img-responsive {
  width: 100%; }

/***
Responsive Flip Scroll Tables
***/
.flip-scroll table {
  width: 100%; }

@media only screen and (max-width: 768px) {
  /* 768px */
  .flip-scroll .flip-content:after {
    visibility: hidden;
    display: block;
    font-size: 0;
    content: " ";
    clear: both;
    height: 0; }

  .flip-scroll * html .flip-content {
    zoom: 1; }

  .flip-scroll *:first-child + html .flip-content {
    zoom: 1; }

  .flip-scroll table {
    width: 100%;
    border-collapse: collapse;
    border-spacing: 0; }

  .flip-scroll th,
  .flip-scroll td {
    margin: 0;
    vertical-align: top; }

  .flip-scroll th {
    text-align: left;
    border: 0 !important;
    border-bottom: 1px solid #ddd !important;
    border-right: 1px solid #ddd !important;
    font-size: 13px !important;
    padding: 5px;
    width: auto !important; }

  .flip-scroll table {
    display: block;
    position: relative;
    width: 100%; }

  .flip-scroll thead {
    display: block;
    float: left; }

  .flip-scroll tbody {
    display: block;
    width: auto;
    position: relative;
    overflow-x: auto;
    white-space: nowrap; }

  .flip-scroll .flip-content tbody tr td {
    font-size: 13px;
    line-height: 1.483; }

  .flip-scroll .table-bordered.flip-content tbody tr td {
    font-size: 13px;
    line-height: 1.43; }

  .flip-scroll thead tr {
    display: block; }

  .flip-scroll th {
    display: block;
    text-align: right; }

  .flip-scroll tbody tr {
    display: inline-block;
    vertical-align: top;
    margin-left: -5px; }

  .flip-scroll td {
    display: block;
    min-height: 1.25em;
    text-align: left;
    border-top: 0 !important;
    border-left: 0 !important;
    border-right: 0 !important; }

  /* sort out borders */
  .flip-scroll th {
    border-bottom: 0;
    border-left: 0; }

  .flip-scroll td {
    border-left: 0;
    border-right: 0;
    border-bottom: 0; }

  .flip-scroll tbody tr {
    border-left: 1px solid #ddd; }

  .flip-scroll th:last-child,
  .flip-scroll td:last-child {
    border-bottom: 1px solid #ddd; } }
/***
Custom tables
***/
.table-toolbar {
  margin-bottom: 20px; }
  .table-toolbar:before, .table-toolbar:after {
    content: " ";
    display: table; }
  .table-toolbar:after {
    clear: both; }

.table.table-full-width {
  width: 100% !important; }

.table .btn {
  margin-top: 0px;
  margin-left: 0px;
  margin-right: 5px; }

.table thead tr th {
  font-size: 14px;
  font-weight: 600; }

.table-advance {
  margin-bottom: 10px !important; }

.table-advance thead {
  color: #3f444a; }

.table-advance thead tr th {
  background-color: #f1f4f7;
  font-size: 14px;
  font-weight: 400;
  color: #3f444a; }

.table-advance div.success,
.table-advance div.info,
.table-advance div.important,
.table-advance div.warning,
.table-advance div.danger {
  position: absolute;
  margin-top: -5px;
  float: left;
  width: 2px;
  height: 30px;
  margin-right: 20px !important; }

.table-advance tr td {
  border-left-width: 0px; }

.table-advance tr td:first-child {
  border-left-width: 2px !important; }

.table-advance tr td.highlight:first-child a {
  margin-left: 15px; }

.table-advance td.highlight div.primary {
  border-left: 2px solid #17b8b6; }

.table-advance td.highlight div.success {
  border-left: 2px solid #36c6d3; }

.table-advance td.highlight div.info {
  border-left: 2px solid #659be0; }

.table-advance td.highlight div.warning {
  border-left: 2px solid #F1C40F; }

.table-advance td.highlight div.danger {
  border-left: 2px solid #ed6b75; }

@media (max-width: 767px) {
  /* 767px */
  .table-advance tr > td.highlight:first-child a {
    margin-left: 8px; } }
/***
Light Table
***/
.table.table-light {
  border: 0 !important; }
  .table.table-light > thead > tr:hover > th {
    background: none; }
  .table.table-light > thead > tr.uppercase {
    text-transform: uppercase; }
  .table.table-light > thead > tr > th {
    font-weight: 600;
    font-size: 13px;
    color: #93a2a9;
    font-family: "Roboto", sans-serif;
    border: 0;
    border-bottom: 1px solid #F2F5F8; }
  .table.table-light > tbody > tr:last-child > td {
    border: 0; }
  .table.table-light > tbody > tr > td {
    border: 0;
    border-bottom: 1px solid #F2F5F8;
    color: #8896a0;
    vertical-align: middle; }
    .table.table-light > tbody > tr > td.fit {
      width: 1px;
      padding-right: 3px; }
    .table.table-light > tbody > tr > td .user-pic {
      display: inline-block;
      vertical-align: middle;
      height: 30px;
      -webkit-border-radius: 100%;
      -moz-border-radius: 100%;
      -ms-border-radius: 100%;
      -o-border-radius: 100%;
      border-radius: 100%; }
  .table.table-light.table-hover > tbody > tr > td:hover,
  .table.table-light.table-hover > tbody > tr > th:hover, .table.table-light.table-hover > tbody > tr:hover > td {
    background: #f9fafb !important; }

.table-hover > tbody > tr:hover,
.table-hover > tbody > tr:hover > td {
  background: #f3f4f6 !important; }

/***
Customized Bootstrap Tabs 
***/
/* Tabs and pills */
.nav-tabs,
.nav-pills {
  margin-bottom: 10px; }
  .nav-tabs > li > a,
  .nav-pills > li > a {
    font-size: 14px;
    -webkit-border-radius: 2px 2px 0 0;
    -moz-border-radius: 2px 2px 0 0;
    -ms-border-radius: 2px 2px 0 0;
    -o-border-radius: 2px 2px 0 0;
    border-radius: 2px 2px 0 0; }
    .nav-tabs > li > a > .badge,
    .nav-pills > li > a > .badge {
      margin-top: -6px; }
  .nav-tabs > li .dropdown-menu:before, .nav-tabs > li .dropdown-menu:after,
  .nav-pills > li .dropdown-menu:before,
  .nav-pills > li .dropdown-menu:after {
    display: none; }
  .nav-tabs.nav-tabs-sm > li > a, .nav-tabs.nav-pills-sm > li > a,
  .nav-pills.nav-tabs-sm > li > a,
  .nav-pills.nav-pills-sm > li > a {
    font-size: 13px; }
  .nav-tabs .dropdown.open > .dropdown-toggle,
  .nav-pills .dropdown.open > .dropdown-toggle {
    background: #eee;
    color: #0d638f;
    border-color: transparent; }

/* Left and right tabs */
.tabs-right.nav-tabs,
.tabs-left.nav-tabs {
  border-bottom: 0; }
  .tabs-right.nav-tabs > li,
  .tabs-left.nav-tabs > li {
    float: none; }
    .tabs-right.nav-tabs > li > a,
    .tabs-left.nav-tabs > li > a {
      margin-right: 0;
      margin-bottom: 3px; }

/* Left tabs */
.tabs-left.nav-tabs {
  border-right: 1px solid #ddd; }
  .tabs-left.nav-tabs > li > a {
    display: block;
    margin-right: -1px; }
    .tabs-left.nav-tabs > li > a:hover, .tabs-left.nav-tabs > li > a:focus {
      -webkit-border-radius: 2px 0 0 2px;
      -moz-border-radius: 2px 0 0 2px;
      -ms-border-radius: 2px 0 0 2px;
      -o-border-radius: 2px 0 0 2px;
      border-radius: 2px 0 0 2px;
      border-color: #eeeeee #dddddd #eeeeee #eeeeee; }
  .tabs-left.nav-tabs > li.active > a,
  .tabs-left.nav-tabs > li.active > a:hover
  > li.active > a:focus {
    -webkit-border-radius: 2px 0 0 2px;
    -moz-border-radius: 2px 0 0 2px;
    -ms-border-radius: 2px 0 0 2px;
    -o-border-radius: 2px 0 0 2px;
    border-radius: 2px 0 0 2px;
    border-color: #ddd transparent #ddd #ddd;
    *border-right-color: #ffffff; }

/* Right tabs */
.tabs-right.nav-tabs {
  border-left: 1px solid #ddd; }
  .tabs-right.nav-tabs > li > a {
    display: block;
    margin-left: -1px; }
    .tabs-right.nav-tabs > li > a:hover, .tabs-right.nav-tabs > li > a:focus {
      -webkit-border-radius: 0 2px 2px 0;
      -moz-border-radius: 0 2px 2px 0;
      -ms-border-radius: 0 2px 2px 0;
      -o-border-radius: 0 2px 2px 0;
      border-radius: 0 2px 2px 0;
      border-color: #eeeeee #eeeeee #eeeeee #dddddd; }
  .tabs-right.nav-tabs > li.active > a,
  .tabs-right.nav-tabs > li.active > a:hover
  > li.active > a:focus {
    -webkit-border-radius: 0 2px 2px 0;
    -moz-border-radius: 0 2px 2px 0;
    -ms-border-radius: 0 2px 2px 0;
    -o-border-radius: 0 2px 2px 0;
    border-radius: 0 2px 2px 0;
    border-color: #ddd #ddd #ddd transparent;
    *border-left-color: #ffffff; }

/* Below tabs */
.tabs-below > .nav-tabs,
.tabs-below > .nav-pills {
  border-bottom: 0;
  margin-bottom: 0px;
  margin-top: 10px; }

.tabs-below > .nav-tabs {
  border-top: 1px solid #ddd;
  margin-bottom: 0;
  margin-top: 10px; }
  .tabs-below > .nav-tabs > li > a {
    margin-top: -1px;
    margin-bottom: 0; }
    .tabs-below > .nav-tabs > li > a:hover, .tabs-below > .nav-tabs > li > a:focus {
      border-top-color: #ddd;
      border-bottom-color: transparent; }
    .tabs-below > .nav-tabs > li > a .dropdown-menu {
      -webkit-border-radius: 2px;
      -moz-border-radius: 2px;
      -ms-border-radius: 2px;
      -o-border-radius: 2px;
      border-radius: 2px; }
  .tabs-below > .nav-tabs .active a,
  .tabs-below > .nav-tabs .active a:hover
  .active a:focus {
    -webkit-border-radius: 0 0 2px 2px;
    -moz-border-radius: 0 0 2px 2px;
    -ms-border-radius: 0 0 2px 2px;
    -o-border-radius: 0 0 2px 2px;
    border-radius: 0 0 2px 2px;
    border-color: transparent #ddd #ddd #ddd  !important; }

/***
Custom tabs
***/
/* In BS3.0.0 tabbable class was removed. We had to added it back */
.tabbable:before, .tabbable:after {
  content: " ";
  display: table; }
.tabbable:after {
  clear: both; }

.tabbable-custom {
  margin-bottom: 15px;
  padding: 0px;
  overflow: hidden;
  /* justified tabs */
  /* boxless tabs */
  /* below justified tabs */
  /* full width tabs */
  /* below tabs */ }
  .tabbable-custom > .nav-tabs {
    border: none;
    margin: 0px; }
    .tabbable-custom > .nav-tabs > li {
      margin-right: 2px;
      border-top: 2px solid transparent; }
      .tabbable-custom > .nav-tabs > li > a {
        margin-right: 0;
        -webkit-border-radius: 0;
        -moz-border-radius: 0;
        -ms-border-radius: 0;
        -o-border-radius: 0;
        border-radius: 0; }
        .tabbable-custom > .nav-tabs > li > a:hover {
          background: none;
          border-color: transparent; }
      .tabbable-custom > .nav-tabs > li.active {
        border-top: 3px solid #ed6b75;
        margin-top: 0;
        position: relative; }
        .tabbable-custom > .nav-tabs > li.active > a {
          border-top: none !important;
          font-weight: 400;
          -webkit-border-radius: 0;
          -moz-border-radius: 0;
          -ms-border-radius: 0;
          -o-border-radius: 0;
          border-radius: 0; }
          .tabbable-custom > .nav-tabs > li.active > a:hover {
            -webkit-border-radius: 0;
            -moz-border-radius: 0;
            -ms-border-radius: 0;
            -o-border-radius: 0;
            border-radius: 0;
            border-top: none;
            background: #fff;
            border-color: #d4d4d4 #d4d4d4 transparent; }
  .tabbable-custom > .tab-content {
    background-color: #fff;
    border: 1px solid #ddd;
    padding: 10px;
    -webkit-border-radius: 0 0 2px 2px;
    -moz-border-radius: 0 0 2px 2px;
    -ms-border-radius: 0 0 2px 2px;
    -o-border-radius: 0 0 2px 2px;
    border-radius: 0 0 2px 2px; }
  .tabbable-custom.nav-justified > .tab-content {
    margin-top: -1px; }
  .tabbable-custom.boxless > .tab-content {
    padding: 15px 0;
    border-left: none;
    border-right: none;
    border-bottom: none; }
  .tabbable-custom.tabs-below.nav-justified .tab-content {
    margin-top: 0px;
    margin-bottom: -2px;
    -webkit-border-radius: 2px 2px 0 0;
    -moz-border-radius: 2px 2px 0 0;
    -ms-border-radius: 2px 2px 0 0;
    -o-border-radius: 2px 2px 0 0;
    border-radius: 2px 2px 0 0; }
  .tabbable-custom.tabbable-full-width > .nav-tabs > li > a {
    color: #424242;
    font-size: 15px;
    padding: 9px 15px; }
  .tabbable-custom.tabbable-full-width > .tab-content {
    padding: 15px 0;
    border-left: none;
    border-right: none;
    border-bottom: none; }
  .tabbable-custom.tabs-below .nav-tabs > li > a {
    border-top: none;
    border-bottom: 2px solid transparent;
    margin-top: -1px; }
  .tabbable-custom.tabs-below .nav-tabs > li.active {
    border-top: none;
    border-bottom: 3px solid #d12610;
    margin-bottom: 0;
    position: relative; }
    .tabbable-custom.tabs-below .nav-tabs > li.active > a {
      border-bottom: none; }
      .tabbable-custom.tabs-below .nav-tabs > li.active > a:hover {
        background: #fff;
        border-color: #d4d4d4 #d4d4d4 transparent; }

.tabbable-custom.tabbable-noborder > .nav-tabs > li > a {
  border: 0; }
.tabbable-custom.tabbable-noborder .tab-content {
  border: 0; }

.portlet:not(.light) .tabbable-line {
  padding-top: 15px; }
.tabbable-line > .nav-tabs {
  border: none;
  margin: 0px; }
  .tabbable-line > .nav-tabs > li {
    margin: 0;
    border-bottom: 4px solid transparent; }
    .tabbable-line > .nav-tabs > li > a {
      background: none !important;
      border: 0;
      margin: 0;
      padding-left: 15px;
      padding-right: 15px;
      color: #737373; }
      .tabbable-line > .nav-tabs > li > a > i {
        color: #a6a6a6; }
    .tabbable-line > .nav-tabs > li.active {
      background: none;
      border-bottom: 4px solid #36c6d3;
      position: relative; }
      .tabbable-line > .nav-tabs > li.active > a {
        border: 0;
        color: #333; }
        .tabbable-line > .nav-tabs > li.active > a > i {
          color: #404040; }
    .tabbable-line > .nav-tabs > li.open, .tabbable-line > .nav-tabs > li:hover {
      background: none;
      border-bottom: 4px solid #9fe4ea; }
      .tabbable-line > .nav-tabs > li.open > a, .tabbable-line > .nav-tabs > li:hover > a {
        border: 0;
        background: none !important;
        color: #333; }
        .tabbable-line > .nav-tabs > li.open > a > i, .tabbable-line > .nav-tabs > li:hover > a > i {
          color: #a6a6a6; }
      .tabbable-line > .nav-tabs > li.open .dropdown-menu, .tabbable-line > .nav-tabs > li:hover .dropdown-menu {
        margin-top: 0px; }
.tabbable-line > .tab-content {
  margin-top: 0;
  border: 0;
  border-top: 1px solid #eef1f5;
  padding: 30px 0; }
  .page-container-bg-solid .tabbable-line > .tab-content {
    border-top: 1px solid #dae2ea; }
  .portlet .tabbable-line > .tab-content {
    padding-bottom: 0; }

.tabbable-line.tabs-below > .nav-tabs > li {
  border-top: 4px solid transparent; }
  .tabbable-line.tabs-below > .nav-tabs > li > a {
    margin-top: 0; }
  .tabbable-line.tabs-below > .nav-tabs > li:hover {
    border-bottom: 0;
    border-top: 4px solid #fbdcde; }
  .tabbable-line.tabs-below > .nav-tabs > li.active {
    margin-bottom: -2px;
    border-bottom: 0;
    border-top: 4px solid #ed6b75; }
.tabbable-line.tabs-below > .tab-content {
  margin-top: -10px;
  border-top: 0;
  border-bottom: 1px solid #eee;
  padding-bottom: 15px; }

.portlet .tabbable-bordered {
  margin-top: 20px; }
.tabbable-bordered .nav-tabs {
  margin-bottom: 0;
  border-bottom: 0; }
.tabbable-bordered .tab-content {
  padding: 30px 20px 20px 20px;
  border: 1px solid #ddd;
  background: #ffffff; }

/***
Tiles(new in v1.1.1)
***/
.tiles {
  margin-right: -10px; }
  .tiles:before, .tiles:after {
    display: table;
    content: " "; }
  .tiles:after {
    clear: both; }
  .tiles .tile {
    display: block;
    letter-spacing: 0.02em;
    float: left;
    height: 135px;
    width: 135px !important;
    cursor: pointer;
    text-decoration: none;
    color: #ffffff;
    position: relative;
    font-weight: 300;
    font-size: 12px;
    letter-spacing: 0.02em;
    line-height: 20px;
    overflow: hidden;
    border: 4px solid transparent;
    margin: 0 10px 10px 0; }
    .tiles .tile:after, .tiles .tile:before {
      content: "";
      float: left; }
    .tiles .tile.double {
      width: 280px !important; }
    .tiles .tile.double-down {
      height: 280px !important; }
      .tiles .tile.double-down i {
        margin-top: 95px; }
    .tiles .tile:hover {
      border-color: #aaa !important; }
    .tiles .tile:active, .tiles .tile.selected {
      border-color: #ccc !important; }
    .tiles .tile.selected .corner:after {
      content: "";
      display: inline-block;
      border-left: 40px solid transparent;
      border-bottom: 40px solid transparent;
      border-right: 40px solid #ccc;
      position: absolute;
      top: -3px;
      right: -3px; }
    .tiles .tile.selected .check:after {
      content: "";
      font-family: FontAwesome;
      font-size: 13px;
      content: "\f00c";
      display: inline-block;
      position: absolute;
      top: 2px;
      right: 2px; }
    .tiles .tile.icon {
      padding: 0; }
    .tiles .tile.image .tile-body {
      padding: 0 !important; }
      .tiles .tile.image .tile-body > img {
        width: 100%;
        height: auto;
        min-height: 100%;
        max-width: 100%; }
      .tiles .tile.image .tile-body h3 {
        display: inline-block; }
    .tiles .tile .tile-body {
      height: 100%;
      vertical-align: top;
      padding: 10px 10px;
      overflow: hidden;
      position: relative;
      font-weight: 400;
      font-size: 12px;
      color: #000000;
      color: #ffffff;
      margin-bottom: 10px; }
      .tiles .tile .tile-body p {
        font-weight: 400;
        font-size: 13px;
        color: #000000;
        color: #ffffff;
        line-height: 20px;
        overflow: hidden; }
        .tiles .tile .tile-body p:hover {
          color: rgba(0, 0, 0, 0.8); }
        .tiles .tile .tile-body p:active {
          color: rgba(0, 0, 0, 0.4); }
        .tiles .tile .tile-body p:hover {
          color: #ffffff; }
      .tiles .tile .tile-body img {
        float: left;
        margin-right: 10px; }
        .tiles .tile .tile-body img.pull-right {
          float: right !important;
          margin-left: 10px;
          margin-right: 0px; }
      .tiles .tile .tile-body > .content {
        display: inline-block; }
      .tiles .tile .tile-body > i {
        margin-top: 17px;
        display: block;
        font-size: 56px;
        line-height: 56px;
        text-align: center; }
      .tiles .tile .tile-body h1,
      .tiles .tile .tile-body h2,
      .tiles .tile .tile-body h3,
      .tiles .tile .tile-body h4,
      .tiles .tile .tile-body h5,
      .tiles .tile .tile-body h6,
      .tiles .tile .tile-body p {
        padding: 0;
        margin: 0;
        line-height: 14px; }
        .tiles .tile .tile-body h1:hover,
        .tiles .tile .tile-body h2:hover,
        .tiles .tile .tile-body h3:hover,
        .tiles .tile .tile-body h4:hover,
        .tiles .tile .tile-body h5:hover,
        .tiles .tile .tile-body h6:hover,
        .tiles .tile .tile-body p:hover {
          color: #ffffff; }
      .tiles .tile .tile-body h3,
      .tiles .tile .tile-body h4 {
        margin-bottom: 5px; }
    .tiles .tile .tile-object {
      position: absolute;
      bottom: 0;
      left: 0;
      right: 0;
      min-height: 30px;
      background-color: transparent;
      *zoom: 1; }
      .tiles .tile .tile-object:before, .tiles .tile .tile-object:after {
        display: table;
        content: ""; }
      .tiles .tile .tile-object:after {
        clear: both; }
      .tiles .tile .tile-object > .name {
        position: absolute;
        bottom: 0;
        left: 0;
        margin-bottom: 5px;
        margin-left: 10px;
        margin-right: 15px;
        font-weight: 400;
        font-size: 13px;
        color: #ffffff; }
        .tiles .tile .tile-object > .name > i {
          vertical-align: middle;
          display: block;
          font-size: 24px;
          height: 18px;
          width: 24px; }
      .tiles .tile .tile-object > .number {
        position: absolute;
        bottom: 0;
        right: 0;
        margin-bottom: 0;
        color: #ffffff;
        text-align: center;
        font-weight: 600;
        font-size: 14px;
        letter-spacing: 0.01em;
        line-height: 14px;
        margin-bottom: 8px;
        margin-right: 10px; }

/***
Custimized Bootstrap Wells
***/
.well {
  border: 0;
  padding: 20px; }

.well {
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  -ms-border-radius: 2px;
  -o-border-radius: 2px;
  border-radius: 2px; }

.well-lg {
  padding: 40px; }

.well-sm {
  padding: 10px; }

/*--------------------------------------------------
	[Widgets]
----------------------------------------------------*/
/*** Widget Background Colors ***/
.widget-bg-color-purple {
  background: #9a7caf; }

.widget-bg-color-purple-dark {
  background: #4b365a; }

.widget-bg-color-purple-light {
  background: #674d79; }

.widget-bg-color-green {
  background: #4db3a4; }

.widget-bg-color-red {
  background: #f36a5a; }

.widget-bg-color-blue {
  background: #5b9bd1; }

.widget-bg-color-gray {
  background: #323c45; }

.widget-bg-color-gray-dark {
  background: #144f57; }

.widget-bg-color-white {
  background: #fff; }

.widget-bg-color-dark {
  background: #3e4f5e; }

.widget-bg-color-dark-light {
  background: #8e9daa; }

.widget-bg-color-fb {
  background: #475e98; }

.widget-bg-color-tw {
  background: #55acee; }

/*** Widget Title Colors ***/
.widget-title-color-purple {
  color: #9a7caf; }

.widget-title-color-purple-dark {
  color: #4b365a; }

.widget-title-color-purple-light {
  color: #674d79; }

.widget-title-color-green {
  color: #4db3a4; }

.widget-title-color-red {
  color: #f36a5a; }

.widget-title-color-blue {
  color: #5b9bd1; }

.widget-title-color-gray {
  color: #323c45; }

.widget-title-color-gray-dark {
  color: #144f57; }

.widget-title-color-white {
  color: #fff; }

.widget-title-color-dark {
  color: #3e4f5e; }

.widget-title-color-dark-light {
  color: #8e9daa; }

.widget-title-color-fb {
  color: #475e98; }

.widget-title-color-tw {
  color: #55acee; }

.overflow-h {
  overflow: hidden; }

/*** Widget Carousel ***/
.widget-carousel .carousel-indicators {
  left: -18%;
  bottom: 10px;
  margin-left: 0; }
.widget-carousel .carousel-indicators-red > li {
  border-color: #f36a5a; }
  .widget-carousel .carousel-indicators-red > li.active {
    background: #f36a5a; }

/*** Widget Gradient ***/
.widget-gradient {
  position: relative;
  min-height: 350px;
  overflow: hidden;
  background-size: cover;
  background-position: 50% 50%;
  border-radius: 2px; }
  .widget-gradient .widget-gradient-body {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    width: auto;
    height: auto;
    padding: 20px; }
    .widget-gradient .widget-gradient-body .widget-gradient-title {
      font-size: 21px;
      font-weight: 600;
      color: #fff;
      margin: 0; }
    .widget-gradient .widget-gradient-body .widget-gradient-body-actions {
      position: absolute;
      right: 20px;
      bottom: 20px;
      padding: 0;
      margin: 0; }
      .widget-gradient .widget-gradient-body .widget-gradient-body-actions li {
        font-size: 14px;
        padding: 0 0 0 8px; }
        .widget-gradient .widget-gradient-body .widget-gradient-body-actions li:first-child {
          padding-left: 0; }
        .widget-gradient .widget-gradient-body .widget-gradient-body-actions li a {
          color: #fff; }
          .widget-gradient .widget-gradient-body .widget-gradient-body-actions li a:hover {
            color: #a1afbb;
            text-decoration: none; }

/*** Widget Gradient ***/
.widget-wrap-img {
  border-radius: 2px;
  position: relative;
  min-height: 350px;
  padding: 20px; }
  .widget-wrap-img .widget-wrap-img-title {
    font-size: 21px;
    font-weight: 600;
    color: #3e4f5e;
    margin: 0 0 20px; }
  .widget-wrap-img .widget-wrap-img-element {
    position: absolute;
    bottom: 0;
    right: 0; }

/*** Widget Tab ***/
.widget-tab {
  min-height: 420px;
  border-radius: 2px; }
  .widget-tab .nav-tabs {
    margin: 0;
    border-color: #eff1f3; }
    .widget-tab .nav-tabs > li {
      margin: 0 10px; }
      .widget-tab .nav-tabs > li:first-child {
        margin-left: 20px; }
      .widget-tab .nav-tabs > li > a {
        border: 0;
        font-weight: bold;
        color: #8e9daa;
        text-transform: uppercase;
        padding: 20px 0; }
        .widget-tab .nav-tabs > li > a > i {
          color: #8e9daa; }
      .widget-tab .nav-tabs > li.open, .widget-tab .nav-tabs > li:hover {
        border-bottom: 1px solid #f36a5a; }
        .widget-tab .nav-tabs > li.open > a, .widget-tab .nav-tabs > li:hover > a {
          border: 0;
          background: inherit;
          color: #f36a5a; }
          .widget-tab .nav-tabs > li.open > a > i, .widget-tab .nav-tabs > li:hover > a > i {
            color: #f36a5a; }
      .widget-tab .nav-tabs > li.active {
        border-bottom: 1px solid #f36a5a;
        position: relative; }
        .widget-tab .nav-tabs > li.active > a {
          border: 0;
          color: #f36a5a; }
          .widget-tab .nav-tabs > li.active > a > i {
            color: #f36a5a; }
  .widget-tab .tab-content {
    padding: 20px;
    color: #8e9daa; }
  .widget-tab .slimScrollBar {
    right: 10px !important;
    margin-top: 17px !important;
    margin-bottom: 17px !important; }

/*** Widget News ***/
.widget-news {
  overflow: hidden;
  margin-right: 10px;
  border-radius: 2px; }
  .widget-news .widget-news-left-elem {
    float: left;
    width: 100px;
    height: auto;
    margin-right: 15px; }
  .widget-news .widget-news-right-body {
    overflow: hidden; }
    .widget-news .widget-news-right-body .widget-news-right-body-title {
      font-size: 16px;
      font-weight: 600;
      color: #3e4f5e;
      margin: 0 0 5px;
      clear: both; }
      .widget-news .widget-news-right-body .widget-news-right-body-title .label {
        float: right;
        font-weight: 600;
        background: #a1afbb;
        border-radius: 3px !important; }
    .widget-news .widget-news-right-body p {
      font-size: 13px; }

/*** Widget Thumb ***/
.widget-thumb {
  padding: 20px;
  border-radius: 2px; }
  .widget-thumb.bordered {
    border: 1px solid #e7ecf1; }
  .widget-thumb .widget-thumb-heading {
    font-size: 14px;
    font-weight: bold;
    color: #8e9daa;
    margin: 0 0 20px 0; }
  .widget-thumb .widget-thumb-wrap {
    overflow: hidden; }
    .widget-thumb .widget-thumb-wrap .widget-thumb-icon {
      float: left;
      width: 60px;
      height: 60px;
      display: inline-block;
      font-size: 20px;
      line-height: 41px;
      color: #fff;
      text-align: center;
      padding: 10px;
      margin-right: 15px; }
  .widget-thumb .widget-thumb-body {
    overflow: hidden; }
    .widget-thumb .widget-thumb-body .widget-thumb-subtitle {
      padding-top: 2px;
      display: block;
      font-size: 14px;
      font-weight: 600;
      color: #8e9daa; }
    .widget-thumb .widget-thumb-body .widget-thumb-body-stat {
      display: block;
      font-size: 30px;
      font-weight: 600;
      color: #3e4f5e; }

/*** Widget Socials ***/
.widget-socials {
  border-radius: 2px;
  min-height: 250px;
  padding: 20px; }
  .widget-socials .widget-socials-title {
    font-size: 25px;
    font-weight: 700;
    line-height: 1.4;
    color: #fff;
    margin: 0 0 20px; }
  .widget-socials .widget-social-subtitle {
    color: #fff;
    font-weight: 200;
    line-height: 1.4; }
    .widget-socials .widget-social-subtitle a {
      color: #fff; }
  .widget-socials .widget-socials-paragraph {
    display: block;
    color: #65727d; }
  .widget-socials .widget-social-icon-fb, .widget-socials .widget-social-icon-tw {
    font-size: 30px;
    margin: 30px 0; }
  .widget-socials .widget-social-icon-fb {
    color: #2b3f72; }
  .widget-socials .widget-social-icon-tw {
    color: #3686c3; }

/*** Widget Comments ***/
.widget-comments {
  min-height: 420px; }

/*** Widget Media ***/
.widget-media {
  border-radius: 2px;
  border-bottom: 1px solid #f6f9fc;
  overflow: hidden;
  padding-bottom: 15px;
  margin-bottom: 15px; }
  .widget-media .widget-media-elements {
    float: left;
    margin-right: 20px; }
  .widget-media .widget-media-avatar {
    width: 55px;
    height: 55px;
    display: block; }
  .widget-media .widget-btn-default {
    display: inline-block;
    font-size: 12px;
    color: #96a2b1;
    border: 1px solid #ebf0f6;
    padding: 3px 10px; }
    .widget-media .widget-btn-default .widget-btn-icon {
      line-height: 1.5; }
    .widget-media .widget-btn-default:hover {
      background: #ebf0f6;
      text-decoration: none; }
  .widget-media .widget-btn-red {
    display: inline-block;
    font-size: 12px;
    color: #f36a5a;
    border: 1px solid #ebf0f6;
    padding: 3px 10px; }
    .widget-media .widget-btn-red .widget-btn-icon {
      line-height: 1.5; }
    .widget-media .widget-btn-red:hover {
      color: #fff;
      background: #f36a5a;
      text-decoration: none; }
  .widget-media .widget-btn-blue {
    display: inline-block;
    font-size: 12px;
    color: #fff;
    border: 1px solid #ebf0f6;
    padding: 3px 10px;
    background: #337ab7; }
    .widget-media .widget-btn-blue .widget-btn-icon {
      line-height: 1.5; }
    .widget-media .widget-btn-blue:hover {
      color: #337ab7;
      background: #fff;
      text-decoration: none; }
  .widget-media .widget-media-body {
    overflow: hidden; }
    .widget-media .widget-media-body .widget-media-body-title {
      font-size: 15px;
      font-weight: 600;
      color: #5b9bd1;
      margin: 0 0 7px; }
    .widget-media .widget-media-body .widget-media-body-subtitle {
      font-size: 13px;
      color: #7e8c9e; }

/*** Widget Blog ***/
.widget-blog {
  border-radius: 2px;
  background: #fff;
  padding: 20px;
  background-position: center center;
  background-size: cover;
  padding-top: 30px; }
  .widget-blog .widget-blog-heading {
    position: relative;
    margin-bottom: 30px; }
    .widget-blog .widget-blog-heading:before {
      position: absolute;
      bottom: -15px;
      left: 50%;
      width: 50px;
      height: 1px;
      border-width: 1px;
      background: #8e9daa;
      margin-left: -25px;
      content: " "; }
  .widget-blog .widget-blog-title {
    font-size: 20px;
    font-weight: 400;
    color: #3e4f5e;
    margin: 0 0 15px; }
    .widget-blog .widget-blog-title a {
      color: #3e4f5e; }
  .widget-blog .widget-blog-subtitle {
    display: block;
    font-size: 13px;
    color: #8e9daa;
    letter-spacing: 3px; }
  .widget-blog .btn-widget-purple {
    display: inline-block;
    font-size: 13px;
    color: #8e9daa;
    border: 1px solid #8e9daa;
    padding: 7px 17px; }
    .widget-blog .btn-widget-purple:hover {
      color: #fff;
      background: #8e9daa;
      text-decoration: none; }

/*** Widget Progress ***/
.widget-progress {
  min-height: 420px; }
  .widget-progress .widget-progress-element {
    border-radius: 2px;
    overflow: hidden;
    padding: 30px 10px; }
  .widget-progress .widget-progress-title {
    display: block;
    color: #fff;
    margin-bottom: 5px; }
  .widget-progress .progress {
    height: 3px;
    background: rgba(255, 255, 255, 0.2);
    margin-bottom: 0; }

/*** Widget Gradient ***/
.widget-map {
  border-radius: 2px;
  min-height: 350px;
  border-radius: 3px; }
  .widget-map .widget-map-mapplic {
    border-top-right-radius: 3px;
    border-top-left-radius: 3px; }
    .widget-map .widget-map-mapplic .mapplic-container {
      background: #5b9bd1; }
    .widget-map .widget-map-mapplic .mapplic-layer.world > img {
      opacity: .3; }
  .widget-map .widget-map-body {
    background: #fff;
    border-bottom-right-radius: 3px;
    border-bottom-left-radius: 3px;
    padding: 20px;
    overflow: hidden; }
  .widget-map .widget-sparkline-chart {
    width: 25%;
    float: left;
    border-left: 1px solid #e7eff7;
    padding: 0 15px; }
    .widget-map .widget-sparkline-chart:first-child {
      border-left: none; }
    .widget-map .widget-sparkline-chart .widget-sparkline-title {
      display: block;
      font-size: 12px;
      font-weight: 600;
      color: #a1afbb; }

/* Widget Map for max-width 480px */
@media (max-width: 480px) {
  /* 480px */
  .widget-map .widget-sparkline-chart {
    width: 50%;
    border-left: none;
    margin-top: 10px;
    margin-bottom: 10px; } }
/*** Widget Subscribe ***/
.widget-subscribe {
  border-radius: 2px;
  min-height: 250px;
  overflow: hidden;
  padding: 30px; }
  .widget-subscribe .widget-subscribe-no {
    float: left;
    font-size: 67px;
    font-weight: 600;
    line-height: 1;
    color: #9a7caf; }
  .widget-subscribe .widget-subscribe-title {
    font-size: 25px;
    font-weight: 700;
    line-height: 1.4;
    margin: 0 0 15px 45px; }
  .widget-subscribe .widget-subscribe-subtitle {
    font-size: 15px;
    font-weight: 600; }
  .widget-subscribe .widget-subscribe-subtitle-link {
    color: #cab0dd; }
  .widget-subscribe.widget-subscribe-quote {
    position: relative; }
    .widget-subscribe.widget-subscribe-quote:before {
      position: absolute;
      top: 2px;
      font-size: 70px;
      color: #fff;
      content: "\201C"; }

/* Widget Subscribe for media queries */
@media (max-width: 767px) {
  /* 767px */
  .widget-subscribe.widget-subscribe-border {
    border-top: 1px solid #f5f8fb;
    border-bottom: 1px solid #f5f8fb;
    border-right: none; } }
@media (min-width: 768px) {
  /* 768px */
  .widget-subscribe.widget-subscribe-border {
    border-left: 1px solid #f5f8fb;
    border-right: 1px solid #f5f8fb; } }
@media (min-width: 767px) and (max-width: 991px) {
  /* 767px & 991px */
  .widget-subscribe.widget-subscribe-border {
    border-left: none; }
  .widget-subscribe.widget-subscribe-border-top {
    border-top: 1px solid #f5f8fb; } }
/*--------------------------------------------------
    [Material Design]
----------------------------------------------------*/
.page-md .widget-bg-color-white,
.page-md .widget-map,
.page-md .widget-carousel,
.page-md .widget-progress-element,
.page-md .widget-socials,
.page-md .widget-blog {
  box-shadow: 0px 2px 3px 2px rgba(0, 0, 0, 0.03); }

/***
AngularJS Basic Animations
***/
@-webkit-keyframes fadeInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(15px); }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0); } }
@-moz-keyframes fadeInUp {
  0% {
    opacity: 0;
    -moz-transform: translateY(15px); }
  100% {
    opacity: 1;
    -moz-transform: translateY(0); } }
@-o-keyframes fadeInUp {
  0% {
    opacity: 0;
    -o-transform: translateY(15px); }
  100% {
    opacity: 1;
    -o-transform: translateY(0); } }
@keyframes fadeInUp {
  0% {
    opacity: 0;
    transform: translateY(15px); }
  100% {
    opacity: 1;
    transform: translateY(0); } }
.fade-in-up {
  -webkit-animation: fadeInUp .5s;
  animation: fadeInUp .5s; }

@-webkit-keyframes bounceDelay {
  0%, 80%, 100% {
    -webkit-transform: scale(0); }
  40% {
    -webkit-transform: scale(1); } }
@keyframes bounceDelay {
  0%, 80%, 100% {
    transform: scale(0);
    -webkit-transform: scale(0); }
  40% {
    transform: scale(1);
    -webkit-transform: scale(1); } }
@keyframes input-focus {
  0% {
    left: 20%;
    width: 20%; }
  99% {
    width: 0;
    left: 0;
    opacity: 1; }
  100% {
    opacity: 0; } }
.m-heading-1 {
  margin: 0 0 20px 0;
  background: #ffffff;
  padding-left: 15px;
  border-left: 8px solid #88909a; }
  .m-heading-1 > h3 {
    font-size: 20px;
    color: #3f444a;
    font-weight: 500;
    margin: 0 0 15px 0; }
    .m-heading-1 > h3 > i {
      font-size: 18px;
      color: #88909a; }
  .m-heading-1 > p {
    color: #5c6873;
    margin: 10px 0 0 0; }
    .m-heading-1 > p:first-child {
      margin-top: 0; }
  .m-heading-1.m-bordered {
    border-right: 1px solid #10161c;
    border-top: 1px solid #10161c;
    border-bottom: 1px solid #10161c;
    padding: 15px 15px; }
    .page-container-bg-solid .m-heading-1.m-bordered {
      border-right: 0;
      border-top: 0;
      border-bottom: 0; }
  .m-heading-1.m-title-md > h3 {
    font-size: 18px;
    margin-bottom: 10px; }
    .m-heading-1.m-title-md > h3 > i {
      font-size: 16px;
      color: #88909a; }
  .m-heading-1.m-title-md > p {
    margin: 15px 0; }
  .m-heading-1.m-title-sm > h3 {
    font-size: 16px;
    margin-bottom: 10px; }
    .m-heading-1.m-title-sm > h3 > i {
      font-size: 14px;
      color: #88909a; }
  .m-heading-1.m-title-sm > p {
    margin: 10px 0; }

@media (max-width: 991px) {
  /* 991px */
  .m-heading-1 {
    margin: 0px 0; } }
/***
Timeline 
***/
.timeline {
  margin: 0;
  padding: 0;
  position: relative;
  margin-bottom: 30px; }
  .timeline:before {
    content: '';
    position: absolute;
    display: block;
    width: 4px;
    background: #f5f6fa;
    top: 0px;
    bottom: 0px;
    margin-left: 38px; }
  .timeline .timeline-item {
    margin: 0;
    padding: 0; }
  .timeline .timeline-badge {
    float: left;
    position: relative;
    padding-right: 30px;
    height: 80px;
    width: 80px; }
  .timeline .timeline-badge-userpic {
    width: 80px;
    border: 4px #f5f6fa solid;
    -webkit-border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    border-radius: 50% !important; }
  .timeline .timeline-badge-userpic img {
    -webkit-border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    border-radius: 50% !important;
    vertical-align: middle !important; }
  .timeline .timeline-icon {
    width: 80px;
    height: 80px;
    background-color: #f5f6fa;
    -webkit-border-radius: 50% !important;
    -moz-border-radius: 50% !important;
    border-radius: 50% !important;
    padding-top: 30px;
    padding-left: 22px; }
  .timeline .timeline-icon i {
    font-size: 34px; }
  .timeline .timeline-body {
    position: relative;
    padding: 20px;
    margin-top: 20px;
    margin-left: 110px;
    background-color: #f5f6fa;
    -webkit-border-radius: 2px;
    -moz-border-radius: 2px;
    -ms-border-radius: 2px;
    -o-border-radius: 2px;
    border-radius: 2px; }
    .timeline .timeline-body:before, .timeline .timeline-body:after {
      content: " ";
      display: table; }
    .timeline .timeline-body:after {
      clear: both; }
  .timeline .timeline-body-arrow {
    position: absolute;
    top: 30px;
    left: -14px;
    width: 0;
    height: 0;
    border-style: solid;
    border-width: 14px 14px 14px 0;
    border-color: transparent #f5f6fa transparent transparent; }
  .timeline .timeline-body-head {
    margin-bottom: 10px; }
  .timeline .timeline-body-head-caption {
    float: left; }
  .timeline .timeline-body-title {
    font-size: 16px;
    font-weight: 600; }
  .timeline .timeline-body-alerttitle {
    font-size: 16px;
    font-weight: 600; }
  .timeline .timeline-body-time {
    font-size: 14px;
    margin-left: 10px; }
  .timeline .timeline-body-head-actions {
    float: right; }
  .timeline .timeline-body-head-actions .btn-group {
    margin-top: -2px; }
  .timeline .timeline-body-content {
    font-size: 14px;
    margin-top: 35px; }
  .timeline .timeline-body-img {
    width: 100px;
    height: 100px;
    margin: 5px 20px 0 0px; }
  .timeline.white-bg:before {
    background: #fff; }
  .timeline.white-bg .timeline-badge-userpic {
    border-color: #fff; }
  .timeline.white-bg .timeline-icon {
    background-color: #fff; }
  .timeline.white-bg .timeline-body {
    background-color: #fff; }
  .timeline.white-bg .timeline-body-arrow {
    border-color: transparent #fff transparent transparent; }

@media (max-width: 768px) {
  .timeline .timeline-body-head-caption {
    width: 100%; }
  .timeline .timeline-body-head-actions {
    float: left;
    width: 100%;
    margin-top: 20px;
    margin-bottom: 20px; } }
@media (max-width: 480px) {
  .timeline:before {
    margin-left: 28px; }
  .timeline .timeline-badge {
    padding-right: 40px;
    width: 60px;
    height: 60px; }
  .timeline .timeline-badge-userpic {
    width: 60px; }
  .timeline .timeline-icon {
    width: 60px;
    height: 60px;
    padding-top: 23px;
    padding-left: 18px; }
  .timeline .timeline-icon i {
    font-size: 25px; }
  .timeline .timeline-body {
    margin-left: 80px; }
  .timeline .timeline-body-arrow {
    top: 17px; } }
/***
Timeline 2
***/
.mt-timeline-2 {
  position: relative; }
  .mt-timeline-2 > .mt-timeline-line {
    position: absolute;
    z-index: 1;
    height: 100%;
    width: 1px;
    top: 0;
    left: 50%;
    border-left: 4px solid;
    transform: translateX(-2px); }
  .mt-timeline-2 > .mt-container {
    position: relative;
    padding: 0; }
    .mt-timeline-2 > .mt-container > .mt-item {
      list-style: none;
      padding-bottom: 60px;
      clear: both; }
      .mt-timeline-2 > .mt-container > .mt-item .timeline-body-img.pull-left {
        margin-right: 15px; }
      .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-icon {
        width: 70px;
        height: 70px;
        background-color: #ccc;
        border-radius: 50% !important;
        position: absolute;
        left: 50%;
        transform: translateX(-50%);
        z-index: 5;
        border: 0;
        overflow: hidden; }
        .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-icon > i {
          top: 50%;
          left: 50%;
          transform: translateY(-50%) translateX(-50%);
          font-size: 24px; }
        .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-icon > img {
          width: 100%;
          height: auto; }
      .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content {
        width: 50%;
        display: inline-block;
        position: relative; }
        .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container {
          text-align: left;
          background-color: #f5f6fa;
          padding: 30px;
          border: 2px solid;
          border-color: #d3d7e9; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container:before, .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container:after {
            content: " ";
            display: table; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container:after {
            clear: both; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-author,
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-title {
            width: 50%;
            margin-bottom: 15px; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-content-title {
            opacity: 0.8 ;
            filter: alpha(opacity=80) ;
            margin-top: 10px;
            font-size: 18px;
            font-weight: 600; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-avatar {
            width: 40px;
            height: 40px;
            border-radius: 50% !important;
            overflow: hidden; }
            .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-avatar > img {
              width: 100%;
              height: auto; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-author-name,
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-author-name a {
            opacity: 0.9 ;
            filter: alpha(opacity=90) ;
            font-size: 15px;
            font-weight: 600;
            text-decoration: none; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-author-notes {
            font-size: 12px; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-content {
            padding-top: 15px;
            border-top: 1px solid;
            clear: both;
            line-height: 1.7em; }
            .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-content > p {
              opacity: 0.7 ;
              filter: alpha(opacity=70) ; }
            .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-content a, .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-content button {
              font-size: 14px; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .btn {
            display: inline-block;
            margin: 0 5px 10px 0; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .btn.pull-right {
            margin: 0 0 10px 5px; }
          .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container:before {
            content: '';
            position: absolute;
            top: 28px;
            height: 0;
            width: 0;
            border: 10px solid transparent; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) {
        text-align: left; }
        .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container {
          margin-right: 60px; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-title {
            float: left; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-author {
            float: right; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-avatar {
            float: right;
            margin-left: 15px; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-author-name,
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-author-notes {
            text-align: right; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container:before {
            right: 40px;
            border-left: 10px solid #d3d7e9; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) {
        text-align: right; }
        .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-icon > i {
          transform: translateY(-50%) translateX(50%);
          left: -50%; }
        .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container {
          margin-left: 60px; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container .mt-avatar {
            float: left;
            margin-right: 15px; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container .mt-title {
            float: right;
            text-align: right; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container .mt-author {
            float: left; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container .mt-author-name,
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container .mt-author-notes {
            text-align: left; }
          .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container:before {
            left: 40px;
            border-right: 10px solid #E9EDEF; }

@media (max-width: 991px) {
  /* 991px */
  .mt-timeline-2 > .mt-timeline-line {
    left: 25px; }
  .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-icon {
    left: 25px; }
    .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-icon > i {
      left: 0; }
  .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content {
    width: 100%; }
    .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-title {
      float: none;
      text-align: left !important; }
    .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-author,
    .mt-timeline-2 > .mt-container > .mt-item > .mt-timeline-content > .mt-content-container .mt-title {
      width: 100%; }
  .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) {
    text-align: right; }
    .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container {
      margin-left: 80px;
      margin-right: 0; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-avatar {
        float: left;
        margin-right: 15px; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-title {
        float: right;
        text-align: right; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-author {
        float: left; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-author-name,
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container .mt-author-notes {
        text-align: left; }
      .mt-timeline-2 > .mt-container > .mt-item:nth-child(odd) > .mt-timeline-content > .mt-content-container:before {
        left: 70px;
        border-right: 10px solid #E9EDEF;
        border-left: none; }
  .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container {
    margin-left: 80px;
    margin-right: 0; }
    .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container:before {
      left: 70px;
      border-right: 10px solid #E9EDEF;
      border-left: none; } }
@media (max-width: 480px) {
  .mt-timeline-2 .btn.pull-right,
  .mt-timeline-2 .btn-group.pull-right {
    float: none !important;
    margin: 0 5px 10px 0 !important; } }
@media (max-width: 400px) {
  .mt-timeline-2 > .mt-container > .mt-item:nth-child(even) > .mt-timeline-content > .mt-content-container .mt-author-notes {
    clear: both;
    padding-top: 10px; } }
/***
Horizontal Timeline 
***/
/* PLUGIN CSS */
.cd-horizontal-timeline {
  opacity: 0;
  -webkit-transition: opacity 0.2s;
  -moz-transition: opacity 0.2s;
  transition: opacity 0.2s; }

.cd-horizontal-timeline::before {
  /* never visible - this is used in jQuery to check the current MQ */
  content: 'mobile';
  display: none; }

.cd-horizontal-timeline.loaded {
  /* show the timeline after events position has been set (using JavaScript) */
  opacity: 1; }

.cd-horizontal-timeline .timeline {
  position: relative;
  height: 100px;
  width: 90%;
  max-width: 800px;
  margin: 0 auto; }

.cd-horizontal-timeline .events-wrapper {
  position: relative;
  height: 100%;
  margin: 0 40px;
  overflow: hidden; }

.cd-horizontal-timeline .events-wrapper::after, .cd-horizontal-timeline .events-wrapper::before {
  /* these are used to create a shadow effect at the sides of the timeline */
  content: '';
  position: absolute;
  z-index: 2;
  top: 0;
  height: 100%;
  width: 20px; }

.cd-horizontal-timeline .events-wrapper::before {
  left: 0;
  background-image: -webkit-linear-gradient(left, #f8f8f8, rgba(248, 248, 248, 0));
  background-image: linear-gradient(to right, #f8f8f8, rgba(248, 248, 248, 0)); }

.cd-horizontal-timeline .events-wrapper::after {
  right: 0;
  background-image: -webkit-linear-gradient(right, #f8f8f8, rgba(248, 248, 248, 0));
  background-image: linear-gradient(to left, #f8f8f8, rgba(248, 248, 248, 0)); }

.cd-horizontal-timeline .events {
  /* this is the grey line/timeline */
  position: absolute;
  z-index: 1;
  left: 0;
  top: 49px;
  height: 2px;
  /* width will be set using JavaScript */
  background: #dfdfdf;
  -webkit-transition: -webkit-transform 0.4s;
  -moz-transition: -moz-transform 0.4s;
  transition: transform 0.4s; }

.cd-horizontal-timeline .filling-line {
  /* this is used to create the green line filling the timeline */
  position: absolute;
  z-index: 1;
  left: 0;
  top: 0;
  height: 100%;
  width: 100%;
  background-color: #7b9d6f;
  -webkit-transform: scaleX(0);
  -moz-transform: scaleX(0);
  -ms-transform: scaleX(0);
  -o-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: left center;
  -moz-transform-origin: left center;
  -ms-transform-origin: left center;
  -o-transform-origin: left center;
  transform-origin: left center;
  -webkit-transition: -webkit-transform 0.3s;
  -moz-transition: -moz-transform 0.3s;
  transition: transform 0.3s; }

.cd-horizontal-timeline .events a {
  position: absolute;
  bottom: 0;
  z-index: 2;
  text-align: center;
  font-size: 1.3rem;
  padding-bottom: 15px;
  color: #383838;
  /* fix bug on Safari - text flickering while timeline translates */
  -webkit-transform: translateZ(0);
  -moz-transform: translateZ(0);
  -ms-transform: translateZ(0);
  -o-transform: translateZ(0);
  transform: translateZ(0); }

.cd-horizontal-timeline .events a::after {
  /* this is used to create the event spot */
  content: '';
  position: absolute;
  left: 50%;
  right: auto;
  -webkit-transform: translateX(-50%);
  -moz-transform: translateX(-50%);
  -ms-transform: translateX(-50%);
  -o-transform: translateX(-50%);
  transform: translateX(-50%);
  bottom: -5px;
  height: 12px;
  width: 12px;
  border-radius: 50%;
  -webkit-transition: background-color 0.3s, border-color 0.3s;
  -moz-transition: background-color 0.3s, border-color 0.3s;
  transition: background-color 0.3s, border-color 0.3s; }

.no-touch .cd-horizontal-timeline .events a:hover::after {
  background-color: #7b9d6f;
  border-color: #7b9d6f; }

.cd-horizontal-timeline .events a.selected {
  pointer-events: none; }

@media only screen and (min-width: 1100px) {
  .cd-horizontal-timeline::before {
    /* never visible - this is used in jQuery to check the current MQ */
    content: 'desktop'; } }
.cd-timeline-navigation a {
  /* these are the left/right arrows to navigate the timeline */
  position: absolute;
  z-index: 1;
  top: 50%;
  bottom: auto;
  -webkit-transform: translateY(-50%);
  -moz-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  -o-transform: translateY(-50%);
  transform: translateY(-50%);
  height: 34px;
  width: 34px;
  border-radius: 50%;
  border: 2px solid #dfdfdf;
  /* replace text with an icon */
  overflow: hidden;
  color: transparent;
  text-indent: 100%;
  white-space: nowrap;
  -webkit-transition: border-color 0.3s;
  -moz-transition: border-color 0.3s;
  transition: border-color 0.3s; }

.cd-timeline-navigation a.prev {
  left: 0; }

.cd-timeline-navigation a.next {
  right: 0; }

.cd-timeline-navigation a.inactive {
  cursor: not-allowed; }

.cd-timeline-navigation a.inactive::after {
  background-position: 0 -16px; }

.no-touch .cd-timeline-navigation a.inactive:hover {
  border-color: #dfdfdf; }

.cd-horizontal-timeline .events-content {
  position: relative;
  width: 100%;
  margin: 10px 0 0 0;
  overflow: hidden;
  -webkit-transition: height 0.4s;
  -moz-transition: height 0.4s;
  transition: height 0.4s; }

.cd-horizontal-timeline .events-content > ol > li {
  position: absolute;
  z-index: 1;
  width: 100%;
  left: 0;
  top: 0;
  -webkit-transform: translateX(-100%);
  -moz-transform: translateX(-100%);
  -ms-transform: translateX(-100%);
  -o-transform: translateX(-100%);
  transform: translateX(-100%);
  padding: 0;
  opacity: 0;
  -webkit-animation-duration: 0.4s;
  -moz-animation-duration: 0.4s;
  animation-duration: 0.4s;
  -webkit-animation-timing-function: ease-in-out;
  -moz-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out; }

.cd-horizontal-timeline .events-content > ol > li.selected {
  /* visible event content */
  position: relative;
  z-index: 2;
  opacity: 1;
  -webkit-transform: translateX(0);
  -moz-transform: translateX(0);
  -ms-transform: translateX(0);
  -o-transform: translateX(0);
  transform: translateX(0); }

.cd-horizontal-timeline .events-content > ol > li.enter-right, .cd-horizontal-timeline .events-content > ol > li.leave-right {
  -webkit-animation-name: cd-enter-right;
  -moz-animation-name: cd-enter-right;
  animation-name: cd-enter-right; }

.cd-horizontal-timeline .events-content > ol > li.enter-left, .cd-horizontal-timeline .events-content > ol > li.leave-left {
  -webkit-animation-name: cd-enter-left;
  -moz-animation-name: cd-enter-left;
  animation-name: cd-enter-left; }

.cd-horizontal-timeline .events-content > ol > li.leave-right, .cd-horizontal-timeline .events-content > ol > li.leave-left {
  -webkit-animation-direction: reverse;
  -moz-animation-direction: reverse;
  animation-direction: reverse; }

.cd-horizontal-timeline .events-content > ol > li {
  margin: 0 auto; }

.cd-horizontal-timeline .events-content em {
  display: block;
  font-style: italic;
  margin: 10px auto; }

.cd-horizontal-timeline .events-content em::before {
  content: '- '; }

@-webkit-keyframes cd-enter-right {
  0% {
    opacity: 0;
    -webkit-transform: translateX(100%); }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0%); } }
@-moz-keyframes cd-enter-right {
  0% {
    opacity: 0;
    -moz-transform: translateX(100%); }
  100% {
    opacity: 1;
    -moz-transform: translateX(0%); } }
@keyframes cd-enter-right {
  0% {
    opacity: 0;
    -webkit-transform: translateX(100%);
    -moz-transform: translateX(100%);
    -ms-transform: translateX(100%);
    -o-transform: translateX(100%);
    transform: translateX(100%); }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0%);
    -moz-transform: translateX(0%);
    -ms-transform: translateX(0%);
    -o-transform: translateX(0%);
    transform: translateX(0%); } }
@-webkit-keyframes cd-enter-left {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-100%); }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0%); } }
@-moz-keyframes cd-enter-left {
  0% {
    opacity: 0;
    -moz-transform: translateX(-100%); }
  100% {
    opacity: 1;
    -moz-transform: translateX(0%); } }
@keyframes cd-enter-left {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-100%);
    -moz-transform: translateX(-100%);
    -ms-transform: translateX(-100%);
    -o-transform: translateX(-100%);
    transform: translateX(-100%); }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0%);
    -moz-transform: translateX(0%);
    -ms-transform: translateX(0%);
    -o-transform: translateX(0%);
    transform: translateX(0%); } }
/* METRONIC EXTENDED CSS */
.mt-timeline-horizontal {
  font-size: 14px; }
  .mt-timeline-horizontal ol, .mt-timeline-horizontal ul {
    list-style: none; }
  .mt-timeline-horizontal blockquote, .mt-timeline-horizontal q {
    quotes: none; }
  .mt-timeline-horizontal blockquote:before, .mt-timeline-horizontal blockquote:after,
  .mt-timeline-horizontal q:before, .mt-timeline-horizontal q:after {
    content: '';
    content: none; }
  .mt-timeline-horizontal table {
    border-collapse: collapse;
    border-spacing: 0; }
  .mt-timeline-horizontal .timeline {
    width: 100%;
    max-width: 100%; }
    .mt-timeline-horizontal .timeline:before {
      background: transparent; }
    .mt-timeline-horizontal .timeline .events-wrapper .events a:after {
      background-color: transparent;
      border: 2px solid; }
    .mt-timeline-horizontal .timeline .events-wrapper .events a.selected:after {
      background-color: #fff !important; }
    .mt-timeline-horizontal .timeline .events-wrapper .events a:hover, .mt-timeline-horizontal .timeline .events-wrapper .events a:focus {
      text-decoration: none; }
    .mt-timeline-horizontal .timeline .events-wrapper:before, .mt-timeline-horizontal .timeline .events-wrapper:after {
      background-image: none; }
    .mt-timeline-horizontal .timeline .mt-ht-nav-icon li a {
      border-radius: 50% !important; }
      .mt-timeline-horizontal .timeline .mt-ht-nav-icon li a i {
        position: absolute;
        top: 50%;
        left: 0;
        transform: translateX(50%) translateY(-50%);
        width: 10px; }
    .mt-timeline-horizontal .timeline .mt-ht-nav-icon li:first-child a i {
      left: -2px; }
    .mt-timeline-horizontal .timeline.mt-timeline-square .events a:after {
      border-radius: 0 !important; }
    .mt-timeline-horizontal .timeline.mt-timeline-square .mt-ht-nav-icon li a {
      border-radius: 0 !important; }
  .mt-timeline-horizontal .events-content ol {
    padding: 0; }
    .mt-timeline-horizontal .events-content ol li .mt-title {
      margin-top: 15px;
      float: left;
      width: 60%; }
      .mt-timeline-horizontal .events-content ol li .mt-title h2 {
        margin: 0;
        opacity: 0.8 ;
        filter: alpha(opacity=80) ;
        font-size: 18px;
        font-weight: 600; }
    .mt-timeline-horizontal .events-content ol li .mt-author {
      float: right;
      position: relative;
      text-align: right;
      width: 40%; }
      .mt-timeline-horizontal .events-content ol li .mt-author > .mt-avatar {
        float: right;
        margin-left: 15px; }
      .mt-timeline-horizontal .events-content ol li .mt-author > .mt-author-name {
        margin-top: 5px; }
        .mt-timeline-horizontal .events-content ol li .mt-author > .mt-author-name a {
          opacity: 0.9 ;
          filter: alpha(opacity=90) ;
          font-size: 15px;
          font-weight: 600; }
          .mt-timeline-horizontal .events-content ol li .mt-author > .mt-author-name a:hover, .mt-timeline-horizontal .events-content ol li .mt-author > .mt-author-name a:focus {
            text-decoration: none; }
      .mt-timeline-horizontal .events-content ol li .mt-author > .mt-author-datetime {
        font-size: 13px; }
      .mt-timeline-horizontal .events-content ol li .mt-author > .mt-avatar {
        width: 50px;
        height: 50px;
        border-radius: 50% !important;
        overflow: hidden; }
        .mt-timeline-horizontal .events-content ol li .mt-author > .mt-avatar > img {
          width: 100%;
          height: auto; }
    .mt-timeline-horizontal .events-content ol li .mt-content {
      margin-top: 20px;
      padding-top: 20px;
      border-top: 1px solid;
      clear: both;
      line-height: 1.7em; }
      .mt-timeline-horizontal .events-content ol li .mt-content > p {
        opacity: 0.7 ;
        filter: alpha(opacity=70) ; }
      .mt-timeline-horizontal .events-content ol li .mt-content img.pull-left {
        margin: 0 15px 15px 0; }
      .mt-timeline-horizontal .events-content ol li .mt-content img.pull-right {
        margin: 0 0 15px 15px; }
      .mt-timeline-horizontal .events-content ol li .mt-content .btn-group .dropdown-menu {
        margin-right: 5px; }

@media (max-width: 480px) {
  .mt-timeline-horizontal .events-content ol li .mt-title {
    width: 100%; }
  .mt-timeline-horizontal .events-content ol li .mt-author {
    width: 100%;
    margin-top: 15px;
    text-align: left; }
    .mt-timeline-horizontal .events-content ol li .mt-author > .mt-avatar {
      float: left;
      margin-right: 15px;
      margin-left: 0; }
    .mt-timeline-horizontal .events-content ol li .mt-author > .mt-author-name {
      margin-top: 10px; }
  .mt-timeline-horizontal .btn.pull-right {
    float: none !important;
    margin: 0 !important; } }
/***
Tasks Widget 
***/
.tasks-widget:after {
  clear: both; }
.tasks-widget .task-list {
  list-style: none;
  padding: 0;
  margin: 0; }
  .tasks-widget .task-list > li {
    position: relative;
    padding: 10px 10px;
    border-bottom: 1px solid #F4F6F9; }
    .tasks-widget .task-list > li:hover {
      background: #F4F6F9; }
    .tasks-widget .task-list > li.last-line {
      border-bottom: none; }
    .tasks-widget .task-list > li.task-done {
      background: #f6f6f6; }
      .tasks-widget .task-list > li.task-done:hover {
        background: #f4f4f4; }
      .tasks-widget .task-list > li.task-done .task-title-sp {
        text-decoration: line-through; }
    .tasks-widget .task-list > li > .task-bell {
      margin-left: 10px; }
    .tasks-widget .task-list > li > .task-checkbox {
      float: left;
      width: 30px; }
      .tasks-widget .task-list > li > .task-checkbox input[type="checkbox"] {
        cursor: pointer; }
    .tasks-widget .task-list > li > .task-title {
      color: #838FA1;
      margin-right: 10px; }
      .tasks-widget .task-list > li > .task-title .task-title-sp {
        margin-right: 5px; }
    .tasks-widget .task-list > li .task-config-btn {
      margin-top: -1px; }
    .tasks-widget .task-list > li > .task-config {
      display: none;
      position: absolute;
      top: 7px;
      right: 10px; }
    .tasks-widget .task-list > li:hover > .task-config {
      display: block;
      margin-bottom: 0 !important; }
.tasks-widget .task-footer {
  margin-top: 5px; }
  .tasks-widget .task-footer:before, .tasks-widget .task-footer:after {
    content: " ";
    display: table; }
  .tasks-widget .task-footer:after {
    clear: both; }

@media only screen and (max-width: 480px) {
  .tasks-widget .task-config-btn {
    float: inherit;
    display: block; }
  .tasks-widget .task-list-projects li > .label {
    margin-bottom: 5px; } }
.mt-comments .mt-comment {
  padding: 10px;
  margin: 0 0 10px 0; }
  .mt-comments .mt-comment .mt-comment-img {
    width: 40px;
    float: left; }
    .mt-comments .mt-comment .mt-comment-img > img {
      border-radius: 50% !important; }
  .mt-comments .mt-comment .mt-comment-body {
    padding-left: 20px;
    position: relative;
    overflow: hidden; }
    .mt-comments .mt-comment .mt-comment-body .mt-comment-info:before, .mt-comments .mt-comment .mt-comment-body .mt-comment-info:after {
      content: " ";
      display: table; }
    .mt-comments .mt-comment .mt-comment-body .mt-comment-info:after {
      clear: both; }
    .mt-comments .mt-comment .mt-comment-body .mt-comment-info .mt-comment-author {
      display: inline-block;
      float: left;
      margin: 0px 0px 10px 0;
      color: #060606;
      font-weight: 600; }
    .mt-comments .mt-comment .mt-comment-body .mt-comment-info .mt-comment-date {
      display: inline-block;
      float: right;
      margin: 0px;
      color: #BABABA; }
    .mt-comments .mt-comment .mt-comment-body .mt-comment-text {
      color: #999999; }
    .mt-comments .mt-comment .mt-comment-body .mt-comment-details {
      margin: 10px 0px 0px 0; }
      .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-status {
        text-transform: uppercase;
        float: left; }
        .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-status.mt-comment-status-pending {
          color: #B8C0F5; }
        .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-status.mt-comment-status-approved {
          color: #6BD873; }
        .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-status.mt-comment-status-rejected {
          color: red; }
      .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-actions {
        display: none;
        list-style: none;
        margin: 0;
        padding: 0;
        float: right; }
        .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-actions > li {
          float: left;
          padding: 0 5px;
          margin: 0; }
          .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-actions > li > a {
            text-transform: uppercase;
            color: #999999; }
            .mt-comments .mt-comment .mt-comment-body .mt-comment-details .mt-comment-actions > li > a:hover {
              color: #666666;
              text-decoration: none; }
  .mt-comments .mt-comment:hover {
    background: #f9f9f9; }
    .mt-comments .mt-comment:hover .mt-comment-body .mt-comment-details .mt-comment-actions {
      display: inline-block; }

.mt-actions .mt-action {
  margin: 0px;
  padding: 15px 0 15px 0;
  border-bottom: 1px solid #f7f8f9; }
  .mt-actions .mt-action:last-child {
    border-bottom: 0px; }
  .mt-actions .mt-action .mt-action-img {
    width: 40px;
    float: left; }
    .mt-actions .mt-action .mt-action-img > img {
      border-radius: 50% !important;
      margin-bottom: 2px; }
  .mt-actions .mt-action .mt-action-body {
    padding-left: 15px;
    position: relative;
    overflow: hidden; }
    .mt-actions .mt-action .mt-action-body .mt-action-row {
      display: table;
      width: 100%; }
      .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info {
        display: table-cell;
        vertical-align: top; }
        .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info .mt-action-icon {
          display: table-cell;
          padding: 6px 20px 6px 6px; }
          .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info .mt-action-icon > i {
            display: inline-block;
            position: relative;
            top: 10px;
            font-size: 25px;
            color: #78E0E8; }
        .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info .mt-action-details {
          display: table-cell;
          vertical-align: top; }
          .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info .mt-action-details .mt-action-author {
            color: #060606;
            font-weight: 600; }
          .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info .mt-action-details .mt-action-desc {
            margin-bottom: 0;
            color: #999b9b; }
      .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-datetime {
        vertical-align: top;
        display: table-cell;
        text-align: center;
        width: 150px;
        white-space: nowrap;
        padding-top: 15px;
        color: #A6A8A8; }
        .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-datetime .mt-action-dot {
          display: inline-block;
          width: 10px;
          height: 10px;
          background-color: red;
          border-radius: 50% !important;
          margin-left: 5px;
          margin-right: 5px; }
      .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-buttons {
        vertical-align: top;
        display: table-cell;
        text-align: center;
        width: 160px;
        white-space: nowrap;
        padding-top: 10px; }

@media (max-width: 767px) {
  /* 767px */
  .mt-actions .mt-action .mt-action-body .mt-action-row {
    display: block; }
    .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-info {
      display: block; }
    .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-datetime {
      display: inline-block;
      margin-left: 40px; }
    .mt-actions .mt-action .mt-action-body .mt-action-row .mt-action-buttons {
      display: inline-block;
      float: right; } }
.mt-widget-1 {
  border: 1px solid #e7ecf1;
  text-align: center;
  position: relative; }
  .mt-widget-1 .mt-icon {
    position: absolute;
    right: 10px;
    top: 10px;
    margin: 7px;
    font-size: 20px; }
    .mt-widget-1 .mt-icon > a > i {
      color: #a1e5e1; }
    .mt-widget-1 .mt-icon > a:hover > i {
      color: #79dad5; }
  .mt-widget-1 .mt-img {
    display: inline-block;
    border-radius: 50% !important;
    border: 4px solid #e7ecf1;
    margin: 40px 0 30px 0; }
    .mt-widget-1 .mt-img > img {
      border: 1px solid trnsparent;
      border-radius: 50% !important; }
  .mt-widget-1 .mt-body .mt-username {
    text-align: center;
    margin: 5px 10px;
    font-weight: 600;
    font-size: 16px; }
  .mt-widget-1 .mt-body .mt-user-title {
    text-align: center;
    margin: 10px 10px 10px 10px;
    color: #666666;
    font-size: 13px; }
  .mt-widget-1 .mt-body .mt-stats {
    margin: 30px 0px 0px 0px; }
    .mt-widget-1 .mt-body .mt-stats .btn-group {
      border-top: 1px solid #e7ecf1; }
      .mt-widget-1 .mt-body .mt-stats .btn-group .btn {
        padding: 10px 10px;
        font-size: 14px;
        border-right: 1px solid #e7ecf1; }
        .mt-widget-1 .mt-body .mt-stats .btn-group .btn:hover {
          background-color: #e7ecf1; }
        .mt-widget-1 .mt-body .mt-stats .btn-group .btn:last-child {
          border: 0; }
        .mt-widget-1 .mt-body .mt-stats .btn-group .btn > i {
          position: relative;
          top: 3px;
          right: 2px;
          font-size: 16px; }
        .mt-widget-1 .mt-body .mt-stats .btn-group .btn:first-child {
          border-bottom-left-radius: 2px !important; }
        .mt-widget-1 .mt-body .mt-stats .btn-group .btn:last-child {
          border-bottom-right-radius: 2px !important; }

.mt-widget-2 {
  border: 1px solid #e7ecf1;
  position: relative; }
  .mt-widget-2 .mt-head {
    position: absolute;
    width: 100%;
    background-size: 100% 100%; }
    .mt-widget-2 .mt-head .mt-head-label {
      position: absolute;
      top: 8px;
      right: 8px;
      cursor: pointer; }
      .mt-widget-2 .mt-head .mt-head-label > button {
        font-size: 13px;
        border-radius: 2px !important; }
    .mt-widget-2 .mt-head .mt-head-user .mt-head-user-img {
      position: relative;
      float: left;
      margin: 165px 32px 18px 35px; }
      .mt-widget-2 .mt-head .mt-head-user .mt-head-user-img::after {
        content: "";
        position: absolute;
        top: 90%;
        left: 50%;
        margin-left: -15px;
        border-width: 13px;
        border-style: solid;
        border-color: transparent transparent white  transparent; }
      .mt-widget-2 .mt-head .mt-head-user .mt-head-user-img > img {
        width: 65px;
        border-radius: 50% !important; }
    .mt-widget-2 .mt-head .mt-head-user .mt-head-user-info {
      margin: 175px 0 0 -9px;
      color: white;
      display: inline-block; }
      .mt-widget-2 .mt-head .mt-head-user .mt-head-user-info .mt-user-name {
        display: block;
        font-size: 15px; }
      .mt-widget-2 .mt-head .mt-head-user .mt-head-user-info .mt-user-time {
        font-size: 13px;
        display: block; }
        .mt-widget-2 .mt-head .mt-head-user .mt-head-user-info .mt-user-time > i {
          position: relative;
          top: 1px;
          font-size: 13px; }
  .mt-widget-2 .mt-body {
    padding-top: 160px;
    text-align: center; }
    .mt-widget-2 .mt-body .mt-body-title {
      margin-top: 130px;
      font-weight: 600;
      font-size: 16px; }
    .mt-widget-2 .mt-body .mt-body-description {
      margin-top: 10px;
      display: inline-block;
      color: #666666;
      font-size: 13px;
      padding: 0 10px; }
    .mt-widget-2 .mt-body .mt-body-stats {
      padding: 0; }
      .mt-widget-2 .mt-body .mt-body-stats:before, .mt-widget-2 .mt-body .mt-body-stats:after {
        content: " ";
        display: table; }
      .mt-widget-2 .mt-body .mt-body-stats:after {
        clear: both; }
      .mt-widget-2 .mt-body .mt-body-stats > li {
        margin: 15px;
        list-style: none;
        display: inline-block; }
    .mt-widget-2 .mt-body .mt-body-actions {
      border-top: 1px solid #e7ecf1; }
      .mt-widget-2 .mt-body .mt-body-actions > i {
        font-size: 18px; }
      .mt-widget-2 .mt-body .mt-body-actions .btn {
        font-size: 14px;
        border-right: 1px solid #e7ecf1;
        padding: 12px 0 12px 0;
        text-align: center; }
        .mt-widget-2 .mt-body .mt-body-actions .btn:last-child {
          border: 0; }

.mt-widget-3 {
  border: 1px solid #e7ecf1; }
  .mt-widget-3 .mt-head {
    background-color: #5DC9E6;
    margin-bottom: 20px;
    color: white;
    padding: 15px 0; }
    .mt-widget-3 .mt-head .mt-head-icon {
      font-size: 35px;
      text-align: center;
      padding-top: 20px;
      margin-bottom: 10px; }
    .mt-widget-3 .mt-head .mt-head-desc {
      margin-left: 10px;
      margin-right: 10px;
      text-align: center;
      color: #fff;
      opacity: 0.8 ;
      filter: alpha(opacity=80) ; }
    .mt-widget-3 .mt-head .mt-head-date {
      text-align: center;
      margin-top: 20px;
      display: block;
      color: #f2f2f2; }
    .mt-widget-3 .mt-head .mt-head-button {
      margin: 10px 0;
      text-align: center;
      padding: 20px; }
      .mt-widget-3 .mt-head .mt-head-button > button {
        width: 90px; }
  .mt-widget-3 .mt-body-actions-icons .btn-group {
    margin-bottom: 20px; }
    .mt-widget-3 .mt-body-actions-icons .btn-group .mt-icon {
      display: block;
      position: relative;
      padding: 5px;
      font-size: 15px; }
  .mt-widget-3 .mt-body-actions-icons .btn {
    border-right: 1px solid #e7ecf1;
    font-size: 11px;
    text-align: center;
    padding: 0; }
    .mt-widget-3 .mt-body-actions-icons .btn:last-child {
      border-right: 0; }

.mt-widget-4 {
  min-height: 250px;
  color: white;
  background-color: #26C0B8; }
  .mt-widget-4 .mt-img-container {
    position: relative; }
    .mt-widget-4 .mt-img-container > img {
      height: 250px;
      width: 100%; }
  .mt-widget-4 .mt-container {
    width: 150px;
    background-color: #26C0B8;
    min-height: 250px;
    position: absolute;
    right: 15px;
    top: 0; }
    .mt-widget-4 .mt-container .mt-head-title {
      text-align: center;
      margin-top: 20px;
      padding: 10px; }
    .mt-widget-4 .mt-container .mt-body-icons {
      margin-top: 30px;
      text-align: center; }
      .mt-widget-4 .mt-container .mt-body-icons > a {
        color: #e6e6e6;
        display: inline-block;
        padding: 10px;
        font-size: 17px; }
        .mt-widget-4 .mt-container .mt-body-icons > a:hover {
          color: #fff; }
    .mt-widget-4 .mt-container .mt-footer-button {
      margin-top: 30px;
      position: absolute;
      right: 0; }
      .mt-widget-4 .mt-container .mt-footer-button > .btn {
        width: 90px;
        border-top-right-radius: 0 !important;
        border-bottom-right-radius: 0 !important;
        border: none !important; }

body.stop-scrolling {
  height: auto !important;
  overflow: visible !important; }

.sweet-alert .sa-icon.sa-success .sa-placeholder,
.sweet-alert .sa-icon {
  border-radius: 50% !important; }

.sweet-alert h2 {
  font-size: 20px;
  padding-top: 5px; }

.sweet-alert p {
  font-size: 14px; }

.sweet-alert .btn {
  font-size: 14px;
  padding: 8px 14px; }
  .sweet-alert .btn:focus {
    border-color: transparent; }

.mt-sweetalert:hover {
  cursor: pointer; }
.mt-sweetalert.mt-italic {
  font-style: italic; }
.mt-sweetalert:focus {
  outline: none !important;
  border: 1px solid transparent; }

.mt-sweetalert-title {
  margin: 30px 0 15px 0; }

.mt-clipboard-container {
  padding: 20px; }
  .mt-clipboard-container .mt-clipboard {
    margin: 10px 10px 10px 0; }

.mt-multiselect {
  text-align: left;
  position: relative; }
  .mt-multiselect .caret {
    position: absolute;
    top: 50%;
    margin-top: -2px;
    right: 15px; }
  .mt-multiselect.mt-noicon .caret {
    display: none; }

.mt-code {
  padding: 3px;
  color: #E43A45;
  border-radius: 4px !important;
  display: inline;
  word-wrap: normal; }

.caption-desc {
  font-size: 13px;
  margin-top: 0.5em;
  line-height: 2.3em; }

.mt-element-step .row {
  margin: 0; }
.mt-element-step .step-default .mt-step-col {
  padding-top: 30px;
  padding-bottom: 30px;
  text-align: center; }
.mt-element-step .step-default .mt-step-number {
  font-size: 26px;
  border-radius: 50% !important;
  display: inline-block;
  margin: auto;
  padding: 3px 14px;
  margin-bottom: 20px; }
.mt-element-step .step-default .mt-step-title {
  font-size: 30px;
  font-weight: 100; }
.mt-element-step .step-default .active {
  background-color: #32c5d2 !important; }
  .mt-element-step .step-default .active .mt-step-number {
    color: #32c5d2 !important; }
  .mt-element-step .step-default .active .mt-step-title,
  .mt-element-step .step-default .active .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-default .done {
  background-color: #26C281 !important; }
  .mt-element-step .step-default .done .mt-step-number {
    color: #26C281 !important; }
  .mt-element-step .step-default .done .mt-step-title,
  .mt-element-step .step-default .done .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-default .error {
  background-color: #E7505A !important; }
  .mt-element-step .step-default .error .mt-step-number {
    color: #E7505A !important; }
  .mt-element-step .step-default .error .mt-step-title,
  .mt-element-step .step-default .error .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-thin .mt-step-col {
  padding-top: 10px;
  padding-bottom: 10px; }
.mt-element-step .step-thin .mt-step-number {
  font-size: 26px;
  border-radius: 50% !important;
  float: left;
  margin: auto;
  padding: 3px 14px; }
.mt-element-step .step-thin .mt-step-title {
  font-size: 24px;
  font-weight: 100;
  padding-left: 60px;
  margin-top: -4px; }
.mt-element-step .step-thin .mt-step-content {
  padding-left: 60px;
  margin-top: -5px; }
.mt-element-step .step-thin .active {
  background-color: #32c5d2 !important; }
  .mt-element-step .step-thin .active .mt-step-number {
    color: #32c5d2 !important; }
  .mt-element-step .step-thin .active .mt-step-title,
  .mt-element-step .step-thin .active .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-thin .done {
  background-color: #26C281 !important; }
  .mt-element-step .step-thin .done .mt-step-number {
    color: #26C281 !important; }
  .mt-element-step .step-thin .done .mt-step-title,
  .mt-element-step .step-thin .done .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-thin .error {
  background-color: #E7505A !important; }
  .mt-element-step .step-thin .error .mt-step-number {
    color: #E7505A !important; }
  .mt-element-step .step-thin .error .mt-step-title,
  .mt-element-step .step-thin .error .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-background .mt-step-col {
  padding-top: 30px;
  padding-bottom: 30px;
  text-align: center;
  height: 160px; }
.mt-element-step .step-background .mt-step-number {
  font-size: 200px;
  position: absolute;
  bottom: 0;
  right: 0;
  line-height: 0.79em;
  color: #dae1e4;
  z-index: 4; }
.mt-element-step .step-background .mt-step-title {
  font-size: 30px;
  font-weight: 100;
  text-align: right;
  padding-right: 25%;
  z-index: 5;
  position: relative; }
.mt-element-step .step-background .mt-step-content {
  text-align: right;
  padding-right: 25%;
  z-index: 5;
  position: relative; }
.mt-element-step .step-background .active {
  background-color: #32c5d2 !important; }
  .mt-element-step .step-background .active .mt-step-number {
    color: #2ab4c0 !important; }
  .mt-element-step .step-background .active .mt-step-title,
  .mt-element-step .step-background .active .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-background .done {
  background-color: #26C281 !important; }
  .mt-element-step .step-background .done .mt-step-number {
    color: #22ad73 !important; }
  .mt-element-step .step-background .done .mt-step-title,
  .mt-element-step .step-background .done .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-background .error {
  background-color: #E7505A !important; }
  .mt-element-step .step-background .error .mt-step-number {
    color: #e43a45 !important; }
  .mt-element-step .step-background .error .mt-step-title,
  .mt-element-step .step-background .error .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-background-thin .mt-step-col {
  padding-top: 15px;
  padding-bottom: 15px;
  text-align: center; }
.mt-element-step .step-background-thin .mt-step-number {
  font-size: 120px;
  position: absolute;
  bottom: 0;
  right: 0;
  line-height: 0.79em;
  color: #dae1e4;
  z-index: 4; }
.mt-element-step .step-background-thin .mt-step-title {
  font-size: 30px;
  font-weight: 100;
  text-align: right;
  padding-right: 25%;
  z-index: 5;
  position: relative; }
.mt-element-step .step-background-thin .mt-step-content {
  text-align: right;
  position: relative;
  padding-right: 25%;
  z-index: 5; }
.mt-element-step .step-background-thin .active {
  background-color: #32c5d2 !important; }
  .mt-element-step .step-background-thin .active .mt-step-number {
    color: #2ab4c0 !important; }
  .mt-element-step .step-background-thin .active .mt-step-title,
  .mt-element-step .step-background-thin .active .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-background-thin .done {
  background-color: #26C281 !important; }
  .mt-element-step .step-background-thin .done .mt-step-number {
    color: #22ad73 !important; }
  .mt-element-step .step-background-thin .done .mt-step-title,
  .mt-element-step .step-background-thin .done .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-background-thin .error {
  background-color: #E7505A !important; }
  .mt-element-step .step-background-thin .error .mt-step-number {
    color: #e43a45 !important; }
  .mt-element-step .step-background-thin .error .mt-step-title,
  .mt-element-step .step-background-thin .error .mt-step-content {
    color: #fff !important; }
.mt-element-step .step-no-background .mt-step-col {
  padding-top: 30px;
  padding-bottom: 30px;
  text-align: center; }
.mt-element-step .step-no-background .mt-step-number {
  font-size: 26px;
  border-radius: 50% !important;
  display: inline-block;
  margin: auto;
  padding: 3px 14px;
  margin-bottom: 20px;
  border: 1px solid;
  border-color: #e5e5e5; }
.mt-element-step .step-no-background .mt-step-title {
  font-size: 30px;
  font-weight: 100; }
.mt-element-step .step-no-background .active .mt-step-number {
  color: #32c5d2 !important;
  border-color: #32c5d2 !important;
  font-weight: 700; }
.mt-element-step .step-no-background .active .mt-step-title,
.mt-element-step .step-no-background .active .mt-step-content {
  color: #32c5d2 !important;
  font-weight: 700; }
.mt-element-step .step-no-background .done .mt-step-number {
  color: #26C281 !important;
  border-color: #26C281 !important;
  font-weight: 700; }
.mt-element-step .step-no-background .done .mt-step-title,
.mt-element-step .step-no-background .done .mt-step-content {
  color: #26C281 !important;
  font-weight: 700; }
.mt-element-step .step-no-background .error .mt-step-number {
  color: #E7505A !important;
  border-color: #E7505A !important;
  font-weight: 700; }
.mt-element-step .step-no-background .error .mt-step-title,
.mt-element-step .step-no-background .error .mt-step-content {
  color: #E7505A !important;
  font-weight: 700; }
.mt-element-step .step-no-background-thin .mt-step-col {
  padding-top: 10px;
  padding-bottom: 10px; }
.mt-element-step .step-no-background-thin .mt-step-number {
  font-size: 26px;
  border-radius: 50% !important;
  float: left;
  margin: auto;
  padding: 3px 14px;
  border: 1px solid;
  border-color: #e5e5e5; }
.mt-element-step .step-no-background-thin .mt-step-title {
  font-size: 24px;
  font-weight: 100;
  padding-left: 60px;
  margin-top: -4px; }
.mt-element-step .step-no-background-thin .mt-step-content {
  padding-left: 60px;
  margin-top: -5px; }
.mt-element-step .step-no-background-thin .active .mt-step-number {
  color: #32c5d2 !important;
  border-color: #32c5d2 !important;
  font-weight: 700; }
.mt-element-step .step-no-background-thin .active .mt-step-title,
.mt-element-step .step-no-background-thin .active .mt-step-content {
  color: #32c5d2 !important;
  font-weight: 700; }
.mt-element-step .step-no-background-thin .done .mt-step-number {
  color: #26C281 !important;
  border-color: #26C281 !important;
  font-weight: 700; }
.mt-element-step .step-no-background-thin .done .mt-step-title,
.mt-element-step .step-no-background-thin .done .mt-step-content {
  color: #26C281 !important;
  font-weight: 700; }
.mt-element-step .step-no-background-thin .error .mt-step-number {
  color: #E7505A !important;
  border-color: #E7505A !important;
  font-weight: 700; }
.mt-element-step .step-no-background-thin .error .mt-step-title,
.mt-element-step .step-no-background-thin .error .mt-step-content {
  color: #E7505A !important;
  font-weight: 700; }
.mt-element-step .step-line .mt-step-col {
  padding: 30px 0;
  text-align: center; }
.mt-element-step .step-line .mt-step-number {
  font-size: 26px;
  border-radius: 50% !important;
  display: inline-block;
  margin: auto;
  padding: 9px;
  margin-bottom: 5px;
  border: 3px solid;
  border-color: #e5e5e5;
  position: relative;
  z-index: 5;
  height: 60px;
  width: 60px;
  text-align: center; }
  .mt-element-step .step-line .mt-step-number > i {
    position: relative;
    top: 50%;
    transform: translateY(-120%); }
.mt-element-step .step-line .mt-step-title {
  font-size: 20px;
  font-weight: 400;
  position: relative; }
  .mt-element-step .step-line .mt-step-title:after {
    content: '';
    height: 3px;
    width: 50%;
    position: absolute;
    background-color: #e5e5e5;
    top: -32px;
    left: 50%;
    z-index: 4;
    transform: translateY(-100%); }
  .mt-element-step .step-line .mt-step-title:before {
    content: '';
    height: 3px;
    width: 50%;
    position: absolute;
    background-color: #e5e5e5;
    top: -32px;
    right: 50%;
    z-index: 4;
    transform: translateY(-100%); }
.mt-element-step .step-line .first .mt-step-title:before {
  content: none; }
.mt-element-step .step-line .last .mt-step-title:after {
  content: none; }
.mt-element-step .step-line .active .mt-step-number {
  color: #32c5d2 !important;
  border-color: #32c5d2 !important; }
.mt-element-step .step-line .active .mt-step-title,
.mt-element-step .step-line .active .mt-step-content {
  color: #32c5d2 !important; }
.mt-element-step .step-line .active .mt-step-title:after, .mt-element-step .step-line .active .mt-step-title:before {
  background-color: #32c5d2; }
.mt-element-step .step-line .done .mt-step-number {
  color: #26C281 !important;
  border-color: #26C281 !important; }
.mt-element-step .step-line .done .mt-step-title,
.mt-element-step .step-line .done .mt-step-content {
  color: #26C281 !important; }
.mt-element-step .step-line .done .mt-step-title:after, .mt-element-step .step-line .done .mt-step-title:before {
  background-color: #26C281; }
.mt-element-step .step-line .error .mt-step-number {
  color: #E7505A !important;
  border-color: #E7505A !important; }
.mt-element-step .step-line .error .mt-step-title,
.mt-element-step .step-line .error .mt-step-content {
  color: #E7505A !important; }
.mt-element-step .step-line .error .mt-step-title:after, .mt-element-step .step-line .error .mt-step-title:before {
  background-color: #E7505A; }

@media (max-width: 991px) {
  /* 991px */
  .mt-element-step .step-line .mt-step-title:after {
    content: none; }
  .mt-element-step .step-line .mt-step-title:before {
    content: none; } }
.mt-element-list .list-default.mt-list-head {
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
  padding: 15px; }
  .mt-element-list .list-default.mt-list-head .list-title {
    margin: 0 0 0.7em 0;
    font-size: 18px; }
  .mt-element-list .list-default.mt-list-head .list-date {
    font-size: 12px; }
  .mt-element-list .list-default.mt-list-head .list-pending {
    margin-bottom: 10px; }
  .mt-element-list .list-default.mt-list-head .list-count {
    display: inline-block;
    padding: 3px 7px; }
    .mt-element-list .list-default.mt-list-head .list-count.last {
      margin-bottom: 0; }
  .mt-element-list .list-default.mt-list-head .list-label {
    display: inline-block;
    font-size: 12px; }
.mt-element-list .list-default.mt-list-container {
  border-left: 1px solid;
  border-right: 1px solid;
  border-bottom: 1px solid;
  border-color: #e7ecf1;
  padding: 15px; }
  .mt-element-list .list-default.mt-list-container .mt-list-title {
    padding-bottom: 15px;
    font-size: 14px;
    font-weight: 700; }
  .mt-element-list .list-default.mt-list-container ul {
    margin-bottom: 0;
    padding: 0; }
    .mt-element-list .list-default.mt-list-container ul > .mt-list-item {
      list-style: none;
      border-bottom: 1px solid;
      border-color: #e7ecf1;
      padding: 25px 0;
      min-height: 45px; }
      .mt-element-list .list-default.mt-list-container ul > .mt-list-item:first-child {
        padding-top: 0; }
      .mt-element-list .list-default.mt-list-container ul > .mt-list-item:last-child {
        padding-bottom: 0;
        border: none; }
      .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-icon-container {
        border: 1px solid;
        border-color: #e7ecf1;
        border-radius: 50% !important;
        padding: 0.9em;
        float: left;
        width: 45px;
        height: 45px; }
        .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-icon-container > a {
          color: #34495e; }
          .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-icon-container > a:hover {
            color: #26C281;
            text-decoration: none; }
        .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-icon-container.done {
          border-color: #26C281; }
          .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-icon-container.done > a {
            color: #26C281; }
            .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-icon-container.done > a:hover {
              color: #26C281;
              text-decoration: none; }
      .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-item-content {
        padding: 0 75px 0 60px; }
        .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-item-content > h3 {
          margin-top: 0;
          margin-bottom: 5px;
          font-size: 16px; }
          .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a {
            color: #34495e; }
            .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a:hover {
              color: #26C281;
              text-decoration: none; }
        .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-item-content > p {
          margin: 0; }
      .mt-element-list .list-default.mt-list-container ul > .mt-list-item > .list-datetime {
        text-align: right;
        float: right;
        width: 60px; }
.mt-element-list .list-default.ext-1.mt-list-container {
  padding: 15px 0 0 0; }
  .mt-element-list .list-default.ext-1.mt-list-container .mt-list-title {
    padding: 0 15px 15px 15px; }
  .mt-element-list .list-default.ext-1.mt-list-container ul > .mt-list-item {
    padding: 15px;
    border-left: 3px solid;
    border-color: #2F353B;
    border-bottom-color: #e7ecf1; }
    .mt-element-list .list-default.ext-1.mt-list-container ul > .mt-list-item:hover {
      background-color: #e5e5e5; }
    .mt-element-list .list-default.ext-1.mt-list-container ul > .mt-list-item.done {
      border-color: #26C281;
      border-bottom-color: #e7ecf1; }
      .mt-element-list .list-default.ext-1.mt-list-container ul > .mt-list-item.done:hover {
        background-color: #96ebc8; }
    .mt-element-list .list-default.ext-1.mt-list-container ul > .mt-list-item > .list-icon-container {
      border: none; }
.mt-element-list .list-default.group .list-toggle-container:hover, .mt-element-list .list-default.group .list-toggle-container:focus, .mt-element-list .list-default.group .list-toggle-container:active {
  text-decoration: none; }
.mt-element-list .list-default.group .list-toggle-container .list-toggle {
  padding: 15px;
  background-color: #2F353B;
  font-weight: 700;
  color: #fff;
  text-decoration: none; }
  .mt-element-list .list-default.group .list-toggle-container .list-toggle.done {
    background-color: #26C281; }
.mt-element-list .list-simple.mt-list-head {
  padding: 15px; }
  .mt-element-list .list-simple.mt-list-head .list-title {
    margin: 0;
    padding-right: 85px; }
  .mt-element-list .list-simple.mt-list-head .list-date {
    font-size: 12px;
    opacity: 0.8;
    float: right;
    width: 75px; }
.mt-element-list .list-simple.mt-list-container {
  border-left: 1px solid;
  border-right: 1px solid;
  border-bottom: 1px solid;
  border-color: #e7ecf1;
  padding: 15px; }
  .mt-element-list .list-simple.mt-list-container ul {
    margin-bottom: 0;
    padding: 0; }
    .mt-element-list .list-simple.mt-list-container ul > .mt-list-item {
      list-style: none;
      border-bottom: 1px solid;
      border-color: #e7ecf1;
      padding: 15px 0; }
      .mt-element-list .list-simple.mt-list-container ul > .mt-list-item:first-child {
        padding-top: 0; }
      .mt-element-list .list-simple.mt-list-container ul > .mt-list-item:last-child {
        padding-bottom: 0;
        border: none; }
      .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-icon-container {
        font-size: 14px;
        float: left; }
        .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-icon-container > a {
          color: #34495e; }
          .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-icon-container > a:hover {
            color: #26C281;
            text-decoration: none; }
        .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-icon-container.done {
          color: #26C281; }
          .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-icon-container.done > a {
            color: #26C281; }
            .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-icon-container.done > a:hover {
              color: #26C281;
              text-decoration: none; }
      .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-item-content {
        padding: 0 75px 0 60px; }
        .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-item-content > h3 {
          margin: 0;
          font-size: 18px; }
          .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a {
            color: #34495e; }
            .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a:hover {
              color: #26C281;
              text-decoration: none; }
      .mt-element-list .list-simple.mt-list-container ul > .mt-list-item > .list-datetime {
        text-align: right;
        float: right;
        width: 60px; }
.mt-element-list .list-simple.mt-list-head {
  padding: 15px; }
  .mt-element-list .list-simple.mt-list-head .list-title {
    margin: 0;
    padding-right: 85px; }
  .mt-element-list .list-simple.mt-list-head .list-date {
    font-size: 12px;
    opacity: 0.8;
    float: right;
    width: 75px; }
.mt-element-list .list-simple.ext-1.mt-list-container {
  padding: 0; }
  .mt-element-list .list-simple.ext-1.mt-list-container ul > .mt-list-item {
    padding: 15px;
    border-left: 3px solid;
    border-color: #34495e;
    border-bottom-color: #e7ecf1; }
    .mt-element-list .list-simple.ext-1.mt-list-container ul > .mt-list-item:hover {
      background-color: #e5e5e5; }
    .mt-element-list .list-simple.ext-1.mt-list-container ul > .mt-list-item.done {
      border-color: #26C281;
      border-bottom-color: #e7ecf1; }
      .mt-element-list .list-simple.ext-1.mt-list-container ul > .mt-list-item.done:hover {
        background-color: #96ebc8; }
.mt-element-list .list-simple.group .list-toggle-container:hover, .mt-element-list .list-simple.group .list-toggle-container:focus, .mt-element-list .list-simple.group .list-toggle-container:active {
  text-decoration: none; }
.mt-element-list .list-simple.group .list-toggle-container .list-toggle {
  padding: 15px;
  background-color: #34495e;
  font-weight: 700;
  color: #fff;
  text-decoration: none; }
  .mt-element-list .list-simple.group .list-toggle-container .list-toggle.done {
    background-color: #26C281; }
.mt-element-list .list-news.mt-list-head {
  padding: 15px;
  text-align: center; }
  .mt-element-list .list-news.mt-list-head .list-title {
    margin: 0; }
  .mt-element-list .list-news.mt-list-head .badge {
    margin-top: 5px; }
.mt-element-list .list-news.mt-list-container {
  border-left: 1px solid;
  border-right: 1px solid;
  border-bottom: 1px solid;
  border-color: #e7ecf1;
  padding: 15px 0; }
  .mt-element-list .list-news.mt-list-container ul {
    margin-bottom: 0;
    padding: 0; }
    .mt-element-list .list-news.mt-list-container ul > .mt-list-item {
      list-style: none;
      border-bottom: 1px solid;
      border-color: #e7ecf1;
      padding: 15px;
      position: relative; }
      .mt-element-list .list-news.mt-list-container ul > .mt-list-item:first-child {
        padding-top: 0; }
      .mt-element-list .list-news.mt-list-container ul > .mt-list-item:last-child {
        padding-bottom: 0;
        border: none; }
      .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-icon-container {
        font-size: 20px;
        position: absolute;
        right: 5px;
        top: 50%;
        margin-top: -10px; }
        .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-icon-container a {
          color: #2f353b; }
          .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-icon-container a:hover {
            color: #32c5d2; }
      .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-item-content {
        padding: 0 25px 0 0; }
        .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-item-content > h3 {
          margin: 0;
          font-size: 18px;
          margin-bottom: 10px; }
          .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a {
            color: #34495e; }
            .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a:hover {
              color: #32c5d2;
              text-decoration: none; }
      .mt-element-list .list-news.mt-list-container ul > .mt-list-item > .list-datetime {
        margin-bottom: 10px; }
.mt-element-list .list-news.ext-1.mt-list-head {
  position: relative;
  text-align: left; }
  .mt-element-list .list-news.ext-1.mt-list-head .list-count {
    position: absolute;
    right: 0;
    top: 0;
    height: 100%;
    padding: 19px; }
.mt-element-list .list-news.ext-1 .list-thumb {
  width: 80px;
  height: 80px;
  overflow: hidden;
  float: left; }
  .mt-element-list .list-news.ext-1 .list-thumb img {
    width: 100%; }
.mt-element-list .list-news.ext-1.mt-list-container {
  padding: 0; }
  .mt-element-list .list-news.ext-1.mt-list-container ul > .mt-list-item {
    padding: 15px; }
    .mt-element-list .list-news.ext-1.mt-list-container ul > .mt-list-item > .list-datetime {
      padding-left: 90px; }
    .mt-element-list .list-news.ext-1.mt-list-container ul > .mt-list-item > .list-item-content {
      padding-left: 90px; }
    .mt-element-list .list-news.ext-1.mt-list-container ul > .mt-list-item:hover {
      background-color: #e5e5e5; }
    .mt-element-list .list-news.ext-1.mt-list-container ul > .mt-list-item:last-child {
      padding-bottom: 15px; }
.mt-element-list .list-news.ext-2.mt-list-head {
  position: relative;
  text-align: left; }
  .mt-element-list .list-news.ext-2.mt-list-head .list-count {
    position: absolute;
    right: 0;
    top: 0;
    height: 100%;
    padding: 19px; }
.mt-element-list .list-news.ext-2 .list-thumb {
  width: 80px;
  height: 80px;
  overflow: hidden;
  float: left; }
  .mt-element-list .list-news.ext-2 .list-thumb img {
    width: 100%; }
.mt-element-list .list-news.ext-2.mt-list-container {
  padding: 0; }
  .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item {
    padding: 15px; }
    .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item > .list-datetime {
      padding-left: 90px; }
    .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item > .list-item-content {
      padding-left: 90px; }
      .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item > .list-item-content > h3 {
        font-size: 16px; }
        .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a:hover {
          color: #F2784B; }
    .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item:hover {
      background-color: #e5e5e5; }
    .mt-element-list .list-news.ext-2.mt-list-container ul > .mt-list-item:last-child {
      padding-bottom: 15px; }
.mt-element-list .list-todo.mt-list-head {
  padding: 15px;
  position: relative; }
  .mt-element-list .list-todo.mt-list-head .list-title {
    margin: 0; }
  .mt-element-list .list-todo.mt-list-head .list-head-count {
    margin-top: 5px; }
    .mt-element-list .list-todo.mt-list-head .list-head-count > .list-head-count-item {
      display: inline-block;
      margin-right: 15px; }
  .mt-element-list .list-todo.mt-list-head .list-count {
    position: absolute;
    top: 0;
    right: 0;
    padding: 29px;
    font-size: 16px; }
  .mt-element-list .list-todo.mt-list-head a {
    color: #fff; }
    .mt-element-list .list-todo.mt-list-head a:hover {
      text-decoration: none; }
.mt-element-list .list-todo.mt-list-container {
  border-left: 1px solid;
  border-right: 1px solid;
  border-bottom: 1px solid;
  border-color: #e7ecf1;
  position: relative; }
  .mt-element-list .list-todo.mt-list-container .list-todo-line {
    position: absolute;
    z-index: 1;
    height: 100%;
    width: 1px;
    top: 0;
    left: 25px;
    border-left: 1px solid;
    border-color: #e7ecf1; }
  .mt-element-list .list-todo.mt-list-container ul {
    margin-bottom: 0;
    padding: 0;
    position: relative;
    z-index: 5; }
    .mt-element-list .list-todo.mt-list-container ul > .mt-list-item {
      list-style: none;
      border-bottom: 1px solid;
      border-bottom-style: dashed;
      border-color: #e7ecf1;
      padding: 15px;
      position: relative; }
      .mt-element-list .list-todo.mt-list-container ul > .mt-list-item:last-child {
        border: none; }
      .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-icon {
        display: inline-block;
        margin-top: 0.7em;
        padding: 0.7em 0;
        vertical-align: top; }
      .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item {
        margin-left: 15px;
        display: inline-block;
        vertical-align: top;
        width: 90%;
        position: relative; }
        .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item:after {
          right: 100%;
          top: 50%;
          border: solid transparent;
          content: " ";
          height: 0;
          width: 0;
          position: absolute;
          pointer-events: none;
          border-color: rgba(47, 53, 59, 0);
          border-right-color: #2f353b;
          border-width: 8px;
          top: 18px; }
        .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item > .list-toggle-container:hover, .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item > .list-toggle-container:focus, .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item > .list-toggle-container:active {
          text-decoration: none; }
        .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item > .list-toggle-container .list-toggle {
          padding: 15px; }
          .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item > .list-toggle-container .list-toggle > .list-toggle-title {
            display: inline-block; }
        .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list {
          border: 1px solid;
          border-color: #e7ecf1;
          padding: 0;
          margin: 0;
          position: relative;
          border-top: none;
          border-bottom: none; }
          .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item {
            list-style: none;
            padding: 15px;
            border-bottom: 1px solid;
            border-color: #e7ecf1; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item a {
              color: #2f353b; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item a:hover {
                text-decoration: none;
                color: #e43a45; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item:last-child {
              border-bottom: none; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-icon {
              float: left; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-content {
              padding: 0 45px 0 35px; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-content > h4 {
                margin-top: 0;
                font-size: 14px; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-content > p {
                font-size: 13px;
                margin: 0; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-status {
              float: right; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-status a {
                color: #e5e5e5; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-status .done:hover {
                color: #26C281; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item > .task-status .pending:hover {
                color: #e43a45; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-list-item.done > .task-status .done {
              color: #26C281; }
          .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-footer {
            padding: 15px;
            text-align: center; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-footer a {
              color: #2f353b; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-footer a:hover {
                text-decoration: none; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-footer a.task-trash:hover {
                color: #e43a45; }
              .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-todo-item .task-list .task-footer a.task-add:hover {
                color: #26C281; }
      .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-icon-container {
        font-size: 20px;
        position: absolute;
        right: 5px;
        top: 50%;
        margin-top: -10px; }
        .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-icon-container a {
          color: #2f353b; }
          .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-icon-container a:hover {
            color: #32c5d2; }
      .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-item-content {
        padding: 0 25px 0 0; }
        .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-item-content > h3 {
          margin: 0;
          font-size: 18px;
          margin-bottom: 10px; }
          .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a {
            color: #34495e; }
            .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-item-content > h3 > a:hover {
              color: #32c5d2;
              text-decoration: none; }
      .mt-element-list .list-todo.mt-list-container ul > .mt-list-item > .list-datetime {
        margin-bottom: 10px; }

.mt-element-list .list-default.mt-list-head.white {
  background-color: #ffffff;
  color: #666; }
  .mt-element-list .list-default.mt-list-head.white .badge {
    background-color: white;
    color: #666; }
  .mt-element-list .list-default.mt-list-head.white.ext-1 .badge {
    background-color: #e6e6e6; }
  .mt-element-list .list-default.mt-list-head.white .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.white .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.white {
  background-color: #ffffff;
  color: #666; }
.mt-element-list .list-todo .list-count.white {
  background-color: #ffffff;
  color: #666; }
  .mt-element-list .list-todo .list-count.white:hover {
    background-color: #f2f2f2; }
.mt-element-list .list-todo .list-todo-line.white {
  border-color: #ffffff; }
.mt-element-list .list-todo .list-todo-item.white:after {
  border-right-color: #ffffff !important; }
.mt-element-list .list-todo .list-todo-item.white .list-toggle {
  background: #ffffff;
  color: #666 !important; }
  .mt-element-list .list-todo .list-todo-item.white .list-toggle > .badge {
    color: #ffffff;
    background: #666; }

.mt-element-list .list-default.mt-list-head.default {
  background-color: #e1e5ec;
  color: #666; }
  .mt-element-list .list-default.mt-list-head.default .badge {
    background-color: white;
    color: #666; }
  .mt-element-list .list-default.mt-list-head.default.ext-1 .badge {
    background-color: #c2cad8; }
  .mt-element-list .list-default.mt-list-head.default .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.default .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.default {
  background-color: #e1e5ec;
  color: #666; }
.mt-element-list .list-todo .list-count.default {
  background-color: #e1e5ec;
  color: #666; }
  .mt-element-list .list-todo .list-count.default:hover {
    background-color: #d1d7e2; }
.mt-element-list .list-todo .list-todo-line.default {
  border-color: #e1e5ec; }
.mt-element-list .list-todo .list-todo-item.default:after {
  border-right-color: #e1e5ec !important; }
.mt-element-list .list-todo .list-todo-item.default .list-toggle {
  background: #e1e5ec;
  color: #666 !important; }
  .mt-element-list .list-todo .list-todo-item.default .list-toggle > .badge {
    color: #e1e5ec;
    background: #666; }

.mt-element-list .list-default.mt-list-head.dark {
  background-color: #2f353b;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.dark .badge {
    background-color: #464f57;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.dark.ext-1 .badge {
    background-color: #181c1f; }
  .mt-element-list .list-default.mt-list-head.dark .list-label {
    color: #acb5bd; }
  .mt-element-list .list-default.mt-list-head.dark .list-date {
    color: #acb5bd; }
.mt-element-list .list-todo.mt-list-head.dark {
  background-color: #2f353b;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.dark {
  background-color: #2f353b;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.dark:hover {
    background-color: #24282d; }
.mt-element-list .list-todo .list-todo-line.dark {
  border-color: #2f353b; }
.mt-element-list .list-todo .list-todo-item.dark:after {
  border-right-color: #2f353b !important; }
.mt-element-list .list-todo .list-todo-item.dark .list-toggle {
  background: #2f353b;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.dark .list-toggle > .badge {
    color: #2f353b;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue {
  background-color: #3598dc;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue .badge {
    background-color: #60aee4;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue.ext-1 .badge {
    background-color: #217ebd; }
  .mt-element-list .list-default.mt-list-head.blue .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue {
  background-color: #3598dc;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue {
  background-color: #3598dc;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue:hover {
    background-color: #258cd3; }
.mt-element-list .list-todo .list-todo-line.blue {
  border-color: #3598dc; }
.mt-element-list .list-todo .list-todo-item.blue:after {
  border-right-color: #3598dc !important; }
.mt-element-list .list-todo .list-todo-item.blue .list-toggle {
  background: #3598dc;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue .list-toggle > .badge {
    color: #3598dc;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-madison {
  background-color: #578ebe;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-madison .badge {
    background-color: #7ca7cc;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-madison.ext-1 .badge {
    background-color: #3f74a3; }
  .mt-element-list .list-default.mt-list-head.blue-madison .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue-madison .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue-madison {
  background-color: #578ebe;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-madison {
  background-color: #578ebe;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-madison:hover {
    background-color: #4682b5; }
.mt-element-list .list-todo .list-todo-line.blue-madison {
  border-color: #578ebe; }
.mt-element-list .list-todo .list-todo-item.blue-madison:after {
  border-right-color: #578ebe !important; }
.mt-element-list .list-todo .list-todo-item.blue-madison .list-toggle {
  background: #578ebe;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-madison .list-toggle > .badge {
    color: #578ebe;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-chambray {
  background-color: #2C3E50;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-chambray .badge {
    background-color: #3e5871;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-chambray.ext-1 .badge {
    background-color: #1a252f; }
  .mt-element-list .list-default.mt-list-head.blue-chambray .list-label {
    color: #aabed1; }
  .mt-element-list .list-default.mt-list-head.blue-chambray .list-date {
    color: #aabed1; }
.mt-element-list .list-todo.mt-list-head.blue-chambray {
  background-color: #2C3E50;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-chambray {
  background-color: #2C3E50;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-chambray:hover {
    background-color: #233140; }
.mt-element-list .list-todo .list-todo-line.blue-chambray {
  border-color: #2C3E50; }
.mt-element-list .list-todo .list-todo-item.blue-chambray:after {
  border-right-color: #2C3E50 !important; }
.mt-element-list .list-todo .list-todo-item.blue-chambray .list-toggle {
  background: #2C3E50;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-chambray .list-toggle > .badge {
    color: #2C3E50;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-ebonyclay {
  background-color: #22313F;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-ebonyclay .badge {
    background-color: #344b60;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-ebonyclay.ext-1 .badge {
    background-color: #10171e; }
  .mt-element-list .list-default.mt-list-head.blue-ebonyclay .list-label {
    color: #98b1c8; }
  .mt-element-list .list-default.mt-list-head.blue-ebonyclay .list-date {
    color: #98b1c8; }
.mt-element-list .list-todo.mt-list-head.blue-ebonyclay {
  background-color: #22313F;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-ebonyclay {
  background-color: #22313F;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-ebonyclay:hover {
    background-color: #19242e; }
.mt-element-list .list-todo .list-todo-line.blue-ebonyclay {
  border-color: #22313F; }
.mt-element-list .list-todo .list-todo-item.blue-ebonyclay:after {
  border-right-color: #22313F !important; }
.mt-element-list .list-todo .list-todo-item.blue-ebonyclay .list-toggle {
  background: #22313F;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-ebonyclay .list-toggle > .badge {
    color: #22313F;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-hoki {
  background-color: #67809F;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-hoki .badge {
    background-color: #869ab3;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-hoki.ext-1 .badge {
    background-color: #526781; }
  .mt-element-list .list-default.mt-list-head.blue-hoki .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue-hoki .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue-hoki {
  background-color: #67809F;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-hoki {
  background-color: #67809F;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-hoki:hover {
    background-color: #5c7391; }
.mt-element-list .list-todo .list-todo-line.blue-hoki {
  border-color: #67809F; }
.mt-element-list .list-todo .list-todo-item.blue-hoki:after {
  border-right-color: #67809F !important; }
.mt-element-list .list-todo .list-todo-item.blue-hoki .list-toggle {
  background: #67809F;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-hoki .list-toggle > .badge {
    color: #67809F;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-steel {
  background-color: #4B77BE;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-steel .badge {
    background-color: #7093cc;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-steel.ext-1 .badge {
    background-color: #395f9d; }
  .mt-element-list .list-default.mt-list-head.blue-steel .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue-steel .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue-steel {
  background-color: #4B77BE;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-steel {
  background-color: #4B77BE;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-steel:hover {
    background-color: #406bb0; }
.mt-element-list .list-todo .list-todo-line.blue-steel {
  border-color: #4B77BE; }
.mt-element-list .list-todo .list-todo-item.blue-steel:after {
  border-right-color: #4B77BE !important; }
.mt-element-list .list-todo .list-todo-item.blue-steel .list-toggle {
  background: #4B77BE;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-steel .list-toggle > .badge {
    color: #4B77BE;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-soft {
  background-color: #4c87b9;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-soft .badge {
    background-color: #71a0c7;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-soft.ext-1 .badge {
    background-color: #3b6d97; }
  .mt-element-list .list-default.mt-list-head.blue-soft .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue-soft .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue-soft {
  background-color: #4c87b9;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-soft {
  background-color: #4c87b9;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-soft:hover {
    background-color: #427aa9; }
.mt-element-list .list-todo .list-todo-line.blue-soft {
  border-color: #4c87b9; }
.mt-element-list .list-todo .list-todo-item.blue-soft:after {
  border-right-color: #4c87b9 !important; }
.mt-element-list .list-todo .list-todo-item.blue-soft .list-toggle {
  background: #4c87b9;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-soft .list-toggle > .badge {
    color: #4c87b9;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-dark {
  background-color: #5e738b;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-dark .badge {
    background-color: #788da4;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-dark.ext-1 .badge {
    background-color: #495a6d; }
  .mt-element-list .list-default.mt-list-head.blue-dark .list-label {
    color: #f2f4f6; }
  .mt-element-list .list-default.mt-list-head.blue-dark .list-date {
    color: #f2f4f6; }
.mt-element-list .list-todo.mt-list-head.blue-dark {
  background-color: #5e738b;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-dark {
  background-color: #5e738b;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-dark:hover {
    background-color: #54667c; }
.mt-element-list .list-todo .list-todo-line.blue-dark {
  border-color: #5e738b; }
.mt-element-list .list-todo .list-todo-item.blue-dark:after {
  border-right-color: #5e738b !important; }
.mt-element-list .list-todo .list-todo-item.blue-dark .list-toggle {
  background: #5e738b;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-dark .list-toggle > .badge {
    color: #5e738b;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-sharp {
  background-color: #5C9BD1;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-sharp .badge {
    background-color: #84b3dc;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-sharp.ext-1 .badge {
    background-color: #3782c3; }
  .mt-element-list .list-default.mt-list-head.blue-sharp .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue-sharp .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue-sharp {
  background-color: #5C9BD1;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-sharp {
  background-color: #5C9BD1;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-sharp:hover {
    background-color: #488fcb; }
.mt-element-list .list-todo .list-todo-line.blue-sharp {
  border-color: #5C9BD1; }
.mt-element-list .list-todo .list-todo-item.blue-sharp:after {
  border-right-color: #5C9BD1 !important; }
.mt-element-list .list-todo .list-todo-item.blue-sharp .list-toggle {
  background: #5C9BD1;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-sharp .list-toggle > .badge {
    color: #5C9BD1;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.blue-oleo {
  background-color: #94A0B2;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-oleo .badge {
    background-color: #b2bac7;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.blue-oleo.ext-1 .badge {
    background-color: #76869d; }
  .mt-element-list .list-default.mt-list-head.blue-oleo .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.blue-oleo .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.blue-oleo {
  background-color: #94A0B2;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.blue-oleo {
  background-color: #94A0B2;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.blue-oleo:hover {
    background-color: #8593a7; }
.mt-element-list .list-todo .list-todo-line.blue-oleo {
  border-color: #94A0B2; }
.mt-element-list .list-todo .list-todo-item.blue-oleo:after {
  border-right-color: #94A0B2 !important; }
.mt-element-list .list-todo .list-todo-item.blue-oleo .list-toggle {
  background: #94A0B2;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.blue-oleo .list-toggle > .badge {
    color: #94A0B2;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green {
  background-color: #32c5d2;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green .badge {
    background-color: #5cd1db;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green.ext-1 .badge {
    background-color: #26a1ab; }
  .mt-element-list .list-default.mt-list-head.green .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.green .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.green {
  background-color: #32c5d2;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green {
  background-color: #32c5d2;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green:hover {
    background-color: #2ab4c0; }
.mt-element-list .list-todo .list-todo-line.green {
  border-color: #32c5d2; }
.mt-element-list .list-todo .list-todo-item.green:after {
  border-right-color: #32c5d2 !important; }
.mt-element-list .list-todo .list-todo-item.green .list-toggle {
  background: #32c5d2;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green .list-toggle > .badge {
    color: #32c5d2;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-meadow {
  background-color: #1BBC9B;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-meadow .badge {
    background-color: #2ae0bb;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-meadow.ext-1 .badge {
    background-color: #158f76; }
  .mt-element-list .list-default.mt-list-head.green-meadow .list-label {
    color: #dcfaf4; }
  .mt-element-list .list-default.mt-list-head.green-meadow .list-date {
    color: #dcfaf4; }
.mt-element-list .list-todo.mt-list-head.green-meadow {
  background-color: #1BBC9B;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-meadow {
  background-color: #1BBC9B;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-meadow:hover {
    background-color: #18a689; }
.mt-element-list .list-todo .list-todo-line.green-meadow {
  border-color: #1BBC9B; }
.mt-element-list .list-todo .list-todo-item.green-meadow:after {
  border-right-color: #1BBC9B !important; }
.mt-element-list .list-todo .list-todo-item.green-meadow .list-toggle {
  background: #1BBC9B;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-meadow .list-toggle > .badge {
    color: #1BBC9B;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-seagreen {
  background-color: #1BA39C;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-seagreen .badge {
    background-color: #22cfc6;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-seagreen.ext-1 .badge {
    background-color: #147772; }
  .mt-element-list .list-default.mt-list-head.green-seagreen .list-label {
    color: #c7f6f3; }
  .mt-element-list .list-default.mt-list-head.green-seagreen .list-date {
    color: #c7f6f3; }
.mt-element-list .list-todo.mt-list-head.green-seagreen {
  background-color: #1BA39C;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-seagreen {
  background-color: #1BA39C;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-seagreen:hover {
    background-color: #178d87; }
.mt-element-list .list-todo .list-todo-line.green-seagreen {
  border-color: #1BA39C; }
.mt-element-list .list-todo .list-todo-item.green-seagreen:after {
  border-right-color: #1BA39C !important; }
.mt-element-list .list-todo .list-todo-item.green-seagreen .list-toggle {
  background: #1BA39C;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-seagreen .list-toggle > .badge {
    color: #1BA39C;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-turquoise {
  background-color: #36D7B7;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-turquoise .badge {
    background-color: #61dfc6;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-turquoise.ext-1 .badge {
    background-color: #24b699; }
  .mt-element-list .list-default.mt-list-head.green-turquoise .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.green-turquoise .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.green-turquoise {
  background-color: #36D7B7;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-turquoise {
  background-color: #36D7B7;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-turquoise:hover {
    background-color: #28cbab; }
.mt-element-list .list-todo .list-todo-line.green-turquoise {
  border-color: #36D7B7; }
.mt-element-list .list-todo .list-todo-item.green-turquoise:after {
  border-right-color: #36D7B7 !important; }
.mt-element-list .list-todo .list-todo-item.green-turquoise .list-toggle {
  background: #36D7B7;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-turquoise .list-toggle > .badge {
    color: #36D7B7;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-haze {
  background-color: #44b6ae;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-haze .badge {
    background-color: #67c6bf;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-haze.ext-1 .badge {
    background-color: #36918b; }
  .mt-element-list .list-default.mt-list-head.green-haze .list-label {
    color: #fbfefd; }
  .mt-element-list .list-default.mt-list-head.green-haze .list-date {
    color: #fbfefd; }
.mt-element-list .list-todo.mt-list-head.green-haze {
  background-color: #44b6ae;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-haze {
  background-color: #44b6ae;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-haze:hover {
    background-color: #3da39c; }
.mt-element-list .list-todo .list-todo-line.green-haze {
  border-color: #44b6ae; }
.mt-element-list .list-todo .list-todo-item.green-haze:after {
  border-right-color: #44b6ae !important; }
.mt-element-list .list-todo .list-todo-item.green-haze .list-toggle {
  background: #44b6ae;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-haze .list-toggle > .badge {
    color: #44b6ae;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-jungle {
  background-color: #26C281;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-jungle .badge {
    background-color: #41da9a;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-jungle.ext-1 .badge {
    background-color: #1e9765; }
  .mt-element-list .list-default.mt-list-head.green-jungle .list-label {
    color: #ecfbf5; }
  .mt-element-list .list-default.mt-list-head.green-jungle .list-date {
    color: #ecfbf5; }
.mt-element-list .list-todo.mt-list-head.green-jungle {
  background-color: #26C281;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-jungle {
  background-color: #26C281;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-jungle:hover {
    background-color: #22ad73; }
.mt-element-list .list-todo .list-todo-line.green-jungle {
  border-color: #26C281; }
.mt-element-list .list-todo .list-todo-item.green-jungle:after {
  border-right-color: #26C281 !important; }
.mt-element-list .list-todo .list-todo-item.green-jungle .list-toggle {
  background: #26C281;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-jungle .list-toggle > .badge {
    color: #26C281;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-soft {
  background-color: #3faba4;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-soft .badge {
    background-color: #5bc2bc;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-soft.ext-1 .badge {
    background-color: #318680; }
  .mt-element-list .list-default.mt-list-head.green-soft .list-label {
    color: #f0f9f9; }
  .mt-element-list .list-default.mt-list-head.green-soft .list-date {
    color: #f0f9f9; }
.mt-element-list .list-todo.mt-list-head.green-soft {
  background-color: #3faba4;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-soft {
  background-color: #3faba4;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-soft:hover {
    background-color: #389892; }
.mt-element-list .list-todo .list-todo-line.green-soft {
  border-color: #3faba4; }
.mt-element-list .list-todo .list-todo-item.green-soft:after {
  border-right-color: #3faba4 !important; }
.mt-element-list .list-todo .list-todo-item.green-soft .list-toggle {
  background: #3faba4;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-soft .list-toggle > .badge {
    color: #3faba4;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-dark {
  background-color: #4DB3A2;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-dark .badge {
    background-color: #71c2b5;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-dark.ext-1 .badge {
    background-color: #3d9082; }
  .mt-element-list .list-default.mt-list-head.green-dark .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.green-dark .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.green-dark {
  background-color: #4DB3A2;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-dark {
  background-color: #4DB3A2;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-dark:hover {
    background-color: #45a292; }
.mt-element-list .list-todo .list-todo-line.green-dark {
  border-color: #4DB3A2; }
.mt-element-list .list-todo .list-todo-item.green-dark:after {
  border-right-color: #4DB3A2 !important; }
.mt-element-list .list-todo .list-todo-item.green-dark .list-toggle {
  background: #4DB3A2;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-dark .list-toggle > .badge {
    color: #4DB3A2;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-sharp {
  background-color: #2ab4c0;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-sharp .badge {
    background-color: #46cbd7;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-sharp.ext-1 .badge {
    background-color: #218d96; }
  .mt-element-list .list-default.mt-list-head.green-sharp .list-label {
    color: #eefafb; }
  .mt-element-list .list-default.mt-list-head.green-sharp .list-date {
    color: #eefafb; }
.mt-element-list .list-todo.mt-list-head.green-sharp {
  background-color: #2ab4c0;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-sharp {
  background-color: #2ab4c0;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-sharp:hover {
    background-color: #25a0ab; }
.mt-element-list .list-todo .list-todo-line.green-sharp {
  border-color: #2ab4c0; }
.mt-element-list .list-todo .list-todo-item.green-sharp:after {
  border-right-color: #2ab4c0 !important; }
.mt-element-list .list-todo .list-todo-item.green-sharp .list-toggle {
  background: #2ab4c0;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-sharp .list-toggle > .badge {
    color: #2ab4c0;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.green-steel {
  background-color: #29b4b6;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-steel .badge {
    background-color: #3ed1d4;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.green-steel.ext-1 .badge {
    background-color: #208b8c; }
  .mt-element-list .list-default.mt-list-head.green-steel .list-label {
    color: #e5f9f9; }
  .mt-element-list .list-default.mt-list-head.green-steel .list-date {
    color: #e5f9f9; }
.mt-element-list .list-todo.mt-list-head.green-steel {
  background-color: #29b4b6;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.green-steel {
  background-color: #29b4b6;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.green-steel:hover {
    background-color: #249fa1; }
.mt-element-list .list-todo .list-todo-line.green-steel {
  border-color: #29b4b6; }
.mt-element-list .list-todo .list-todo-item.green-steel:after {
  border-right-color: #29b4b6 !important; }
.mt-element-list .list-todo .list-todo-item.green-steel .list-toggle {
  background: #29b4b6;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.green-steel .list-toggle > .badge {
    color: #29b4b6;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.grey {
  background-color: #E5E5E5;
  color: #333333; }
  .mt-element-list .list-default.mt-list-head.grey .badge {
    background-color: white;
    color: #333333; }
  .mt-element-list .list-default.mt-list-head.grey.ext-1 .badge {
    background-color: #cccccc; }
  .mt-element-list .list-default.mt-list-head.grey .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey {
  background-color: #E5E5E5;
  color: #333333; }
.mt-element-list .list-todo .list-count.grey {
  background-color: #E5E5E5;
  color: #333333; }
  .mt-element-list .list-todo .list-count.grey:hover {
    background-color: #d8d8d8; }
.mt-element-list .list-todo .list-todo-line.grey {
  border-color: #E5E5E5; }
.mt-element-list .list-todo .list-todo-item.grey:after {
  border-right-color: #E5E5E5 !important; }
.mt-element-list .list-todo .list-todo-item.grey .list-toggle {
  background: #E5E5E5;
  color: #333333 !important; }
  .mt-element-list .list-todo .list-todo-item.grey .list-toggle > .badge {
    color: #E5E5E5;
    background: #333333; }

.mt-element-list .list-default.mt-list-head.grey-steel {
  background-color: #e9edef;
  color: #80898e; }
  .mt-element-list .list-default.mt-list-head.grey-steel .badge {
    background-color: white;
    color: #80898e; }
  .mt-element-list .list-default.mt-list-head.grey-steel.ext-1 .badge {
    background-color: #cbd5da; }
  .mt-element-list .list-default.mt-list-head.grey-steel .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey-steel .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey-steel {
  background-color: #e9edef;
  color: #80898e; }
.mt-element-list .list-todo .list-count.grey-steel {
  background-color: #e9edef;
  color: #80898e; }
  .mt-element-list .list-todo .list-count.grey-steel:hover {
    background-color: #dae1e4; }
.mt-element-list .list-todo .list-todo-line.grey-steel {
  border-color: #e9edef; }
.mt-element-list .list-todo .list-todo-item.grey-steel:after {
  border-right-color: #e9edef !important; }
.mt-element-list .list-todo .list-todo-item.grey-steel .list-toggle {
  background: #e9edef;
  color: #80898e !important; }
  .mt-element-list .list-todo .list-todo-item.grey-steel .list-toggle > .badge {
    color: #e9edef;
    background: #80898e; }

.mt-element-list .list-default.mt-list-head.grey-cararra {
  background-color: #fafafa;
  color: #333333; }
  .mt-element-list .list-default.mt-list-head.grey-cararra .badge {
    background-color: white;
    color: #333333; }
  .mt-element-list .list-default.mt-list-head.grey-cararra.ext-1 .badge {
    background-color: #e1e1e1; }
  .mt-element-list .list-default.mt-list-head.grey-cararra .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey-cararra .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey-cararra {
  background-color: #fafafa;
  color: #333333; }
.mt-element-list .list-todo .list-count.grey-cararra {
  background-color: #fafafa;
  color: #333333; }
  .mt-element-list .list-todo .list-count.grey-cararra:hover {
    background-color: #ededed; }
.mt-element-list .list-todo .list-todo-line.grey-cararra {
  border-color: #fafafa; }
.mt-element-list .list-todo .list-todo-item.grey-cararra:after {
  border-right-color: #fafafa !important; }
.mt-element-list .list-todo .list-todo-item.grey-cararra .list-toggle {
  background: #fafafa;
  color: #333333 !important; }
  .mt-element-list .list-todo .list-todo-item.grey-cararra .list-toggle > .badge {
    color: #fafafa;
    background: #333333; }

.mt-element-list .list-default.mt-list-head.grey-gallery {
  background-color: #555555;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.grey-gallery .badge {
    background-color: #6f6f6f;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.grey-gallery.ext-1 .badge {
    background-color: #3c3c3c; }
  .mt-element-list .list-default.mt-list-head.grey-gallery .list-label {
    color: #d5d5d5; }
  .mt-element-list .list-default.mt-list-head.grey-gallery .list-date {
    color: #d5d5d5; }
.mt-element-list .list-todo.mt-list-head.grey-gallery {
  background-color: #555555;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.grey-gallery {
  background-color: #555555;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.grey-gallery:hover {
    background-color: #484848; }
.mt-element-list .list-todo .list-todo-line.grey-gallery {
  border-color: #555555; }
.mt-element-list .list-todo .list-todo-item.grey-gallery:after {
  border-right-color: #555555 !important; }
.mt-element-list .list-todo .list-todo-item.grey-gallery .list-toggle {
  background: #555555;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.grey-gallery .list-toggle > .badge {
    color: #555555;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.grey-cascade {
  background-color: #95A5A6;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.grey-cascade .badge {
    background-color: #b1bdbd;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.grey-cascade.ext-1 .badge {
    background-color: #798d8f; }
  .mt-element-list .list-default.mt-list-head.grey-cascade .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey-cascade .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey-cascade {
  background-color: #95A5A6;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.grey-cascade {
  background-color: #95A5A6;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.grey-cascade:hover {
    background-color: #87999a; }
.mt-element-list .list-todo .list-todo-line.grey-cascade {
  border-color: #95A5A6; }
.mt-element-list .list-todo .list-todo-item.grey-cascade:after {
  border-right-color: #95A5A6 !important; }
.mt-element-list .list-todo .list-todo-item.grey-cascade .list-toggle {
  background: #95A5A6;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.grey-cascade .list-toggle > .badge {
    color: #95A5A6;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.grey-silver {
  background-color: #BFBFBF;
  color: #FAFCFB; }
  .mt-element-list .list-default.mt-list-head.grey-silver .badge {
    background-color: #d9d9d9;
    color: #FAFCFB; }
  .mt-element-list .list-default.mt-list-head.grey-silver.ext-1 .badge {
    background-color: #a6a6a6; }
  .mt-element-list .list-default.mt-list-head.grey-silver .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey-silver .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey-silver {
  background-color: #BFBFBF;
  color: #FAFCFB; }
.mt-element-list .list-todo .list-count.grey-silver {
  background-color: #BFBFBF;
  color: #FAFCFB; }
  .mt-element-list .list-todo .list-count.grey-silver:hover {
    background-color: #b2b2b2; }
.mt-element-list .list-todo .list-todo-line.grey-silver {
  border-color: #BFBFBF; }
.mt-element-list .list-todo .list-todo-item.grey-silver:after {
  border-right-color: #BFBFBF !important; }
.mt-element-list .list-todo .list-todo-item.grey-silver .list-toggle {
  background: #BFBFBF;
  color: #FAFCFB !important; }
  .mt-element-list .list-todo .list-todo-item.grey-silver .list-toggle > .badge {
    color: #BFBFBF;
    background: #FAFCFB; }

.mt-element-list .list-default.mt-list-head.grey-salsa {
  background-color: #ACB5C3;
  color: #FAFCFB; }
  .mt-element-list .list-default.mt-list-head.grey-salsa .badge {
    background-color: #cacfd8;
    color: #FAFCFB; }
  .mt-element-list .list-default.mt-list-head.grey-salsa.ext-1 .badge {
    background-color: #8e9bae; }
  .mt-element-list .list-default.mt-list-head.grey-salsa .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey-salsa .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey-salsa {
  background-color: #ACB5C3;
  color: #FAFCFB; }
.mt-element-list .list-todo .list-count.grey-salsa {
  background-color: #ACB5C3;
  color: #FAFCFB; }
  .mt-element-list .list-todo .list-count.grey-salsa:hover {
    background-color: #9da8b8; }
.mt-element-list .list-todo .list-todo-line.grey-salsa {
  border-color: #ACB5C3; }
.mt-element-list .list-todo .list-todo-item.grey-salsa:after {
  border-right-color: #ACB5C3 !important; }
.mt-element-list .list-todo .list-todo-item.grey-salsa .list-toggle {
  background: #ACB5C3;
  color: #FAFCFB !important; }
  .mt-element-list .list-todo .list-todo-item.grey-salsa .list-toggle > .badge {
    color: #ACB5C3;
    background: #FAFCFB; }

.mt-element-list .list-default.mt-list-head.grey-salt {
  background-color: #bfcad1;
  color: #FAFCFB; }
  .mt-element-list .list-default.mt-list-head.grey-salt .badge {
    background-color: #dde3e6;
    color: #FAFCFB; }
  .mt-element-list .list-default.mt-list-head.grey-salt.ext-1 .badge {
    background-color: #a1b1bc; }
  .mt-element-list .list-default.mt-list-head.grey-salt .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.grey-salt .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.grey-salt {
  background-color: #bfcad1;
  color: #FAFCFB; }
.mt-element-list .list-todo .list-count.grey-salt {
  background-color: #bfcad1;
  color: #FAFCFB; }
  .mt-element-list .list-todo .list-count.grey-salt:hover {
    background-color: #b0bec6; }
.mt-element-list .list-todo .list-todo-line.grey-salt {
  border-color: #bfcad1; }
.mt-element-list .list-todo .list-todo-item.grey-salt:after {
  border-right-color: #bfcad1 !important; }
.mt-element-list .list-todo .list-todo-item.grey-salt .list-toggle {
  background: #bfcad1;
  color: #FAFCFB !important; }
  .mt-element-list .list-todo .list-todo-item.grey-salt .list-toggle > .badge {
    color: #bfcad1;
    background: #FAFCFB; }

.mt-element-list .list-default.mt-list-head.grey-mint {
  background-color: #525e64;
  color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.grey-mint .badge {
    background-color: #697880;
    color: #FFFFFF; }
  .mt-element-list .list-default.mt-list-head.grey-mint.ext-1 .badge {
    background-color: #3b4448; }
  .mt-element-list .list-default.mt-list-head.grey-mint .list-label {
    color: #d7dcde; }
  .mt-element-list .list-default.mt-list-head.grey-mint .list-date {
    color: #d7dcde; }
.mt-element-list .list-todo.mt-list-head.grey-mint {
  background-color: #525e64;
  color: #FFFFFF; }
.mt-element-list .list-todo .list-count.grey-mint {
  background-color: #525e64;
  color: #FFFFFF; }
  .mt-element-list .list-todo .list-count.grey-mint:hover {
    background-color: #475156; }
.mt-element-list .list-todo .list-todo-line.grey-mint {
  border-color: #525e64; }
.mt-element-list .list-todo .list-todo-item.grey-mint:after {
  border-right-color: #525e64 !important; }
.mt-element-list .list-todo .list-todo-item.grey-mint .list-toggle {
  background: #525e64;
  color: #FFFFFF !important; }
  .mt-element-list .list-todo .list-todo-item.grey-mint .list-toggle > .badge {
    color: #525e64;
    background: #FFFFFF; }

.mt-element-list .list-default.mt-list-head.red {
  background-color: #e7505a;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red .badge {
    background-color: #ed7d84;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red.ext-1 .badge {
    background-color: #e12330; }
  .mt-element-list .list-default.mt-list-head.red .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red {
  background-color: #e7505a;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red {
  background-color: #e7505a;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red:hover {
    background-color: #e43a45; }
.mt-element-list .list-todo .list-todo-line.red {
  border-color: #e7505a; }
.mt-element-list .list-todo .list-todo-item.red:after {
  border-right-color: #e7505a !important; }
.mt-element-list .list-todo .list-todo-item.red .list-toggle {
  background: #e7505a;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red .list-toggle > .badge {
    color: #e7505a;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-pink {
  background-color: #E08283;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-pink .badge {
    background-color: #eaabac;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-pink.ext-1 .badge {
    background-color: #d6595a; }
  .mt-element-list .list-default.mt-list-head.red-pink .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-pink .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-pink {
  background-color: #E08283;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-pink {
  background-color: #E08283;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-pink:hover {
    background-color: #db6e6f; }
.mt-element-list .list-todo .list-todo-line.red-pink {
  border-color: #E08283; }
.mt-element-list .list-todo .list-todo-item.red-pink:after {
  border-right-color: #E08283 !important; }
.mt-element-list .list-todo .list-todo-item.red-pink .list-toggle {
  background: #E08283;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-pink .list-toggle > .badge {
    color: #E08283;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-sunglo {
  background-color: #E26A6A;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-sunglo .badge {
    background-color: #ea9595;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-sunglo.ext-1 .badge {
    background-color: #da3f3f; }
  .mt-element-list .list-default.mt-list-head.red-sunglo .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-sunglo .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-sunglo {
  background-color: #E26A6A;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-sunglo {
  background-color: #E26A6A;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-sunglo:hover {
    background-color: #de5555; }
.mt-element-list .list-todo .list-todo-line.red-sunglo {
  border-color: #E26A6A; }
.mt-element-list .list-todo .list-todo-item.red-sunglo:after {
  border-right-color: #E26A6A !important; }
.mt-element-list .list-todo .list-todo-item.red-sunglo .list-toggle {
  background: #E26A6A;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-sunglo .list-toggle > .badge {
    color: #E26A6A;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-intense {
  background-color: #e35b5a;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-intense .badge {
    background-color: #ea8686;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-intense.ext-1 .badge {
    background-color: #dc302e; }
  .mt-element-list .list-default.mt-list-head.red-intense .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-intense .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-intense {
  background-color: #e35b5a;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-intense {
  background-color: #e35b5a;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-intense:hover {
    background-color: #df4544; }
.mt-element-list .list-todo .list-todo-line.red-intense {
  border-color: #e35b5a; }
.mt-element-list .list-todo .list-todo-item.red-intense:after {
  border-right-color: #e35b5a !important; }
.mt-element-list .list-todo .list-todo-item.red-intense .list-toggle {
  background: #e35b5a;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-intense .list-toggle > .badge {
    color: #e35b5a;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-thunderbird {
  background-color: #D91E18;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-thunderbird .badge {
    background-color: #e9403b;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-thunderbird.ext-1 .badge {
    background-color: #ab1813; }
  .mt-element-list .list-default.mt-list-head.red-thunderbird .list-label {
    color: #fef3f2; }
  .mt-element-list .list-default.mt-list-head.red-thunderbird .list-date {
    color: #fef3f2; }
.mt-element-list .list-todo.mt-list-head.red-thunderbird {
  background-color: #D91E18;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-thunderbird {
  background-color: #D91E18;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-thunderbird:hover {
    background-color: #c21b15; }
.mt-element-list .list-todo .list-todo-line.red-thunderbird {
  border-color: #D91E18; }
.mt-element-list .list-todo .list-todo-item.red-thunderbird:after {
  border-right-color: #D91E18 !important; }
.mt-element-list .list-todo .list-todo-item.red-thunderbird .list-toggle {
  background: #D91E18;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-thunderbird .list-toggle > .badge {
    color: #D91E18;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-flamingo {
  background-color: #EF4836;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-flamingo .badge {
    background-color: #f37365;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-flamingo.ext-1 .badge {
    background-color: #e02612; }
  .mt-element-list .list-default.mt-list-head.red-flamingo .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-flamingo .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-flamingo {
  background-color: #EF4836;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-flamingo {
  background-color: #EF4836;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-flamingo:hover {
    background-color: #ed321e; }
.mt-element-list .list-todo .list-todo-line.red-flamingo {
  border-color: #EF4836; }
.mt-element-list .list-todo .list-todo-item.red-flamingo:after {
  border-right-color: #EF4836 !important; }
.mt-element-list .list-todo .list-todo-item.red-flamingo .list-toggle {
  background: #EF4836;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-flamingo .list-toggle > .badge {
    color: #EF4836;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-soft {
  background-color: #d05454;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-soft .badge {
    background-color: #db7c7c;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-soft.ext-1 .badge {
    background-color: #bd3434; }
  .mt-element-list .list-default.mt-list-head.red-soft .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-soft .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-soft {
  background-color: #d05454;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-soft {
  background-color: #d05454;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-soft:hover {
    background-color: #cb4040; }
.mt-element-list .list-todo .list-todo-line.red-soft {
  border-color: #d05454; }
.mt-element-list .list-todo .list-todo-item.red-soft:after {
  border-right-color: #d05454 !important; }
.mt-element-list .list-todo .list-todo-item.red-soft .list-toggle {
  background: #d05454;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-soft .list-toggle > .badge {
    color: #d05454;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-haze {
  background-color: #f36a5a;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-haze .badge {
    background-color: #f6958a;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-haze.ext-1 .badge {
    background-color: #f03f2a; }
  .mt-element-list .list-default.mt-list-head.red-haze .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-haze .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-haze {
  background-color: #f36a5a;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-haze {
  background-color: #f36a5a;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-haze:hover {
    background-color: #f15542; }
.mt-element-list .list-todo .list-todo-line.red-haze {
  border-color: #f36a5a; }
.mt-element-list .list-todo .list-todo-item.red-haze:after {
  border-right-color: #f36a5a !important; }
.mt-element-list .list-todo .list-todo-item.red-haze .list-toggle {
  background: #f36a5a;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-haze .list-toggle > .badge {
    color: #f36a5a;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.red-mint {
  background-color: #e43a45;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-mint .badge {
    background-color: #ea676f;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.red-mint.ext-1 .badge {
    background-color: #cf1c28; }
  .mt-element-list .list-default.mt-list-head.red-mint .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.red-mint .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.red-mint {
  background-color: #e43a45;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.red-mint {
  background-color: #e43a45;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.red-mint:hover {
    background-color: #e12430; }
.mt-element-list .list-todo .list-todo-line.red-mint {
  border-color: #e43a45; }
.mt-element-list .list-todo .list-todo-item.red-mint:after {
  border-right-color: #e43a45 !important; }
.mt-element-list .list-todo .list-todo-item.red-mint .list-toggle {
  background: #e43a45;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.red-mint .list-toggle > .badge {
    color: #e43a45;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow {
  background-color: #c49f47;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow .badge {
    background-color: #d0b36e;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow.ext-1 .badge {
    background-color: #a48334; }
  .mt-element-list .list-default.mt-list-head.yellow .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow {
  background-color: #c49f47;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow {
  background-color: #c49f47;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow:hover {
    background-color: #b7923b; }
.mt-element-list .list-todo .list-todo-line.yellow {
  border-color: #c49f47; }
.mt-element-list .list-todo .list-todo-item.yellow:after {
  border-right-color: #c49f47 !important; }
.mt-element-list .list-todo .list-todo-item.yellow .list-toggle {
  background: #c49f47;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow .list-toggle > .badge {
    color: #c49f47;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-gold {
  background-color: #E87E04;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-gold .badge {
    background-color: #fb9724;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-gold.ext-1 .badge {
    background-color: #b66303; }
  .mt-element-list .list-default.mt-list-head.yellow-gold .list-label {
    color: #fff6ec; }
  .mt-element-list .list-default.mt-list-head.yellow-gold .list-date {
    color: #fff6ec; }
.mt-element-list .list-todo.mt-list-head.yellow-gold {
  background-color: #E87E04;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-gold {
  background-color: #E87E04;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-gold:hover {
    background-color: #cf7004; }
.mt-element-list .list-todo .list-todo-line.yellow-gold {
  border-color: #E87E04; }
.mt-element-list .list-todo .list-todo-item.yellow-gold:after {
  border-right-color: #E87E04 !important; }
.mt-element-list .list-todo .list-todo-item.yellow-gold .list-toggle {
  background: #E87E04;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-gold .list-toggle > .badge {
    color: #E87E04;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-casablanca {
  background-color: #f2784b;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-casablanca .badge {
    background-color: #f59c7b;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-casablanca.ext-1 .badge {
    background-color: #ef541b; }
  .mt-element-list .list-default.mt-list-head.yellow-casablanca .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow-casablanca .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow-casablanca {
  background-color: #f2784b;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-casablanca {
  background-color: #f2784b;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-casablanca:hover {
    background-color: #f06633; }
.mt-element-list .list-todo .list-todo-line.yellow-casablanca {
  border-color: #f2784b; }
.mt-element-list .list-todo .list-todo-item.yellow-casablanca:after {
  border-right-color: #f2784b !important; }
.mt-element-list .list-todo .list-todo-item.yellow-casablanca .list-toggle {
  background: #f2784b;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-casablanca .list-toggle > .badge {
    color: #f2784b;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-crusta {
  background-color: #f3c200;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-crusta .badge {
    background-color: #ffd327;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-crusta.ext-1 .badge {
    background-color: #c09900; }
  .mt-element-list .list-default.mt-list-head.yellow-crusta .list-label {
    color: #fffdf3; }
  .mt-element-list .list-default.mt-list-head.yellow-crusta .list-date {
    color: #fffdf3; }
.mt-element-list .list-todo.mt-list-head.yellow-crusta {
  background-color: #f3c200;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-crusta {
  background-color: #f3c200;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-crusta:hover {
    background-color: #daae00; }
.mt-element-list .list-todo .list-todo-line.yellow-crusta {
  border-color: #f3c200; }
.mt-element-list .list-todo .list-todo-item.yellow-crusta:after {
  border-right-color: #f3c200 !important; }
.mt-element-list .list-todo .list-todo-item.yellow-crusta .list-toggle {
  background: #f3c200;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-crusta .list-toggle > .badge {
    color: #f3c200;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-lemon {
  background-color: #F7CA18;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-lemon .badge {
    background-color: #f9d549;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-lemon.ext-1 .badge {
    background-color: #d5ab07; }
  .mt-element-list .list-default.mt-list-head.yellow-lemon .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow-lemon .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow-lemon {
  background-color: #F7CA18;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-lemon {
  background-color: #F7CA18;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-lemon:hover {
    background-color: #edbf08; }
.mt-element-list .list-todo .list-todo-line.yellow-lemon {
  border-color: #F7CA18; }
.mt-element-list .list-todo .list-todo-item.yellow-lemon:after {
  border-right-color: #F7CA18 !important; }
.mt-element-list .list-todo .list-todo-item.yellow-lemon .list-toggle {
  background: #F7CA18;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-lemon .list-toggle > .badge {
    color: #F7CA18;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-saffron {
  background-color: #F4D03F;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-saffron .badge {
    background-color: #f7dc6f;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-saffron.ext-1 .badge {
    background-color: #f1c40f; }
  .mt-element-list .list-default.mt-list-head.yellow-saffron .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow-saffron .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow-saffron {
  background-color: #F4D03F;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-saffron {
  background-color: #F4D03F;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-saffron:hover {
    background-color: #f3ca27; }
.mt-element-list .list-todo .list-todo-line.yellow-saffron {
  border-color: #F4D03F; }
.mt-element-list .list-todo .list-todo-item.yellow-saffron:after {
  border-right-color: #F4D03F !important; }
.mt-element-list .list-todo .list-todo-item.yellow-saffron .list-toggle {
  background: #F4D03F;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-saffron .list-toggle > .badge {
    color: #F4D03F;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-soft {
  background-color: #c8d046;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-soft .badge {
    background-color: #d4da6f;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-soft.ext-1 .badge {
    background-color: #adb52e; }
  .mt-element-list .list-default.mt-list-head.yellow-soft .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow-soft .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow-soft {
  background-color: #c8d046;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-soft {
  background-color: #c8d046;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-soft:hover {
    background-color: #c1c933; }
.mt-element-list .list-todo .list-todo-line.yellow-soft {
  border-color: #c8d046; }
.mt-element-list .list-todo .list-todo-item.yellow-soft:after {
  border-right-color: #c8d046 !important; }
.mt-element-list .list-todo .list-todo-item.yellow-soft .list-toggle {
  background: #c8d046;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-soft .list-toggle > .badge {
    color: #c8d046;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-haze {
  background-color: #c5bf66;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-haze .badge {
    background-color: #d3ce8b;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-haze.ext-1 .badge {
    background-color: #b4ad44; }
  .mt-element-list .list-default.mt-list-head.yellow-haze .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow-haze .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow-haze {
  background-color: #c5bf66;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-haze {
  background-color: #c5bf66;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-haze:hover {
    background-color: #beb754; }
.mt-element-list .list-todo .list-todo-line.yellow-haze {
  border-color: #c5bf66; }
.mt-element-list .list-todo .list-todo-item.yellow-haze:after {
  border-right-color: #c5bf66 !important; }
.mt-element-list .list-todo .list-todo-item.yellow-haze .list-toggle {
  background: #c5bf66;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-haze .list-toggle > .badge {
    color: #c5bf66;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.yellow-mint {
  background-color: #c5b96b;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-mint .badge {
    background-color: #d3ca90;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.yellow-mint.ext-1 .badge {
    background-color: #b6a747; }
  .mt-element-list .list-default.mt-list-head.yellow-mint .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.yellow-mint .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.yellow-mint {
  background-color: #c5b96b;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.yellow-mint {
  background-color: #c5b96b;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.yellow-mint:hover {
    background-color: #beb059; }
.mt-element-list .list-todo .list-todo-line.yellow-mint {
  border-color: #c5b96b; }
.mt-element-list .list-todo .list-todo-item.yellow-mint:after {
  border-right-color: #c5b96b !important; }
.mt-element-list .list-todo .list-todo-item.yellow-mint .list-toggle {
  background: #c5b96b;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.yellow-mint .list-toggle > .badge {
    color: #c5b96b;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple {
  background-color: #8E44AD;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple .badge {
    background-color: #a563c1;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple.ext-1 .badge {
    background-color: #703688; }
  .mt-element-list .list-default.mt-list-head.purple .list-label {
    color: #f9f5fb; }
  .mt-element-list .list-default.mt-list-head.purple .list-date {
    color: #f9f5fb; }
.mt-element-list .list-todo.mt-list-head.purple {
  background-color: #8E44AD;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple {
  background-color: #8E44AD;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple:hover {
    background-color: #7f3d9b; }
.mt-element-list .list-todo .list-todo-line.purple {
  border-color: #8E44AD; }
.mt-element-list .list-todo .list-todo-item.purple:after {
  border-right-color: #8E44AD !important; }
.mt-element-list .list-todo .list-todo-item.purple .list-toggle {
  background: #8E44AD;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple .list-toggle > .badge {
    color: #8E44AD;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-plum {
  background-color: #8775a7;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-plum .badge {
    background-color: #a294bb;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-plum.ext-1 .badge {
    background-color: #6d5b8e; }
  .mt-element-list .list-default.mt-list-head.purple-plum .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.purple-plum .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.purple-plum {
  background-color: #8775a7;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-plum {
  background-color: #8775a7;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-plum:hover {
    background-color: #79659d; }
.mt-element-list .list-todo .list-todo-line.purple-plum {
  border-color: #8775a7; }
.mt-element-list .list-todo .list-todo-item.purple-plum:after {
  border-right-color: #8775a7 !important; }
.mt-element-list .list-todo .list-todo-item.purple-plum .list-toggle {
  background: #8775a7;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-plum .list-toggle > .badge {
    color: #8775a7;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-medium {
  background-color: #BF55EC;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-medium .badge {
    background-color: #d083f1;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-medium.ext-1 .badge {
    background-color: #ae27e7; }
  .mt-element-list .list-default.mt-list-head.purple-medium .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.purple-medium .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.purple-medium {
  background-color: #BF55EC;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-medium {
  background-color: #BF55EC;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-medium:hover {
    background-color: #b63ee9; }
.mt-element-list .list-todo .list-todo-line.purple-medium {
  border-color: #BF55EC; }
.mt-element-list .list-todo .list-todo-item.purple-medium:after {
  border-right-color: #BF55EC !important; }
.mt-element-list .list-todo .list-todo-item.purple-medium .list-toggle {
  background: #BF55EC;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-medium .list-toggle > .badge {
    color: #BF55EC;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-studio {
  background-color: #8E44AD;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-studio .badge {
    background-color: #a563c1;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-studio.ext-1 .badge {
    background-color: #703688; }
  .mt-element-list .list-default.mt-list-head.purple-studio .list-label {
    color: #f9f5fb; }
  .mt-element-list .list-default.mt-list-head.purple-studio .list-date {
    color: #f9f5fb; }
.mt-element-list .list-todo.mt-list-head.purple-studio {
  background-color: #8E44AD;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-studio {
  background-color: #8E44AD;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-studio:hover {
    background-color: #7f3d9b; }
.mt-element-list .list-todo .list-todo-line.purple-studio {
  border-color: #8E44AD; }
.mt-element-list .list-todo .list-todo-item.purple-studio:after {
  border-right-color: #8E44AD !important; }
.mt-element-list .list-todo .list-todo-item.purple-studio .list-toggle {
  background: #8E44AD;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-studio .list-toggle > .badge {
    color: #8E44AD;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-wisteria {
  background-color: #9B59B6;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-wisteria .badge {
    background-color: #b07cc6;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-wisteria.ext-1 .badge {
    background-color: #804399; }
  .mt-element-list .list-default.mt-list-head.purple-wisteria .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.purple-wisteria .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.purple-wisteria {
  background-color: #9B59B6;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-wisteria {
  background-color: #9B59B6;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-wisteria:hover {
    background-color: #8f4bab; }
.mt-element-list .list-todo .list-todo-line.purple-wisteria {
  border-color: #9B59B6; }
.mt-element-list .list-todo .list-todo-item.purple-wisteria:after {
  border-right-color: #9B59B6 !important; }
.mt-element-list .list-todo .list-todo-item.purple-wisteria .list-toggle {
  background: #9B59B6;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-wisteria .list-toggle > .badge {
    color: #9B59B6;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-seance {
  background-color: #9A12B3;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-seance .badge {
    background-color: #c217e1;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-seance.ext-1 .badge {
    background-color: #720d85; }
  .mt-element-list .list-default.mt-list-head.purple-seance .list-label {
    color: #f2cafa; }
  .mt-element-list .list-default.mt-list-head.purple-seance .list-date {
    color: #f2cafa; }
.mt-element-list .list-todo.mt-list-head.purple-seance {
  background-color: #9A12B3;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-seance {
  background-color: #9A12B3;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-seance:hover {
    background-color: #86109c; }
.mt-element-list .list-todo .list-todo-line.purple-seance {
  border-color: #9A12B3; }
.mt-element-list .list-todo .list-todo-item.purple-seance:after {
  border-right-color: #9A12B3 !important; }
.mt-element-list .list-todo .list-todo-item.purple-seance .list-toggle {
  background: #9A12B3;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-seance .list-toggle > .badge {
    color: #9A12B3;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-intense {
  background-color: #8775a7;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-intense .badge {
    background-color: #a294bb;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-intense.ext-1 .badge {
    background-color: #6d5b8e; }
  .mt-element-list .list-default.mt-list-head.purple-intense .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.purple-intense .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.purple-intense {
  background-color: #8775a7;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-intense {
  background-color: #8775a7;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-intense:hover {
    background-color: #79659d; }
.mt-element-list .list-todo .list-todo-line.purple-intense {
  border-color: #8775a7; }
.mt-element-list .list-todo .list-todo-item.purple-intense:after {
  border-right-color: #8775a7 !important; }
.mt-element-list .list-todo .list-todo-item.purple-intense .list-toggle {
  background: #8775a7;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-intense .list-toggle > .badge {
    color: #8775a7;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-sharp {
  background-color: #796799;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-sharp .badge {
    background-color: #9486ad;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-sharp.ext-1 .badge {
    background-color: #61527b; }
  .mt-element-list .list-default.mt-list-head.purple-sharp .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.purple-sharp .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.purple-sharp {
  background-color: #796799;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-sharp {
  background-color: #796799;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-sharp:hover {
    background-color: #6d5d8a; }
.mt-element-list .list-todo .list-todo-line.purple-sharp {
  border-color: #796799; }
.mt-element-list .list-todo .list-todo-item.purple-sharp:after {
  border-right-color: #796799 !important; }
.mt-element-list .list-todo .list-todo-item.purple-sharp .list-toggle {
  background: #796799;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-sharp .list-toggle > .badge {
    color: #796799;
    background: #ffffff; }

.mt-element-list .list-default.mt-list-head.purple-soft {
  background-color: #8877a9;
  color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-soft .badge {
    background-color: #a396bd;
    color: #ffffff; }
  .mt-element-list .list-default.mt-list-head.purple-soft.ext-1 .badge {
    background-color: #6e5c91; }
  .mt-element-list .list-default.mt-list-head.purple-soft .list-label {
    color: white; }
  .mt-element-list .list-default.mt-list-head.purple-soft .list-date {
    color: white; }
.mt-element-list .list-todo.mt-list-head.purple-soft {
  background-color: #8877a9;
  color: #ffffff; }
.mt-element-list .list-todo .list-count.purple-soft {
  background-color: #8877a9;
  color: #ffffff; }
  .mt-element-list .list-todo .list-count.purple-soft:hover {
    background-color: #7a679f; }
.mt-element-list .list-todo .list-todo-line.purple-soft {
  border-color: #8877a9; }
.mt-element-list .list-todo .list-todo-item.purple-soft:after {
  border-right-color: #8877a9 !important; }
.mt-element-list .list-todo .list-todo-item.purple-soft .list-toggle {
  background: #8877a9;
  color: #ffffff !important; }
  .mt-element-list .list-todo .list-todo-item.purple-soft .list-toggle > .badge {
    color: #8877a9;
    background: #ffffff; }

.mt-element-list .list-todo-item.white:after {
  border-right-color: #ffffff; }
.mt-element-list .list-todo-item.white .list-toggle {
  background: #ffffff; }

.mt-element-list .list-todo-item.default:after {
  border-right-color: #e1e5ec; }
.mt-element-list .list-todo-item.default .list-toggle {
  background: #e1e5ec; }

.mt-element-list .list-todo-item.dark:after {
  border-right-color: #2f353b; }
.mt-element-list .list-todo-item.dark .list-toggle {
  background: #2f353b; }

.mt-element-list .list-todo-item.blue:after {
  border-right-color: #3598dc; }
.mt-element-list .list-todo-item.blue .list-toggle {
  background: #3598dc; }

.mt-element-list .list-todo-item.blue-madison:after {
  border-right-color: #578ebe; }
.mt-element-list .list-todo-item.blue-madison .list-toggle {
  background: #578ebe; }

.mt-element-list .list-todo-item.blue-chambray:after {
  border-right-color: #2C3E50; }
.mt-element-list .list-todo-item.blue-chambray .list-toggle {
  background: #2C3E50; }

.mt-element-list .list-todo-item.blue-ebonyclay:after {
  border-right-color: #22313F; }
.mt-element-list .list-todo-item.blue-ebonyclay .list-toggle {
  background: #22313F; }

.mt-element-list .list-todo-item.blue-hoki:after {
  border-right-color: #67809F; }
.mt-element-list .list-todo-item.blue-hoki .list-toggle {
  background: #67809F; }

.mt-element-list .list-todo-item.blue-steel:after {
  border-right-color: #4B77BE; }
.mt-element-list .list-todo-item.blue-steel .list-toggle {
  background: #4B77BE; }

.mt-element-list .list-todo-item.blue-soft:after {
  border-right-color: #4c87b9; }
.mt-element-list .list-todo-item.blue-soft .list-toggle {
  background: #4c87b9; }

.mt-element-list .list-todo-item.blue-dark:after {
  border-right-color: #5e738b; }
.mt-element-list .list-todo-item.blue-dark .list-toggle {
  background: #5e738b; }

.mt-element-list .list-todo-item.blue-sharp:after {
  border-right-color: #5C9BD1; }
.mt-element-list .list-todo-item.blue-sharp .list-toggle {
  background: #5C9BD1; }

.mt-element-list .list-todo-item.blue-oleo:after {
  border-right-color: #94A0B2; }
.mt-element-list .list-todo-item.blue-oleo .list-toggle {
  background: #94A0B2; }

.mt-element-list .list-todo-item.green:after {
  border-right-color: #32c5d2; }
.mt-element-list .list-todo-item.green .list-toggle {
  background: #32c5d2; }

.mt-element-list .list-todo-item.green-meadow:after {
  border-right-color: #1BBC9B; }
.mt-element-list .list-todo-item.green-meadow .list-toggle {
  background: #1BBC9B; }

.mt-element-list .list-todo-item.green-seagreen:after {
  border-right-color: #1BA39C; }
.mt-element-list .list-todo-item.green-seagreen .list-toggle {
  background: #1BA39C; }

.mt-element-list .list-todo-item.green-turquoise:after {
  border-right-color: #36D7B7; }
.mt-element-list .list-todo-item.green-turquoise .list-toggle {
  background: #36D7B7; }

.mt-element-list .list-todo-item.green-haze:after {
  border-right-color: #44b6ae; }
.mt-element-list .list-todo-item.green-haze .list-toggle {
  background: #44b6ae; }

.mt-element-list .list-todo-item.green-jungle:after {
  border-right-color: #26C281; }
.mt-element-list .list-todo-item.green-jungle .list-toggle {
  background: #26C281; }

.mt-element-list .list-todo-item.green-soft:after {
  border-right-color: #3faba4; }
.mt-element-list .list-todo-item.green-soft .list-toggle {
  background: #3faba4; }

.mt-element-list .list-todo-item.green-dark:after {
  border-right-color: #4DB3A2; }
.mt-element-list .list-todo-item.green-dark .list-toggle {
  background: #4DB3A2; }

.mt-element-list .list-todo-item.green-sharp:after {
  border-right-color: #2ab4c0; }
.mt-element-list .list-todo-item.green-sharp .list-toggle {
  background: #2ab4c0; }

.mt-element-list .list-todo-item.green-steel:after {
  border-right-color: #29b4b6; }
.mt-element-list .list-todo-item.green-steel .list-toggle {
  background: #29b4b6; }

.mt-element-list .list-todo-item.grey:after {
  border-right-color: #E5E5E5; }
.mt-element-list .list-todo-item.grey .list-toggle {
  background: #E5E5E5; }

.mt-element-list .list-todo-item.grey-steel:after {
  border-right-color: #e9edef; }
.mt-element-list .list-todo-item.grey-steel .list-toggle {
  background: #e9edef; }

.mt-element-list .list-todo-item.grey-cararra:after {
  border-right-color: #fafafa; }
.mt-element-list .list-todo-item.grey-cararra .list-toggle {
  background: #fafafa; }

.mt-element-list .list-todo-item.grey-gallery:after {
  border-right-color: #555555; }
.mt-element-list .list-todo-item.grey-gallery .list-toggle {
  background: #555555; }

.mt-element-list .list-todo-item.grey-cascade:after {
  border-right-color: #95A5A6; }
.mt-element-list .list-todo-item.grey-cascade .list-toggle {
  background: #95A5A6; }

.mt-element-list .list-todo-item.grey-silver:after {
  border-right-color: #BFBFBF; }
.mt-element-list .list-todo-item.grey-silver .list-toggle {
  background: #BFBFBF; }

.mt-element-list .list-todo-item.grey-salsa:after {
  border-right-color: #ACB5C3; }
.mt-element-list .list-todo-item.grey-salsa .list-toggle {
  background: #ACB5C3; }

.mt-element-list .list-todo-item.grey-salt:after {
  border-right-color: #bfcad1; }
.mt-element-list .list-todo-item.grey-salt .list-toggle {
  background: #bfcad1; }

.mt-element-list .list-todo-item.grey-mint:after {
  border-right-color: #525e64; }
.mt-element-list .list-todo-item.grey-mint .list-toggle {
  background: #525e64; }

.mt-element-list .list-todo-item.red:after {
  border-right-color: #e7505a; }
.mt-element-list .list-todo-item.red .list-toggle {
  background: #e7505a; }

.mt-element-list .list-todo-item.red-pink:after {
  border-right-color: #E08283; }
.mt-element-list .list-todo-item.red-pink .list-toggle {
  background: #E08283; }

.mt-element-list .list-todo-item.red-sunglo:after {
  border-right-color: #E26A6A; }
.mt-element-list .list-todo-item.red-sunglo .list-toggle {
  background: #E26A6A; }

.mt-element-list .list-todo-item.red-intense:after {
  border-right-color: #e35b5a; }
.mt-element-list .list-todo-item.red-intense .list-toggle {
  background: #e35b5a; }

.mt-element-list .list-todo-item.red-thunderbird:after {
  border-right-color: #D91E18; }
.mt-element-list .list-todo-item.red-thunderbird .list-toggle {
  background: #D91E18; }

.mt-element-list .list-todo-item.red-flamingo:after {
  border-right-color: #EF4836; }
.mt-element-list .list-todo-item.red-flamingo .list-toggle {
  background: #EF4836; }

.mt-element-list .list-todo-item.red-soft:after {
  border-right-color: #d05454; }
.mt-element-list .list-todo-item.red-soft .list-toggle {
  background: #d05454; }

.mt-element-list .list-todo-item.red-haze:after {
  border-right-color: #f36a5a; }
.mt-element-list .list-todo-item.red-haze .list-toggle {
  background: #f36a5a; }

.mt-element-list .list-todo-item.red-mint:after {
  border-right-color: #e43a45; }
.mt-element-list .list-todo-item.red-mint .list-toggle {
  background: #e43a45; }

.mt-element-list .list-todo-item.yellow:after {
  border-right-color: #c49f47; }
.mt-element-list .list-todo-item.yellow .list-toggle {
  background: #c49f47; }

.mt-element-list .list-todo-item.yellow-gold:after {
  border-right-color: #E87E04; }
.mt-element-list .list-todo-item.yellow-gold .list-toggle {
  background: #E87E04; }

.mt-element-list .list-todo-item.yellow-casablanca:after {
  border-right-color: #f2784b; }
.mt-element-list .list-todo-item.yellow-casablanca .list-toggle {
  background: #f2784b; }

.mt-element-list .list-todo-item.yellow-crusta:after {
  border-right-color: #f3c200; }
.mt-element-list .list-todo-item.yellow-crusta .list-toggle {
  background: #f3c200; }

.mt-element-list .list-todo-item.yellow-lemon:after {
  border-right-color: #F7CA18; }
.mt-element-list .list-todo-item.yellow-lemon .list-toggle {
  background: #F7CA18; }

.mt-element-list .list-todo-item.yellow-saffron:after {
  border-right-color: #F4D03F; }
.mt-element-list .list-todo-item.yellow-saffron .list-toggle {
  background: #F4D03F; }

.mt-element-list .list-todo-item.yellow-soft:after {
  border-right-color: #c8d046; }
.mt-element-list .list-todo-item.yellow-soft .list-toggle {
  background: #c8d046; }

.mt-element-list .list-todo-item.yellow-haze:after {
  border-right-color: #c5bf66; }
.mt-element-list .list-todo-item.yellow-haze .list-toggle {
  background: #c5bf66; }

.mt-element-list .list-todo-item.yellow-mint:after {
  border-right-color: #c5b96b; }
.mt-element-list .list-todo-item.yellow-mint .list-toggle {
  background: #c5b96b; }

.mt-element-list .list-todo-item.purple:after {
  border-right-color: #8E44AD; }
.mt-element-list .list-todo-item.purple .list-toggle {
  background: #8E44AD; }

.mt-element-list .list-todo-item.purple-plum:after {
  border-right-color: #8775a7; }
.mt-element-list .list-todo-item.purple-plum .list-toggle {
  background: #8775a7; }

.mt-element-list .list-todo-item.purple-medium:after {
  border-right-color: #BF55EC; }
.mt-element-list .list-todo-item.purple-medium .list-toggle {
  background: #BF55EC; }

.mt-element-list .list-todo-item.purple-studio:after {
  border-right-color: #8E44AD; }
.mt-element-list .list-todo-item.purple-studio .list-toggle {
  background: #8E44AD; }

.mt-element-list .list-todo-item.purple-wisteria:after {
  border-right-color: #9B59B6; }
.mt-element-list .list-todo-item.purple-wisteria .list-toggle {
  background: #9B59B6; }

.mt-element-list .list-todo-item.purple-seance:after {
  border-right-color: #9A12B3; }
.mt-element-list .list-todo-item.purple-seance .list-toggle {
  background: #9A12B3; }

.mt-element-list .list-todo-item.purple-intense:after {
  border-right-color: #8775a7; }
.mt-element-list .list-todo-item.purple-intense .list-toggle {
  background: #8775a7; }

.mt-element-list .list-todo-item.purple-sharp:after {
  border-right-color: #796799; }
.mt-element-list .list-todo-item.purple-sharp .list-toggle {
  background: #796799; }

.mt-element-list .list-todo-item.purple-soft:after {
  border-right-color: #8877a9; }
.mt-element-list .list-todo-item.purple-soft .list-toggle {
  background: #8877a9; }

.mt-element-ribbon {
  position: relative;
  margin-bottom: 30px; }
  .mt-element-ribbon .ribbon-content {
    margin: 0;
    padding: 25px;
    clear: both; }
    .mt-element-ribbon .ribbon-content.no-padding {
      padding-top: 0; }
  .mt-element-ribbon .ribbon {
    padding: 0.5em 1em;
    z-index: 5;
    float: left;
    margin: 10px 0 0 -2px;
    clear: left;
    position: relative;
    background-color: #bac3d0;
    color: #384353; }
    .mt-element-ribbon .ribbon.ribbon-right {
      float: right;
      clear: right;
      margin: 10px -2px 0 0; }
    .mt-element-ribbon .ribbon.ribbon-vertical-left {
      clear: none;
      margin: -2px 0 0 10px;
      padding-top: 1em;
      padding-bottom: 1em;
      width: 41px;
      text-align: center; }
    .mt-element-ribbon .ribbon.ribbon-vertical-right {
      clear: none;
      float: right;
      margin: -2px 10px 0 0;
      padding-top: 1em;
      padding-bottom: 1em;
      width: 41px;
      text-align: center; }
    .mt-element-ribbon .ribbon.ribbon-shadow {
      box-shadow: 2px 2px 7px rgba(0, 0, 0, 0.4); }
      .mt-element-ribbon .ribbon.ribbon-shadow.ribbon-right, .mt-element-ribbon .ribbon.ribbon-shadow.ribbon-vertical-right {
        box-shadow: -2px 2px 7px rgba(0, 0, 0, 0.4); }
    .mt-element-ribbon .ribbon.ribbon-round {
      border-top-right-radius: 5px !important;
      border-bottom-right-radius: 5px !important; }
      .mt-element-ribbon .ribbon.ribbon-round.ribbon-right {
        border-top-right-radius: 0px !important;
        border-bottom-right-radius: 0px !important;
        border-top-left-radius: 5px !important;
        border-bottom-left-radius: 5px !important; }
      .mt-element-ribbon .ribbon.ribbon-round.ribbon-vertical-right, .mt-element-ribbon .ribbon.ribbon-round.ribbon-vertical-left {
        border-top-right-radius: 0px !important;
        border-bottom-right-radius: 5px !important;
        border-top-left-radius: 0px !important;
        border-bottom-left-radius: 5px !important; }
    .mt-element-ribbon .ribbon.ribbon-border:after {
      border: 1px solid;
      content: '';
      position: absolute;
      top: 5px;
      bottom: 5px;
      left: 5px;
      right: 5px; }
    .mt-element-ribbon .ribbon.ribbon-border-vert:after {
      border-top: none;
      border-bottom: none;
      border-left: 1px solid;
      border-right: 1px solid;
      content: '';
      position: absolute;
      top: 0;
      bottom: 0;
      left: 5px;
      right: 5px; }
    .mt-element-ribbon .ribbon.ribbon-border-hor:after {
      border-top: 1px solid;
      border-bottom: 1px solid;
      border-left: none;
      border-right: none;
      content: '';
      position: absolute;
      top: 5px;
      bottom: 5px;
      left: 0;
      right: 0; }
    .mt-element-ribbon .ribbon.ribbon-border-dash:after {
      border: 1px solid;
      border-style: dashed;
      content: '';
      position: absolute;
      top: 5px;
      bottom: 5px;
      left: 5px;
      right: 5px; }
    .mt-element-ribbon .ribbon.ribbon-border-dash-vert:after {
      border-top: none;
      border-bottom: none;
      border-left: 1px solid;
      border-right: 1px solid;
      border-left-style: dashed;
      border-right-style: dashed;
      content: '';
      position: absolute;
      top: 0;
      bottom: 0;
      left: 5px;
      right: 5px; }
    .mt-element-ribbon .ribbon.ribbon-border-dash-hor:after {
      border-top: 1px solid;
      border-bottom: 1px solid;
      border-left: none;
      border-right: none;
      border-top-style: dashed;
      border-bottom-style: dashed;
      content: '';
      position: absolute;
      top: 5px;
      bottom: 5px;
      left: 0;
      right: 0; }
    .mt-element-ribbon .ribbon.ribbon-clip {
      left: -10px;
      margin-left: 0; }
      .mt-element-ribbon .ribbon.ribbon-clip.ribbon-right {
        left: auto;
        right: -10px;
        margin-right: 0; }
    .mt-element-ribbon .ribbon > .ribbon-sub {
      z-index: -1;
      position: absolute;
      padding: 0;
      width: 100%;
      height: 100%;
      top: 0;
      left: 0; }
      .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip:before, .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip:after {
        content: '';
        position: absolute;
        border-style: solid;
        border-color: transparent !important;
        bottom: -10px; }
      .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip:before {
        border-width: 0 10px 10px 0;
        border-right-color: #222 !important;
        left: 0; }
      .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip.ribbon-right:before, .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip.ribbon-right:after {
        content: '';
        position: absolute;
        border-style: solid;
        border-color: transparent;
        bottom: -10px; }
      .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip.ribbon-right:before {
        border-right-color: transparent !important; }
      .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-clip.ribbon-right:after {
        border-width: 0 0 10px 10px;
        border-left-color: #222 !important;
        right: 0; }
      .mt-element-ribbon .ribbon > .ribbon-sub.ribbon-bookmark:after {
        border-left: 21px solid;
        border-right: 20px solid;
        border-bottom: 1em solid transparent !important;
        bottom: -1em;
        content: '';
        height: 0;
        left: 0;
        position: absolute;
        width: 0; }
    .mt-element-ribbon .ribbon:after {
      border-color: #62748f; }
    .mt-element-ribbon .ribbon > .ribbon-sub {
      background-color: #bac3d0;
      color: #384353; }
      .mt-element-ribbon .ribbon > .ribbon-sub:after {
        border-color: #62748f;
        border-left-color: #bac3d0;
        border-right-color: #bac3d0; }
    .mt-element-ribbon .ribbon.ribbon-color-default {
      background-color: #bac3d0;
      color: #384353; }
      .mt-element-ribbon .ribbon.ribbon-color-default:after {
        border-color: #9ca8bb; }
      .mt-element-ribbon .ribbon.ribbon-color-default > .ribbon-sub {
        background-color: #bac3d0;
        color: #384353; }
        .mt-element-ribbon .ribbon.ribbon-color-default > .ribbon-sub:after {
          border-color: #62748f;
          border-left-color: #bac3d0;
          border-right-color: #bac3d0; }
    .mt-element-ribbon .ribbon.ribbon-color-primary {
      background-color: #17b8b6;
      color: #fff; }
      .mt-element-ribbon .ribbon.ribbon-color-primary:after {
        border-color: #118a89; }
      .mt-element-ribbon .ribbon.ribbon-color-primary > .ribbon-sub {
        background-color: #17b8b6;
        color: black; }
        .mt-element-ribbon .ribbon.ribbon-color-primary > .ribbon-sub:after {
          border-color: #06302f;
          border-left-color: #17b8b6;
          border-right-color: #17b8b6; }
    .mt-element-ribbon .ribbon.ribbon-color-info {
      background-color: #659be0;
      color: #fff; }
      .mt-element-ribbon .ribbon.ribbon-color-info:after {
        border-color: #3a80d7; }
      .mt-element-ribbon .ribbon.ribbon-color-info > .ribbon-sub {
        background-color: #659be0;
        color: #0c203a; }
        .mt-element-ribbon .ribbon.ribbon-color-info > .ribbon-sub:after {
          border-color: #1d4f8e;
          border-left-color: #659be0;
          border-right-color: #659be0; }
    .mt-element-ribbon .ribbon.ribbon-color-success {
      background-color: #36c6d3;
      color: #fff; }
      .mt-element-ribbon .ribbon.ribbon-color-success:after {
        border-color: #27a4b0; }
      .mt-element-ribbon .ribbon.ribbon-color-success > .ribbon-sub {
        background-color: #36c6d3;
        color: #020808; }
        .mt-element-ribbon .ribbon.ribbon-color-success > .ribbon-sub:after {
          border-color: #14565c;
          border-left-color: #36c6d3;
          border-right-color: #36c6d3; }
    .mt-element-ribbon .ribbon.ribbon-color-danger {
      background-color: #ed6b75;
      color: #fff; }
      .mt-element-ribbon .ribbon.ribbon-color-danger:after {
        border-color: #e73d4a; }
      .mt-element-ribbon .ribbon.ribbon-color-danger > .ribbon-sub {
        background-color: #ed6b75;
        color: #4f0a0f; }
        .mt-element-ribbon .ribbon.ribbon-color-danger > .ribbon-sub:after {
          border-color: #a91520;
          border-left-color: #ed6b75;
          border-right-color: #ed6b75; }
    .mt-element-ribbon .ribbon.ribbon-color-warning {
      background-color: #F1C40F;
      color: #010100; }
      .mt-element-ribbon .ribbon.ribbon-color-warning:after {
        border-color: #c29d0b; }
      .mt-element-ribbon .ribbon.ribbon-color-warning > .ribbon-sub {
        background-color: #F1C40F;
        color: #010100; }
        .mt-element-ribbon .ribbon.ribbon-color-warning > .ribbon-sub:after {
          border-color: #614f06;
          border-left-color: #F1C40F;
          border-right-color: #F1C40F; }

.mt-element-card .mt-card-item {
  border: 1px solid;
  border-color: #e7ecf1;
  position: relative;
  margin-bottom: 30px; }
  .mt-element-card .mt-card-item .mt-card-avatar {
    margin-bottom: 15px; }
  .mt-element-card .mt-card-item .mt-card-content {
    text-align: center; }
    .mt-element-card .mt-card-item .mt-card-content .mt-card-name {
      font-size: 16px;
      font-weight: 600;
      margin-bottom: 10px; }
    .mt-element-card .mt-card-item .mt-card-content .mt-card-desc {
      font-size: 14px;
      margin: 0 0 10px 0; }
    .mt-element-card .mt-card-item .mt-card-content .mt-card-social > ul {
      padding: 0;
      margin-bottom: 10px; }
      .mt-element-card .mt-card-item .mt-card-content .mt-card-social > ul > li {
        list-style: none;
        display: inline-block;
        margin: 0 3px; }
        .mt-element-card .mt-card-item .mt-card-content .mt-card-social > ul > li > a {
          color: #000;
          font-size: 18px; }
          .mt-element-card .mt-card-item .mt-card-content .mt-card-social > ul > li > a.mt-card-btn {
            color: #fff; }
            .mt-element-card .mt-card-item .mt-card-content .mt-card-social > ul > li > a.mt-card-btn:hover {
              color: #36c6d3; }
          .mt-element-card .mt-card-item .mt-card-content .mt-card-social > ul > li > a:hover {
            color: #F1C40F; }
.mt-element-card.mt-card-round .mt-card-item {
  padding: 40px 40px 10px 40px; }
  .mt-element-card.mt-card-round .mt-card-item .mt-card-avatar {
    border-radius: 50% !important;
    -webkit-mask-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAA5JREFUeNpiYGBgAAgwAAAEAAGbA+oJAAAAAElFTkSuQmCC); }
    .mt-element-card.mt-card-round .mt-card-item .mt-card-avatar .mt-overlay {
      -webkit-border-radius: 50%;
      -moz-border-radius: 50%;
      -ms-border-radius: 50%;
      -o-border-radius: 50%;
      border-radius: 50%; }

.mt-element-overlay .mt-overlay-1 {
  width: 100%;
  height: 100%;
  float: left;
  overflow: hidden;
  position: relative;
  text-align: center;
  cursor: default; }
  .mt-element-overlay .mt-overlay-1 img {
    display: block;
    position: relative;
    -webkit-transition: all .4s linear;
    transition: all .4s linear;
    width: 100%;
    height: auto; }
  .mt-element-overlay .mt-overlay-1 h2 {
    text-transform: uppercase;
    color: #fff;
    text-align: center;
    position: relative;
    font-size: 17px;
    background: rgba(0, 0, 0, 0.6);
    -webkit-transform: translatey(-100px) translateZ(0);
    -ms-transform: translatey(-100px) translateZ(0);
    transform: translatey(-100px) translateZ(0);
    -webkit-transition: all .2s ease-in-out;
    transition: all .2s ease-in-out;
    padding: 10px; }
  .mt-element-overlay .mt-overlay-1 .mt-info {
    text-decoration: none;
    display: inline-block;
    text-transform: uppercase;
    color: #fff;
    background-color: transparent;
    opacity: 0;
    filter: alpha(opacity=0);
    -webkit-transition: all .2s ease-in-out;
    transition: all .2s ease-in-out;
    padding: 0;
    margin: auto;
    position: absolute;
    top: 50%;
    left: 0;
    right: 0;
    transform: translateY(-50%) translateZ(0);
    -webkit-transform: translateY(-50%) translateZ(0);
    -ms-transform: translateY(-50%) translateZ(0); }
    .mt-element-overlay .mt-overlay-1 .mt-info > li {
      list-style: none;
      display: inline-block;
      margin: 0 3px; }
      .mt-element-overlay .mt-overlay-1 .mt-info > li:hover {
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
        cursor: pointer; }
  .mt-element-overlay .mt-overlay-1:hover .mt-overlay {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transform: translateZ(0);
    -ms-transform: translateZ(0);
    transform: translateZ(0); }
  .mt-element-overlay .mt-overlay-1:hover img {
    -ms-transform: scale(1.2) translateZ(0);
    -webkit-transform: scale(1.2) translateZ(0);
    transform: scale(1.2) translateZ(0); }
  .mt-element-overlay .mt-overlay-1:hover .mt-info {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transition-delay: .2s;
    transition-delay: .2s; }
  .mt-element-overlay .mt-overlay-1 .mt-overlay {
    width: 100%;
    height: 100%;
    position: absolute;
    overflow: hidden;
    top: 0;
    left: 0;
    opacity: 0;
    background-color: rgba(0, 0, 0, 0.7);
    -webkit-transition: all .4s ease-in-out;
    transition: all .4s ease-in-out; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-up:hover .mt-overlay {
    bottom: 0; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-up .mt-overlay {
    bottom: -100%;
    top: auto; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-down:hover .mt-overlay {
    top: 0; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-down .mt-overlay {
    top: -100%; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-left:hover .mt-overlay {
    right: 0; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-left .mt-overlay {
    right: -100%;
    left: auto; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-right:hover .mt-overlay {
    left: 0; }
  .mt-element-overlay .mt-overlay-1.mt-scroll-right .mt-overlay {
    left: -100%; }
.mt-element-overlay .mt-overlay-2 {
  width: 100%;
  height: 100%;
  float: left;
  overflow: hidden;
  position: relative;
  text-align: center;
  cursor: default; }
  .mt-element-overlay .mt-overlay-2 img {
    display: block;
    position: relative;
    -webkit-transition: all 0.4s ease-in;
    transition: all 0.4s ease-in;
    width: 100%;
    height: auto; }
  .mt-element-overlay .mt-overlay-2 h2 {
    text-transform: uppercase;
    text-align: center;
    position: relative;
    font-size: 17px;
    padding: 10px;
    background: rgba(0, 0, 0, 0.6); }
  .mt-element-overlay .mt-overlay-2 .mt-info,
  .mt-element-overlay .mt-overlay-2 h2 {
    -webkit-transform: scale(0.7);
    -ms-transform: scale(0.7);
    transform: scale(0.7);
    -webkit-transition: all 0.4s ease-in;
    transition: all 0.4s ease-in;
    opacity: 0;
    filter: alpha(opacity=0);
    color: #fff;
    text-transform: uppercase; }
  .mt-element-overlay .mt-overlay-2 .mt-info {
    display: inline-block;
    text-decoration: none;
    margin: auto;
    position: absolute;
    top: 50%;
    -webkit-transform: scale(0.7) translateY(-50%) translateX(-50%);
    -ms-transform: scale(0.7) translateY(-50%) translateX(-50%);
    transform: scale(0.7) translateY(-50%) translateX(-50%); }
    .mt-element-overlay .mt-overlay-2 .mt-info:hover {
      box-shadow: 0 0 5px #fff; }
  .mt-element-overlay .mt-overlay-2:hover img {
    filter: url('data:image/svg+xml;charset=utf-8,<svg xmlns="http://www.w3.org/2000/svg"><filter id="filter"><feColorMatrix type="matrix" color-interpolation-filters="sRGB" values="0.2126 0.7152 0.0722 0 0 0.2126 0.7152 0.0722 0 0 0.2126 0.7152 0.0722 0 0 0 0 0 1 0" /><feGaussianBlur stdDeviation="3" /></filter></svg>#filter');
    filter: blur(3px);
    -webkit-filter: blur(3px);
    -webkit-transform: scale(1.2);
    -ms-transform: scale(1.2);
    transform: scale(1.2); }
  .mt-element-overlay .mt-overlay-2:hover .mt-overlay {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transition-delay: 0s;
    transition-delay: 0s;
    -webkit-transform: translate(0px, 0px);
    -ms-transform: translate(0px, 0px);
    transform: translate(0px, 0px); }
  .mt-element-overlay .mt-overlay-2:hover h2 {
    -webkit-transition-delay: 0.5s;
    transition-delay: 0.5s; }
  .mt-element-overlay .mt-overlay-2:hover .mt-info,
  .mt-element-overlay .mt-overlay-2:hover h2 {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transform: scale(1) translateY(-50%);
    -ms-transform: scale(1) translateY(-50%);
    transform: scale(1) translateY(-50%); }
  .mt-element-overlay .mt-overlay-2:hover .mt-info {
    -webkit-transform: scale(1) translateY(-50%) translateX(-50%);
    -ms-transform: scale(1) translateY(-50%) translateX(-50%);
    transform: scale(1) translateY(-50%) translateX(-50%); }
  .mt-element-overlay .mt-overlay-2 .mt-overlay {
    width: 100%;
    height: 100%;
    position: absolute;
    overflow: hidden;
    top: 0;
    left: 0; }
  .mt-element-overlay .mt-overlay-2.mt-overlay-2-grey:hover img {
    filter: url('data:image/svg+xml;charset=utf-8,<svg xmlns="http://www.w3.org/2000/svg"><filter id="filter"><feColorMatrix type="matrix" color-interpolation-filters="sRGB" values="0.2126 0.7152 0.0722 0 0 0.2126 0.7152 0.0722 0 0 0.2126 0.7152 0.0722 0 0 0 0 0 1 0" /><feGaussianBlur stdDeviation="3" /></filter></svg>#filter');
    filter: grayscale(1) blur(3px);
    -webkit-filter: grayscale(1) blur(3px); }
  .mt-element-overlay .mt-overlay-2.mt-overlay-2-icons .mt-info {
    border: none;
    width: 100%;
    padding: 0;
    -webkit-transform: scale(0.7) translateY(-50%) translateX(-50%);
    -ms-transform: scale(0.7) translateY(-50%) translateX(-50%);
    transform: scale(0.7) translateY(-50%) translateX(-50%); }
    .mt-element-overlay .mt-overlay-2.mt-overlay-2-icons .mt-info:hover {
      box-shadow: none; }
    .mt-element-overlay .mt-overlay-2.mt-overlay-2-icons .mt-info > li {
      list-style: none;
      display: inline-block;
      margin: 0 3px; }
      .mt-element-overlay .mt-overlay-2.mt-overlay-2-icons .mt-info > li:hover {
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
        cursor: pointer; }
  .mt-element-overlay .mt-overlay-2.mt-overlay-2-icons:hover .mt-info {
    -webkit-transform: scale(1) translateY(-50%) translateX(-50%);
    -ms-transform: scale(1) translateY(-50%) translateX(-50%);
    transform: scale(1) translateY(-50%) translateX(-50%); }
.mt-element-overlay .mt-overlay-3 {
  width: 100%;
  height: 100%;
  float: left;
  overflow: hidden;
  position: relative;
  text-align: center;
  cursor: default; }
  .mt-element-overlay .mt-overlay-3 img {
    display: block;
    position: relative;
    width: 100%;
    height: auto; }
  .mt-element-overlay .mt-overlay-3 h2 {
    text-transform: uppercase;
    color: #fff;
    text-align: center;
    position: relative;
    font-size: 17px;
    padding: 10px;
    background: rgba(0, 0, 0, 0.6);
    -webkit-transform: translateY(100px);
    -ms-transform: translateY(100px);
    transform: translateY(100px);
    -webkit-transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81); }
  .mt-element-overlay .mt-overlay-3 .mt-info {
    display: inline-block;
    text-decoration: none;
    text-transform: uppercase;
    color: #fff;
    border: 1px solid #fff;
    background-color: transparent;
    opacity: 0;
    filter: alpha(opacity=0);
    -webkit-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0);
    -webkit-transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    font-weight: normal;
    position: absolute;
    top: 15px;
    bottom: 15px;
    left: 15px;
    right: 15px;
    margin: auto;
    padding: 45% 0 0 0; }
    .mt-element-overlay .mt-overlay-3 .mt-info:hover {
      box-shadow: 0 0 5px #fff; }
  .mt-element-overlay .mt-overlay-3:hover .mt-overlay {
    background-color: rgba(48, 152, 157, 0.7); }
  .mt-element-overlay .mt-overlay-3:hover h2 {
    -webkit-transform: translateY(5px);
    -ms-transform: translateY(5px);
    transform: translateY(5px); }
  .mt-element-overlay .mt-overlay-3:hover .mt-info {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); }
  .mt-element-overlay .mt-overlay-3 .mt-overlay {
    width: 100%;
    height: 100%;
    position: absolute;
    overflow: hidden;
    top: 0;
    left: 0;
    background-color: rgba(75, 75, 75, 0.7);
    -webkit-transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81); }
  .mt-element-overlay .mt-overlay-3.mt-overlay-3-icons .mt-info {
    padding: 40% 0 0 0; }
    .mt-element-overlay .mt-overlay-3.mt-overlay-3-icons .mt-info > li {
      list-style: none;
      display: inline-block;
      margin: 0 3px; }
      .mt-element-overlay .mt-overlay-3.mt-overlay-3-icons .mt-info > li:hover {
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
        cursor: pointer; }
.mt-element-overlay .mt-overlay-4 {
  width: 100%;
  height: 100%;
  float: left;
  overflow: hidden;
  position: relative;
  text-align: center;
  cursor: default; }
  .mt-element-overlay .mt-overlay-4 img {
    display: block;
    position: relative;
    -webkit-transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    width: 100%;
    height: auto; }
  .mt-element-overlay .mt-overlay-4 h2 {
    text-transform: uppercase;
    color: #fff;
    text-align: center;
    position: relative;
    font-size: 17px;
    background: rgba(0, 0, 0, 0.6);
    -webkit-transform: translatey(-100px);
    -ms-transform: translatey(-100px);
    transform: translatey(-100px);
    -webkit-transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    padding: 10px; }
  .mt-element-overlay .mt-overlay-4 .mt-info {
    display: inline-block;
    text-transform: uppercase;
    opacity: 0;
    filter: alpha(opacity=0);
    -webkit-transition: all 0.4s ease;
    transition: all 0.4s ease;
    margin: 50px 0 0; }
  .mt-element-overlay .mt-overlay-4:hover .mt-overlay {
    opacity: 1;
    filter: alpha(opacity=100); }
  .mt-element-overlay .mt-overlay-4:hover h2,
  .mt-element-overlay .mt-overlay-4:hover .mt-info {
    opacity: 1;
    filter: alpha(opacity=100);
    -ms-transform: translatey(0);
    -webkit-transform: translatey(0);
    transform: translatey(0); }
  .mt-element-overlay .mt-overlay-4:hover .mt-info {
    -webkit-transition-delay: .2s;
    transition-delay: .2s; }
  .mt-element-overlay .mt-overlay-4 .mt-overlay {
    width: 100%;
    height: 100%;
    position: absolute;
    overflow: hidden;
    top: 0;
    left: 0;
    opacity: 0;
    filter: alpha(opacity=0);
    background-color: rgba(0, 0, 0, 0.7);
    -webkit-transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81);
    transition: all 0.4s cubic-bezier(0.88, -0.99, 0, 1.81); }
  .mt-element-overlay .mt-overlay-4.mt-overlay-4-icons .mt-info {
    border: none;
    position: absolute;
    padding: 0;
    top: 50%;
    left: 0;
    right: 0;
    -webkit-transform: translateY(-50%);
    -ms-transform: translateY(-50%);
    transform: translateY(-50%);
    margin: auto; }
    .mt-element-overlay .mt-overlay-4.mt-overlay-4-icons .mt-info:hover {
      box-shadow: none; }
    .mt-element-overlay .mt-overlay-4.mt-overlay-4-icons .mt-info > li {
      list-style: none;
      display: inline-block;
      margin: 0 3px; }
      .mt-element-overlay .mt-overlay-4.mt-overlay-4-icons .mt-info > li:hover {
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
        cursor: pointer; }
.mt-element-overlay .mt-overlay-5 {
  width: 100%;
  height: 100%;
  float: left;
  overflow: hidden;
  position: relative;
  text-align: center;
  cursor: default;
  background: -webkit-linear-gradient(45deg, #ff89e9 0%, #05abe0 100%);
  background: linear-gradient(45deg, #ff89e9 0%, #05abe0 100%); }
  .mt-element-overlay .mt-overlay-5 .mt-overlay {
    width: 100%;
    height: 100%;
    position: absolute;
    overflow: hidden;
    top: 0;
    left: 0;
    padding: 3em;
    text-align: left; }
    .mt-element-overlay .mt-overlay-5 .mt-overlay:before {
      position: absolute;
      top: 20px;
      right: 20px;
      bottom: 20px;
      left: 20px;
      border: 1px solid #fff;
      content: '';
      opacity: 0;
      filter: alpha(opacity=0);
      -webkit-transition: opacity 0.35s, -webkit-transform 0.45s;
      transition: opacity 0.35s, transform 0.45s;
      -webkit-transform: translate3d(-20px, 0, 0);
      transform: translate3d(-20px, 0, 0); }
  .mt-element-overlay .mt-overlay-5 img {
    display: block;
    position: relative;
    max-width: none;
    width: calc(113% + 60px);
    -webkit-transition: opacity 0.35s, -webkit-transform 0.45s;
    transition: opacity 0.35s, transform 0.45s;
    -webkit-transform: translate3d(-40px, 0, 0);
    transform: translate3d(-40px, 0, 0); }
  .mt-element-overlay .mt-overlay-5 h2 {
    text-transform: uppercase;
    color: #fff;
    position: relative;
    font-size: 17px;
    background-color: transparent;
    padding: 15% 0 10px 0;
    text-align: left; }
  .mt-element-overlay .mt-overlay-5 a,
  .mt-element-overlay .mt-overlay-5 p {
    color: #FFF;
    opacity: 0;
    filter: alpha(opacity=0);
    -webkit-transition: opacity 0.35s, -webkit-transform 0.45s;
    transition: opacity 0.35s, transform 0.45s;
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0); }
  .mt-element-overlay .mt-overlay-5 a:hover {
    text-decoration: none;
    opacity: 0.6;
    filter: alpha(opacity=60); }
  .mt-element-overlay .mt-overlay-5:hover img {
    opacity: 0.6;
    filter: alpha(opacity=60);
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0); }
  .mt-element-overlay .mt-overlay-5:hover .mt-overlay:before,
  .mt-element-overlay .mt-overlay-5:hover a,
  .mt-element-overlay .mt-overlay-5:hover p {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0); }
.mt-element-overlay .mt-overlay-6 {
  width: 100%;
  height: 100%;
  float: left;
  overflow: hidden;
  position: relative;
  text-align: center;
  cursor: default;
  background: #42b078; }
  .mt-element-overlay .mt-overlay-6 .mt-overlay {
    width: 100%;
    height: 100%;
    position: absolute;
    overflow: hidden;
    top: 0;
    left: 0;
    padding: 50px 20px; }
  .mt-element-overlay .mt-overlay-6 img {
    display: block;
    position: relative;
    max-width: none;
    width: calc(100% + 20px);
    -webkit-transition: opacity 0.35s, -webkit-transform 0.35s;
    transition: opacity 0.35s, transform 0.35s;
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden; }
  .mt-element-overlay .mt-overlay-6 h2 {
    text-transform: uppercase;
    color: #fff;
    text-align: center;
    position: relative;
    font-size: 17px;
    overflow: hidden;
    padding: 0.5em 0;
    background-color: transparent; }
    .mt-element-overlay .mt-overlay-6 h2:after {
      position: absolute;
      bottom: 0;
      left: 0;
      width: 100%;
      height: 2px;
      background: #fff;
      content: '';
      -webkit-transition: -webkit-transform 0.35s;
      transition: transform 0.35s;
      -webkit-transform: translate3d(-100%, 0, 0);
      transform: translate3d(-100%, 0, 0); }
  .mt-element-overlay .mt-overlay-6 a,
  .mt-element-overlay .mt-overlay-6 p {
    color: #FFF;
    opacity: 0;
    filter: alpha(opacity=0);
    -webkit-transition: opacity 0.35s, -webkit-transform 0.35s;
    transition: opacity 0.35s, transform 0.35s;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0); }
  .mt-element-overlay .mt-overlay-6 p {
    margin-top: 20px; }
  .mt-element-overlay .mt-overlay-6 .mt-info:hover {
    text-decoration: none;
    opacity: 0.6;
    filter: alpha(opacity=60);
    -webkit-transition: all .2s ease-in-out;
    transition: all .2s ease-in-out;
    cursor: pointer; }
  .mt-element-overlay .mt-overlay-6:hover img {
    opacity: 0.4;
    filter: alpha(opacity=40);
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0); }
  .mt-element-overlay .mt-overlay-6:hover h2:after {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0); }
  .mt-element-overlay .mt-overlay-6:hover a,
  .mt-element-overlay .mt-overlay-6:hover p {
    opacity: 1;
    filter: alpha(opacity=100);
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0); }

/***
Custom color buttons 
***/
.bg-white {
  background: #ffffff !important; }

.bg-white-opacity {
  background: rgba(255, 255, 255, 0.8) !important; }

.bg-hover-white:hover {
  background: #ffffff !important; }

.font-white {
  color: #ffffff !important; }

.bg-font-white {
  color: #666 !important; }

.border-white {
  border-color: #ffffff !important; }

.border-top-white {
  border-top-color: #ffffff !important; }

.border-bottom-white {
  border-bottom-color: #ffffff !important; }

.border-left-white {
  border-left-color: #ffffff !important; }

.border-right-white {
  border-right-color: #ffffff !important; }

.bg-before-white:before,
.bg-after-white:after {
  background: #ffffff !important; }

.border-before-white:before,
.border-after-white:after {
  border-color: #ffffff !important; }

.border-top-before-white:before,
.border-top-after-white:after {
  border-top-color: #ffffff !important; }

.border-bottom-before-white:before,
.border-bottom-after-white:after {
  border-bottom-color: #ffffff !important; }

.border-left-before-white:before,
.border-left-after-white:after {
  border-left-color: #ffffff !important; }

.border-right-before-white:before,
.border-right-after-white:after {
  border-right-color: #ffffff !important; }

.bg-default {
  background: #e1e5ec !important; }

.bg-default-opacity {
  background: rgba(225, 229, 236, 0.8) !important; }

.bg-hover-default:hover {
  background: #e1e5ec !important; }

.font-default {
  color: #e1e5ec !important; }

.bg-font-default {
  color: #666 !important; }

.border-default {
  border-color: #e1e5ec !important; }

.border-top-default {
  border-top-color: #e1e5ec !important; }

.border-bottom-default {
  border-bottom-color: #e1e5ec !important; }

.border-left-default {
  border-left-color: #e1e5ec !important; }

.border-right-default {
  border-right-color: #e1e5ec !important; }

.bg-before-default:before,
.bg-after-default:after {
  background: #e1e5ec !important; }

.border-before-default:before,
.border-after-default:after {
  border-color: #e1e5ec !important; }

.border-top-before-default:before,
.border-top-after-default:after {
  border-top-color: #e1e5ec !important; }

.border-bottom-before-default:before,
.border-bottom-after-default:after {
  border-bottom-color: #e1e5ec !important; }

.border-left-before-default:before,
.border-left-after-default:after {
  border-left-color: #e1e5ec !important; }

.border-right-before-default:before,
.border-right-after-default:after {
  border-right-color: #e1e5ec !important; }

.bg-dark {
  background: #2f353b !important; }

.bg-dark-opacity {
  background: rgba(47, 53, 59, 0.8) !important; }

.bg-hover-dark:hover {
  background: #2f353b !important; }

.font-dark {
  color: #2f353b !important; }

.bg-font-dark {
  color: #FFFFFF !important; }

.border-dark {
  border-color: #2f353b !important; }

.border-top-dark {
  border-top-color: #2f353b !important; }

.border-bottom-dark {
  border-bottom-color: #2f353b !important; }

.border-left-dark {
  border-left-color: #2f353b !important; }

.border-right-dark {
  border-right-color: #2f353b !important; }

.bg-before-dark:before,
.bg-after-dark:after {
  background: #2f353b !important; }

.border-before-dark:before,
.border-after-dark:after {
  border-color: #2f353b !important; }

.border-top-before-dark:before,
.border-top-after-dark:after {
  border-top-color: #2f353b !important; }

.border-bottom-before-dark:before,
.border-bottom-after-dark:after {
  border-bottom-color: #2f353b !important; }

.border-left-before-dark:before,
.border-left-after-dark:after {
  border-left-color: #2f353b !important; }

.border-right-before-dark:before,
.border-right-after-dark:after {
  border-right-color: #2f353b !important; }

.bg-blue {
  background: #3598dc !important; }

.bg-blue-opacity {
  background: rgba(53, 152, 220, 0.8) !important; }

.bg-hover-blue:hover {
  background: #3598dc !important; }

.font-blue {
  color: #3598dc !important; }

.bg-font-blue {
  color: #FFFFFF !important; }

.border-blue {
  border-color: #3598dc !important; }

.border-top-blue {
  border-top-color: #3598dc !important; }

.border-bottom-blue {
  border-bottom-color: #3598dc !important; }

.border-left-blue {
  border-left-color: #3598dc !important; }

.border-right-blue {
  border-right-color: #3598dc !important; }

.bg-before-blue:before,
.bg-after-blue:after {
  background: #3598dc !important; }

.border-before-blue:before,
.border-after-blue:after {
  border-color: #3598dc !important; }

.border-top-before-blue:before,
.border-top-after-blue:after {
  border-top-color: #3598dc !important; }

.border-bottom-before-blue:before,
.border-bottom-after-blue:after {
  border-bottom-color: #3598dc !important; }

.border-left-before-blue:before,
.border-left-after-blue:after {
  border-left-color: #3598dc !important; }

.border-right-before-blue:before,
.border-right-after-blue:after {
  border-right-color: #3598dc !important; }

.bg-blue-madison {
  background: #578ebe !important; }

.bg-blue-madison-opacity {
  background: rgba(87, 142, 190, 0.8) !important; }

.bg-hover-blue-madison:hover {
  background: #578ebe !important; }

.font-blue-madison {
  color: #578ebe !important; }

.bg-font-blue-madison {
  color: #FFFFFF !important; }

.border-blue-madison {
  border-color: #578ebe !important; }

.border-top-blue-madison {
  border-top-color: #578ebe !important; }

.border-bottom-blue-madison {
  border-bottom-color: #578ebe !important; }

.border-left-blue-madison {
  border-left-color: #578ebe !important; }

.border-right-blue-madison {
  border-right-color: #578ebe !important; }

.bg-before-blue-madison:before,
.bg-after-blue-madison:after {
  background: #578ebe !important; }

.border-before-blue-madison:before,
.border-after-blue-madison:after {
  border-color: #578ebe !important; }

.border-top-before-blue-madison:before,
.border-top-after-blue-madison:after {
  border-top-color: #578ebe !important; }

.border-bottom-before-blue-madison:before,
.border-bottom-after-blue-madison:after {
  border-bottom-color: #578ebe !important; }

.border-left-before-blue-madison:before,
.border-left-after-blue-madison:after {
  border-left-color: #578ebe !important; }

.border-right-before-blue-madison:before,
.border-right-after-blue-madison:after {
  border-right-color: #578ebe !important; }

.bg-blue-chambray {
  background: #2C3E50 !important; }

.bg-blue-chambray-opacity {
  background: rgba(44, 62, 80, 0.8) !important; }

.bg-hover-blue-chambray:hover {
  background: #2C3E50 !important; }

.font-blue-chambray {
  color: #2C3E50 !important; }

.bg-font-blue-chambray {
  color: #FFFFFF !important; }

.border-blue-chambray {
  border-color: #2C3E50 !important; }

.border-top-blue-chambray {
  border-top-color: #2C3E50 !important; }

.border-bottom-blue-chambray {
  border-bottom-color: #2C3E50 !important; }

.border-left-blue-chambray {
  border-left-color: #2C3E50 !important; }

.border-right-blue-chambray {
  border-right-color: #2C3E50 !important; }

.bg-before-blue-chambray:before,
.bg-after-blue-chambray:after {
  background: #2C3E50 !important; }

.border-before-blue-chambray:before,
.border-after-blue-chambray:after {
  border-color: #2C3E50 !important; }

.border-top-before-blue-chambray:before,
.border-top-after-blue-chambray:after {
  border-top-color: #2C3E50 !important; }

.border-bottom-before-blue-chambray:before,
.border-bottom-after-blue-chambray:after {
  border-bottom-color: #2C3E50 !important; }

.border-left-before-blue-chambray:before,
.border-left-after-blue-chambray:after {
  border-left-color: #2C3E50 !important; }

.border-right-before-blue-chambray:before,
.border-right-after-blue-chambray:after {
  border-right-color: #2C3E50 !important; }

.bg-blue-ebonyclay {
  background: #22313F !important; }

.bg-blue-ebonyclay-opacity {
  background: rgba(34, 49, 63, 0.8) !important; }

.bg-hover-blue-ebonyclay:hover {
  background: #22313F !important; }

.font-blue-ebonyclay {
  color: #22313F !important; }

.bg-font-blue-ebonyclay {
  color: #FFFFFF !important; }

.border-blue-ebonyclay {
  border-color: #22313F !important; }

.border-top-blue-ebonyclay {
  border-top-color: #22313F !important; }

.border-bottom-blue-ebonyclay {
  border-bottom-color: #22313F !important; }

.border-left-blue-ebonyclay {
  border-left-color: #22313F !important; }

.border-right-blue-ebonyclay {
  border-right-color: #22313F !important; }

.bg-before-blue-ebonyclay:before,
.bg-after-blue-ebonyclay:after {
  background: #22313F !important; }

.border-before-blue-ebonyclay:before,
.border-after-blue-ebonyclay:after {
  border-color: #22313F !important; }

.border-top-before-blue-ebonyclay:before,
.border-top-after-blue-ebonyclay:after {
  border-top-color: #22313F !important; }

.border-bottom-before-blue-ebonyclay:before,
.border-bottom-after-blue-ebonyclay:after {
  border-bottom-color: #22313F !important; }

.border-left-before-blue-ebonyclay:before,
.border-left-after-blue-ebonyclay:after {
  border-left-color: #22313F !important; }

.border-right-before-blue-ebonyclay:before,
.border-right-after-blue-ebonyclay:after {
  border-right-color: #22313F !important; }

.bg-blue-hoki {
  background: #67809F !important; }

.bg-blue-hoki-opacity {
  background: rgba(103, 128, 159, 0.8) !important; }

.bg-hover-blue-hoki:hover {
  background: #67809F !important; }

.font-blue-hoki {
  color: #67809F !important; }

.bg-font-blue-hoki {
  color: #FFFFFF !important; }

.border-blue-hoki {
  border-color: #67809F !important; }

.border-top-blue-hoki {
  border-top-color: #67809F !important; }

.border-bottom-blue-hoki {
  border-bottom-color: #67809F !important; }

.border-left-blue-hoki {
  border-left-color: #67809F !important; }

.border-right-blue-hoki {
  border-right-color: #67809F !important; }

.bg-before-blue-hoki:before,
.bg-after-blue-hoki:after {
  background: #67809F !important; }

.border-before-blue-hoki:before,
.border-after-blue-hoki:after {
  border-color: #67809F !important; }

.border-top-before-blue-hoki:before,
.border-top-after-blue-hoki:after {
  border-top-color: #67809F !important; }

.border-bottom-before-blue-hoki:before,
.border-bottom-after-blue-hoki:after {
  border-bottom-color: #67809F !important; }

.border-left-before-blue-hoki:before,
.border-left-after-blue-hoki:after {
  border-left-color: #67809F !important; }

.border-right-before-blue-hoki:before,
.border-right-after-blue-hoki:after {
  border-right-color: #67809F !important; }

.bg-blue-steel {
  background: #4B77BE !important; }

.bg-blue-steel-opacity {
  background: rgba(75, 119, 190, 0.8) !important; }

.bg-hover-blue-steel:hover {
  background: #4B77BE !important; }

.font-blue-steel {
  color: #4B77BE !important; }

.bg-font-blue-steel {
  color: #FFFFFF !important; }

.border-blue-steel {
  border-color: #4B77BE !important; }

.border-top-blue-steel {
  border-top-color: #4B77BE !important; }

.border-bottom-blue-steel {
  border-bottom-color: #4B77BE !important; }

.border-left-blue-steel {
  border-left-color: #4B77BE !important; }

.border-right-blue-steel {
  border-right-color: #4B77BE !important; }

.bg-before-blue-steel:before,
.bg-after-blue-steel:after {
  background: #4B77BE !important; }

.border-before-blue-steel:before,
.border-after-blue-steel:after {
  border-color: #4B77BE !important; }

.border-top-before-blue-steel:before,
.border-top-after-blue-steel:after {
  border-top-color: #4B77BE !important; }

.border-bottom-before-blue-steel:before,
.border-bottom-after-blue-steel:after {
  border-bottom-color: #4B77BE !important; }

.border-left-before-blue-steel:before,
.border-left-after-blue-steel:after {
  border-left-color: #4B77BE !important; }

.border-right-before-blue-steel:before,
.border-right-after-blue-steel:after {
  border-right-color: #4B77BE !important; }

.bg-blue-soft {
  background: #4c87b9 !important; }

.bg-blue-soft-opacity {
  background: rgba(76, 135, 185, 0.8) !important; }

.bg-hover-blue-soft:hover {
  background: #4c87b9 !important; }

.font-blue-soft {
  color: #4c87b9 !important; }

.bg-font-blue-soft {
  color: #FFFFFF !important; }

.border-blue-soft {
  border-color: #4c87b9 !important; }

.border-top-blue-soft {
  border-top-color: #4c87b9 !important; }

.border-bottom-blue-soft {
  border-bottom-color: #4c87b9 !important; }

.border-left-blue-soft {
  border-left-color: #4c87b9 !important; }

.border-right-blue-soft {
  border-right-color: #4c87b9 !important; }

.bg-before-blue-soft:before,
.bg-after-blue-soft:after {
  background: #4c87b9 !important; }

.border-before-blue-soft:before,
.border-after-blue-soft:after {
  border-color: #4c87b9 !important; }

.border-top-before-blue-soft:before,
.border-top-after-blue-soft:after {
  border-top-color: #4c87b9 !important; }

.border-bottom-before-blue-soft:before,
.border-bottom-after-blue-soft:after {
  border-bottom-color: #4c87b9 !important; }

.border-left-before-blue-soft:before,
.border-left-after-blue-soft:after {
  border-left-color: #4c87b9 !important; }

.border-right-before-blue-soft:before,
.border-right-after-blue-soft:after {
  border-right-color: #4c87b9 !important; }

.bg-blue-dark {
  background: #5e738b !important; }

.bg-blue-dark-opacity {
  background: rgba(94, 115, 139, 0.8) !important; }

.bg-hover-blue-dark:hover {
  background: #5e738b !important; }

.font-blue-dark {
  color: #5e738b !important; }

.bg-font-blue-dark {
  color: #FFFFFF !important; }

.border-blue-dark {
  border-color: #5e738b !important; }

.border-top-blue-dark {
  border-top-color: #5e738b !important; }

.border-bottom-blue-dark {
  border-bottom-color: #5e738b !important; }

.border-left-blue-dark {
  border-left-color: #5e738b !important; }

.border-right-blue-dark {
  border-right-color: #5e738b !important; }

.bg-before-blue-dark:before,
.bg-after-blue-dark:after {
  background: #5e738b !important; }

.border-before-blue-dark:before,
.border-after-blue-dark:after {
  border-color: #5e738b !important; }

.border-top-before-blue-dark:before,
.border-top-after-blue-dark:after {
  border-top-color: #5e738b !important; }

.border-bottom-before-blue-dark:before,
.border-bottom-after-blue-dark:after {
  border-bottom-color: #5e738b !important; }

.border-left-before-blue-dark:before,
.border-left-after-blue-dark:after {
  border-left-color: #5e738b !important; }

.border-right-before-blue-dark:before,
.border-right-after-blue-dark:after {
  border-right-color: #5e738b !important; }

.bg-blue-sharp {
  background: #5C9BD1 !important; }

.bg-blue-sharp-opacity {
  background: rgba(92, 155, 209, 0.8) !important; }

.bg-hover-blue-sharp:hover {
  background: #5C9BD1 !important; }

.font-blue-sharp {
  color: #5C9BD1 !important; }

.bg-font-blue-sharp {
  color: #FFFFFF !important; }

.border-blue-sharp {
  border-color: #5C9BD1 !important; }

.border-top-blue-sharp {
  border-top-color: #5C9BD1 !important; }

.border-bottom-blue-sharp {
  border-bottom-color: #5C9BD1 !important; }

.border-left-blue-sharp {
  border-left-color: #5C9BD1 !important; }

.border-right-blue-sharp {
  border-right-color: #5C9BD1 !important; }

.bg-before-blue-sharp:before,
.bg-after-blue-sharp:after {
  background: #5C9BD1 !important; }

.border-before-blue-sharp:before,
.border-after-blue-sharp:after {
  border-color: #5C9BD1 !important; }

.border-top-before-blue-sharp:before,
.border-top-after-blue-sharp:after {
  border-top-color: #5C9BD1 !important; }

.border-bottom-before-blue-sharp:before,
.border-bottom-after-blue-sharp:after {
  border-bottom-color: #5C9BD1 !important; }

.border-left-before-blue-sharp:before,
.border-left-after-blue-sharp:after {
  border-left-color: #5C9BD1 !important; }

.border-right-before-blue-sharp:before,
.border-right-after-blue-sharp:after {
  border-right-color: #5C9BD1 !important; }

.bg-blue-oleo {
  background: #94A0B2 !important; }

.bg-blue-oleo-opacity {
  background: rgba(148, 160, 178, 0.8) !important; }

.bg-hover-blue-oleo:hover {
  background: #94A0B2 !important; }

.font-blue-oleo {
  color: #94A0B2 !important; }

.bg-font-blue-oleo {
  color: #FFFFFF !important; }

.border-blue-oleo {
  border-color: #94A0B2 !important; }

.border-top-blue-oleo {
  border-top-color: #94A0B2 !important; }

.border-bottom-blue-oleo {
  border-bottom-color: #94A0B2 !important; }

.border-left-blue-oleo {
  border-left-color: #94A0B2 !important; }

.border-right-blue-oleo {
  border-right-color: #94A0B2 !important; }

.bg-before-blue-oleo:before,
.bg-after-blue-oleo:after {
  background: #94A0B2 !important; }

.border-before-blue-oleo:before,
.border-after-blue-oleo:after {
  border-color: #94A0B2 !important; }

.border-top-before-blue-oleo:before,
.border-top-after-blue-oleo:after {
  border-top-color: #94A0B2 !important; }

.border-bottom-before-blue-oleo:before,
.border-bottom-after-blue-oleo:after {
  border-bottom-color: #94A0B2 !important; }

.border-left-before-blue-oleo:before,
.border-left-after-blue-oleo:after {
  border-left-color: #94A0B2 !important; }

.border-right-before-blue-oleo:before,
.border-right-after-blue-oleo:after {
  border-right-color: #94A0B2 !important; }

.bg-green {
  background: #32c5d2 !important; }

.bg-green-opacity {
  background: rgba(50, 197, 210, 0.8) !important; }

.bg-hover-green:hover {
  background: #32c5d2 !important; }

.font-green {
  color: #32c5d2 !important; }

.bg-font-green {
  color: #FFFFFF !important; }

.border-green {
  border-color: #32c5d2 !important; }

.border-top-green {
  border-top-color: #32c5d2 !important; }

.border-bottom-green {
  border-bottom-color: #32c5d2 !important; }

.border-left-green {
  border-left-color: #32c5d2 !important; }

.border-right-green {
  border-right-color: #32c5d2 !important; }

.bg-before-green:before,
.bg-after-green:after {
  background: #32c5d2 !important; }

.border-before-green:before,
.border-after-green:after {
  border-color: #32c5d2 !important; }

.border-top-before-green:before,
.border-top-after-green:after {
  border-top-color: #32c5d2 !important; }

.border-bottom-before-green:before,
.border-bottom-after-green:after {
  border-bottom-color: #32c5d2 !important; }

.border-left-before-green:before,
.border-left-after-green:after {
  border-left-color: #32c5d2 !important; }

.border-right-before-green:before,
.border-right-after-green:after {
  border-right-color: #32c5d2 !important; }

.bg-green-meadow {
  background: #1BBC9B !important; }

.bg-green-meadow-opacity {
  background: rgba(27, 188, 155, 0.8) !important; }

.bg-hover-green-meadow:hover {
  background: #1BBC9B !important; }

.font-green-meadow {
  color: #1BBC9B !important; }

.bg-font-green-meadow {
  color: #FFFFFF !important; }

.border-green-meadow {
  border-color: #1BBC9B !important; }

.border-top-green-meadow {
  border-top-color: #1BBC9B !important; }

.border-bottom-green-meadow {
  border-bottom-color: #1BBC9B !important; }

.border-left-green-meadow {
  border-left-color: #1BBC9B !important; }

.border-right-green-meadow {
  border-right-color: #1BBC9B !important; }

.bg-before-green-meadow:before,
.bg-after-green-meadow:after {
  background: #1BBC9B !important; }

.border-before-green-meadow:before,
.border-after-green-meadow:after {
  border-color: #1BBC9B !important; }

.border-top-before-green-meadow:before,
.border-top-after-green-meadow:after {
  border-top-color: #1BBC9B !important; }

.border-bottom-before-green-meadow:before,
.border-bottom-after-green-meadow:after {
  border-bottom-color: #1BBC9B !important; }

.border-left-before-green-meadow:before,
.border-left-after-green-meadow:after {
  border-left-color: #1BBC9B !important; }

.border-right-before-green-meadow:before,
.border-right-after-green-meadow:after {
  border-right-color: #1BBC9B !important; }

.bg-green-seagreen {
  background: #1BA39C !important; }

.bg-green-seagreen-opacity {
  background: rgba(27, 163, 156, 0.8) !important; }

.bg-hover-green-seagreen:hover {
  background: #1BA39C !important; }

.font-green-seagreen {
  color: #1BA39C !important; }

.bg-font-green-seagreen {
  color: #FFFFFF !important; }

.border-green-seagreen {
  border-color: #1BA39C !important; }

.border-top-green-seagreen {
  border-top-color: #1BA39C !important; }

.border-bottom-green-seagreen {
  border-bottom-color: #1BA39C !important; }

.border-left-green-seagreen {
  border-left-color: #1BA39C !important; }

.border-right-green-seagreen {
  border-right-color: #1BA39C !important; }

.bg-before-green-seagreen:before,
.bg-after-green-seagreen:after {
  background: #1BA39C !important; }

.border-before-green-seagreen:before,
.border-after-green-seagreen:after {
  border-color: #1BA39C !important; }

.border-top-before-green-seagreen:before,
.border-top-after-green-seagreen:after {
  border-top-color: #1BA39C !important; }

.border-bottom-before-green-seagreen:before,
.border-bottom-after-green-seagreen:after {
  border-bottom-color: #1BA39C !important; }

.border-left-before-green-seagreen:before,
.border-left-after-green-seagreen:after {
  border-left-color: #1BA39C !important; }

.border-right-before-green-seagreen:before,
.border-right-after-green-seagreen:after {
  border-right-color: #1BA39C !important; }

.bg-green-turquoise {
  background: #36D7B7 !important; }

.bg-green-turquoise-opacity {
  background: rgba(54, 215, 183, 0.8) !important; }

.bg-hover-green-turquoise:hover {
  background: #36D7B7 !important; }

.font-green-turquoise {
  color: #36D7B7 !important; }

.bg-font-green-turquoise {
  color: #FFFFFF !important; }

.border-green-turquoise {
  border-color: #36D7B7 !important; }

.border-top-green-turquoise {
  border-top-color: #36D7B7 !important; }

.border-bottom-green-turquoise {
  border-bottom-color: #36D7B7 !important; }

.border-left-green-turquoise {
  border-left-color: #36D7B7 !important; }

.border-right-green-turquoise {
  border-right-color: #36D7B7 !important; }

.bg-before-green-turquoise:before,
.bg-after-green-turquoise:after {
  background: #36D7B7 !important; }

.border-before-green-turquoise:before,
.border-after-green-turquoise:after {
  border-color: #36D7B7 !important; }

.border-top-before-green-turquoise:before,
.border-top-after-green-turquoise:after {
  border-top-color: #36D7B7 !important; }

.border-bottom-before-green-turquoise:before,
.border-bottom-after-green-turquoise:after {
  border-bottom-color: #36D7B7 !important; }

.border-left-before-green-turquoise:before,
.border-left-after-green-turquoise:after {
  border-left-color: #36D7B7 !important; }

.border-right-before-green-turquoise:before,
.border-right-after-green-turquoise:after {
  border-right-color: #36D7B7 !important; }

.bg-green-haze {
  background: #44b6ae !important; }

.bg-green-haze-opacity {
  background: rgba(68, 182, 174, 0.8) !important; }

.bg-hover-green-haze:hover {
  background: #44b6ae !important; }

.font-green-haze {
  color: #44b6ae !important; }

.bg-font-green-haze {
  color: #FFFFFF !important; }

.border-green-haze {
  border-color: #44b6ae !important; }

.border-top-green-haze {
  border-top-color: #44b6ae !important; }

.border-bottom-green-haze {
  border-bottom-color: #44b6ae !important; }

.border-left-green-haze {
  border-left-color: #44b6ae !important; }

.border-right-green-haze {
  border-right-color: #44b6ae !important; }

.bg-before-green-haze:before,
.bg-after-green-haze:after {
  background: #44b6ae !important; }

.border-before-green-haze:before,
.border-after-green-haze:after {
  border-color: #44b6ae !important; }

.border-top-before-green-haze:before,
.border-top-after-green-haze:after {
  border-top-color: #44b6ae !important; }

.border-bottom-before-green-haze:before,
.border-bottom-after-green-haze:after {
  border-bottom-color: #44b6ae !important; }

.border-left-before-green-haze:before,
.border-left-after-green-haze:after {
  border-left-color: #44b6ae !important; }

.border-right-before-green-haze:before,
.border-right-after-green-haze:after {
  border-right-color: #44b6ae !important; }

.bg-green-jungle {
  background: #26C281 !important; }

.bg-green-jungle-opacity {
  background: rgba(38, 194, 129, 0.8) !important; }

.bg-hover-green-jungle:hover {
  background: #26C281 !important; }

.font-green-jungle {
  color: #26C281 !important; }

.bg-font-green-jungle {
  color: #FFFFFF !important; }

.border-green-jungle {
  border-color: #26C281 !important; }

.border-top-green-jungle {
  border-top-color: #26C281 !important; }

.border-bottom-green-jungle {
  border-bottom-color: #26C281 !important; }

.border-left-green-jungle {
  border-left-color: #26C281 !important; }

.border-right-green-jungle {
  border-right-color: #26C281 !important; }

.bg-before-green-jungle:before,
.bg-after-green-jungle:after {
  background: #26C281 !important; }

.border-before-green-jungle:before,
.border-after-green-jungle:after {
  border-color: #26C281 !important; }

.border-top-before-green-jungle:before,
.border-top-after-green-jungle:after {
  border-top-color: #26C281 !important; }

.border-bottom-before-green-jungle:before,
.border-bottom-after-green-jungle:after {
  border-bottom-color: #26C281 !important; }

.border-left-before-green-jungle:before,
.border-left-after-green-jungle:after {
  border-left-color: #26C281 !important; }

.border-right-before-green-jungle:before,
.border-right-after-green-jungle:after {
  border-right-color: #26C281 !important; }

.bg-green-soft {
  background: #3faba4 !important; }

.bg-green-soft-opacity {
  background: rgba(63, 171, 164, 0.8) !important; }

.bg-hover-green-soft:hover {
  background: #3faba4 !important; }

.font-green-soft {
  color: #3faba4 !important; }

.bg-font-green-soft {
  color: #FFFFFF !important; }

.border-green-soft {
  border-color: #3faba4 !important; }

.border-top-green-soft {
  border-top-color: #3faba4 !important; }

.border-bottom-green-soft {
  border-bottom-color: #3faba4 !important; }

.border-left-green-soft {
  border-left-color: #3faba4 !important; }

.border-right-green-soft {
  border-right-color: #3faba4 !important; }

.bg-before-green-soft:before,
.bg-after-green-soft:after {
  background: #3faba4 !important; }

.border-before-green-soft:before,
.border-after-green-soft:after {
  border-color: #3faba4 !important; }

.border-top-before-green-soft:before,
.border-top-after-green-soft:after {
  border-top-color: #3faba4 !important; }

.border-bottom-before-green-soft:before,
.border-bottom-after-green-soft:after {
  border-bottom-color: #3faba4 !important; }

.border-left-before-green-soft:before,
.border-left-after-green-soft:after {
  border-left-color: #3faba4 !important; }

.border-right-before-green-soft:before,
.border-right-after-green-soft:after {
  border-right-color: #3faba4 !important; }

.bg-green-dark {
  background: #4DB3A2 !important; }

.bg-green-dark-opacity {
  background: rgba(77, 179, 162, 0.8) !important; }

.bg-hover-green-dark:hover {
  background: #4DB3A2 !important; }

.font-green-dark {
  color: #4DB3A2 !important; }

.bg-font-green-dark {
  color: #FFFFFF !important; }

.border-green-dark {
  border-color: #4DB3A2 !important; }

.border-top-green-dark {
  border-top-color: #4DB3A2 !important; }

.border-bottom-green-dark {
  border-bottom-color: #4DB3A2 !important; }

.border-left-green-dark {
  border-left-color: #4DB3A2 !important; }

.border-right-green-dark {
  border-right-color: #4DB3A2 !important; }

.bg-before-green-dark:before,
.bg-after-green-dark:after {
  background: #4DB3A2 !important; }

.border-before-green-dark:before,
.border-after-green-dark:after {
  border-color: #4DB3A2 !important; }

.border-top-before-green-dark:before,
.border-top-after-green-dark:after {
  border-top-color: #4DB3A2 !important; }

.border-bottom-before-green-dark:before,
.border-bottom-after-green-dark:after {
  border-bottom-color: #4DB3A2 !important; }

.border-left-before-green-dark:before,
.border-left-after-green-dark:after {
  border-left-color: #4DB3A2 !important; }

.border-right-before-green-dark:before,
.border-right-after-green-dark:after {
  border-right-color: #4DB3A2 !important; }

.bg-green-sharp {
  background: #2ab4c0 !important; }

.bg-green-sharp-opacity {
  background: rgba(42, 180, 192, 0.8) !important; }

.bg-hover-green-sharp:hover {
  background: #2ab4c0 !important; }

.font-green-sharp {
  color: #2ab4c0 !important; }

.bg-font-green-sharp {
  color: #FFFFFF !important; }

.border-green-sharp {
  border-color: #2ab4c0 !important; }

.border-top-green-sharp {
  border-top-color: #2ab4c0 !important; }

.border-bottom-green-sharp {
  border-bottom-color: #2ab4c0 !important; }

.border-left-green-sharp {
  border-left-color: #2ab4c0 !important; }

.border-right-green-sharp {
  border-right-color: #2ab4c0 !important; }

.bg-before-green-sharp:before,
.bg-after-green-sharp:after {
  background: #2ab4c0 !important; }

.border-before-green-sharp:before,
.border-after-green-sharp:after {
  border-color: #2ab4c0 !important; }

.border-top-before-green-sharp:before,
.border-top-after-green-sharp:after {
  border-top-color: #2ab4c0 !important; }

.border-bottom-before-green-sharp:before,
.border-bottom-after-green-sharp:after {
  border-bottom-color: #2ab4c0 !important; }

.border-left-before-green-sharp:before,
.border-left-after-green-sharp:after {
  border-left-color: #2ab4c0 !important; }

.border-right-before-green-sharp:before,
.border-right-after-green-sharp:after {
  border-right-color: #2ab4c0 !important; }

.bg-green-steel {
  background: #29b4b6 !important; }

.bg-green-steel-opacity {
  background: rgba(41, 180, 182, 0.8) !important; }

.bg-hover-green-steel:hover {
  background: #29b4b6 !important; }

.font-green-steel {
  color: #29b4b6 !important; }

.bg-font-green-steel {
  color: #FFFFFF !important; }

.border-green-steel {
  border-color: #29b4b6 !important; }

.border-top-green-steel {
  border-top-color: #29b4b6 !important; }

.border-bottom-green-steel {
  border-bottom-color: #29b4b6 !important; }

.border-left-green-steel {
  border-left-color: #29b4b6 !important; }

.border-right-green-steel {
  border-right-color: #29b4b6 !important; }

.bg-before-green-steel:before,
.bg-after-green-steel:after {
  background: #29b4b6 !important; }

.border-before-green-steel:before,
.border-after-green-steel:after {
  border-color: #29b4b6 !important; }

.border-top-before-green-steel:before,
.border-top-after-green-steel:after {
  border-top-color: #29b4b6 !important; }

.border-bottom-before-green-steel:before,
.border-bottom-after-green-steel:after {
  border-bottom-color: #29b4b6 !important; }

.border-left-before-green-steel:before,
.border-left-after-green-steel:after {
  border-left-color: #29b4b6 !important; }

.border-right-before-green-steel:before,
.border-right-after-green-steel:after {
  border-right-color: #29b4b6 !important; }

.bg-grey {
  background: #E5E5E5 !important; }

.bg-grey-opacity {
  background: rgba(229, 229, 229, 0.8) !important; }

.bg-hover-grey:hover {
  background: #E5E5E5 !important; }

.font-grey {
  color: #E5E5E5 !important; }

.bg-font-grey {
  color: #333333 !important; }

.border-grey {
  border-color: #E5E5E5 !important; }

.border-top-grey {
  border-top-color: #E5E5E5 !important; }

.border-bottom-grey {
  border-bottom-color: #E5E5E5 !important; }

.border-left-grey {
  border-left-color: #E5E5E5 !important; }

.border-right-grey {
  border-right-color: #E5E5E5 !important; }

.bg-before-grey:before,
.bg-after-grey:after {
  background: #E5E5E5 !important; }

.border-before-grey:before,
.border-after-grey:after {
  border-color: #E5E5E5 !important; }

.border-top-before-grey:before,
.border-top-after-grey:after {
  border-top-color: #E5E5E5 !important; }

.border-bottom-before-grey:before,
.border-bottom-after-grey:after {
  border-bottom-color: #E5E5E5 !important; }

.border-left-before-grey:before,
.border-left-after-grey:after {
  border-left-color: #E5E5E5 !important; }

.border-right-before-grey:before,
.border-right-after-grey:after {
  border-right-color: #E5E5E5 !important; }

.bg-grey-steel {
  background: #e9edef !important; }

.bg-grey-steel-opacity {
  background: rgba(233, 237, 239, 0.8) !important; }

.bg-hover-grey-steel:hover {
  background: #e9edef !important; }

.font-grey-steel {
  color: #e9edef !important; }

.bg-font-grey-steel {
  color: #80898e !important; }

.border-grey-steel {
  border-color: #e9edef !important; }

.border-top-grey-steel {
  border-top-color: #e9edef !important; }

.border-bottom-grey-steel {
  border-bottom-color: #e9edef !important; }

.border-left-grey-steel {
  border-left-color: #e9edef !important; }

.border-right-grey-steel {
  border-right-color: #e9edef !important; }

.bg-before-grey-steel:before,
.bg-after-grey-steel:after {
  background: #e9edef !important; }

.border-before-grey-steel:before,
.border-after-grey-steel:after {
  border-color: #e9edef !important; }

.border-top-before-grey-steel:before,
.border-top-after-grey-steel:after {
  border-top-color: #e9edef !important; }

.border-bottom-before-grey-steel:before,
.border-bottom-after-grey-steel:after {
  border-bottom-color: #e9edef !important; }

.border-left-before-grey-steel:before,
.border-left-after-grey-steel:after {
  border-left-color: #e9edef !important; }

.border-right-before-grey-steel:before,
.border-right-after-grey-steel:after {
  border-right-color: #e9edef !important; }

.bg-grey-cararra {
  background: #fafafa !important; }

.bg-grey-cararra-opacity {
  background: rgba(250, 250, 250, 0.8) !important; }

.bg-hover-grey-cararra:hover {
  background: #fafafa !important; }

.font-grey-cararra {
  color: #fafafa !important; }

.bg-font-grey-cararra {
  color: #333333 !important; }

.border-grey-cararra {
  border-color: #fafafa !important; }

.border-top-grey-cararra {
  border-top-color: #fafafa !important; }

.border-bottom-grey-cararra {
  border-bottom-color: #fafafa !important; }

.border-left-grey-cararra {
  border-left-color: #fafafa !important; }

.border-right-grey-cararra {
  border-right-color: #fafafa !important; }

.bg-before-grey-cararra:before,
.bg-after-grey-cararra:after {
  background: #fafafa !important; }

.border-before-grey-cararra:before,
.border-after-grey-cararra:after {
  border-color: #fafafa !important; }

.border-top-before-grey-cararra:before,
.border-top-after-grey-cararra:after {
  border-top-color: #fafafa !important; }

.border-bottom-before-grey-cararra:before,
.border-bottom-after-grey-cararra:after {
  border-bottom-color: #fafafa !important; }

.border-left-before-grey-cararra:before,
.border-left-after-grey-cararra:after {
  border-left-color: #fafafa !important; }

.border-right-before-grey-cararra:before,
.border-right-after-grey-cararra:after {
  border-right-color: #fafafa !important; }

.bg-grey-gallery {
  background: #555555 !important; }

.bg-grey-gallery-opacity {
  background: rgba(85, 85, 85, 0.8) !important; }

.bg-hover-grey-gallery:hover {
  background: #555555 !important; }

.font-grey-gallery {
  color: #555555 !important; }

.bg-font-grey-gallery {
  color: #ffffff !important; }

.border-grey-gallery {
  border-color: #555555 !important; }

.border-top-grey-gallery {
  border-top-color: #555555 !important; }

.border-bottom-grey-gallery {
  border-bottom-color: #555555 !important; }

.border-left-grey-gallery {
  border-left-color: #555555 !important; }

.border-right-grey-gallery {
  border-right-color: #555555 !important; }

.bg-before-grey-gallery:before,
.bg-after-grey-gallery:after {
  background: #555555 !important; }

.border-before-grey-gallery:before,
.border-after-grey-gallery:after {
  border-color: #555555 !important; }

.border-top-before-grey-gallery:before,
.border-top-after-grey-gallery:after {
  border-top-color: #555555 !important; }

.border-bottom-before-grey-gallery:before,
.border-bottom-after-grey-gallery:after {
  border-bottom-color: #555555 !important; }

.border-left-before-grey-gallery:before,
.border-left-after-grey-gallery:after {
  border-left-color: #555555 !important; }

.border-right-before-grey-gallery:before,
.border-right-after-grey-gallery:after {
  border-right-color: #555555 !important; }

.bg-grey-cascade {
  background: #95A5A6 !important; }

.bg-grey-cascade-opacity {
  background: rgba(149, 165, 166, 0.8) !important; }

.bg-hover-grey-cascade:hover {
  background: #95A5A6 !important; }

.font-grey-cascade {
  color: #95A5A6 !important; }

.bg-font-grey-cascade {
  color: #FFFFFF !important; }

.border-grey-cascade {
  border-color: #95A5A6 !important; }

.border-top-grey-cascade {
  border-top-color: #95A5A6 !important; }

.border-bottom-grey-cascade {
  border-bottom-color: #95A5A6 !important; }

.border-left-grey-cascade {
  border-left-color: #95A5A6 !important; }

.border-right-grey-cascade {
  border-right-color: #95A5A6 !important; }

.bg-before-grey-cascade:before,
.bg-after-grey-cascade:after {
  background: #95A5A6 !important; }

.border-before-grey-cascade:before,
.border-after-grey-cascade:after {
  border-color: #95A5A6 !important; }

.border-top-before-grey-cascade:before,
.border-top-after-grey-cascade:after {
  border-top-color: #95A5A6 !important; }

.border-bottom-before-grey-cascade:before,
.border-bottom-after-grey-cascade:after {
  border-bottom-color: #95A5A6 !important; }

.border-left-before-grey-cascade:before,
.border-left-after-grey-cascade:after {
  border-left-color: #95A5A6 !important; }

.border-right-before-grey-cascade:before,
.border-right-after-grey-cascade:after {
  border-right-color: #95A5A6 !important; }

.bg-grey-silver {
  background: #BFBFBF !important; }

.bg-grey-silver-opacity {
  background: rgba(191, 191, 191, 0.8) !important; }

.bg-hover-grey-silver:hover {
  background: #BFBFBF !important; }

.font-grey-silver {
  color: #BFBFBF !important; }

.bg-font-grey-silver {
  color: #FAFCFB !important; }

.border-grey-silver {
  border-color: #BFBFBF !important; }

.border-top-grey-silver {
  border-top-color: #BFBFBF !important; }

.border-bottom-grey-silver {
  border-bottom-color: #BFBFBF !important; }

.border-left-grey-silver {
  border-left-color: #BFBFBF !important; }

.border-right-grey-silver {
  border-right-color: #BFBFBF !important; }

.bg-before-grey-silver:before,
.bg-after-grey-silver:after {
  background: #BFBFBF !important; }

.border-before-grey-silver:before,
.border-after-grey-silver:after {
  border-color: #BFBFBF !important; }

.border-top-before-grey-silver:before,
.border-top-after-grey-silver:after {
  border-top-color: #BFBFBF !important; }

.border-bottom-before-grey-silver:before,
.border-bottom-after-grey-silver:after {
  border-bottom-color: #BFBFBF !important; }

.border-left-before-grey-silver:before,
.border-left-after-grey-silver:after {
  border-left-color: #BFBFBF !important; }

.border-right-before-grey-silver:before,
.border-right-after-grey-silver:after {
  border-right-color: #BFBFBF !important; }

.bg-grey-salsa {
  background: #ACB5C3 !important; }

.bg-grey-salsa-opacity {
  background: rgba(172, 181, 195, 0.8) !important; }

.bg-hover-grey-salsa:hover {
  background: #ACB5C3 !important; }

.font-grey-salsa {
  color: #ACB5C3 !important; }

.bg-font-grey-salsa {
  color: #FAFCFB !important; }

.border-grey-salsa {
  border-color: #ACB5C3 !important; }

.border-top-grey-salsa {
  border-top-color: #ACB5C3 !important; }

.border-bottom-grey-salsa {
  border-bottom-color: #ACB5C3 !important; }

.border-left-grey-salsa {
  border-left-color: #ACB5C3 !important; }

.border-right-grey-salsa {
  border-right-color: #ACB5C3 !important; }

.bg-before-grey-salsa:before,
.bg-after-grey-salsa:after {
  background: #ACB5C3 !important; }

.border-before-grey-salsa:before,
.border-after-grey-salsa:after {
  border-color: #ACB5C3 !important; }

.border-top-before-grey-salsa:before,
.border-top-after-grey-salsa:after {
  border-top-color: #ACB5C3 !important; }

.border-bottom-before-grey-salsa:before,
.border-bottom-after-grey-salsa:after {
  border-bottom-color: #ACB5C3 !important; }

.border-left-before-grey-salsa:before,
.border-left-after-grey-salsa:after {
  border-left-color: #ACB5C3 !important; }

.border-right-before-grey-salsa:before,
.border-right-after-grey-salsa:after {
  border-right-color: #ACB5C3 !important; }

.bg-grey-salt {
  background: #bfcad1 !important; }

.bg-grey-salt-opacity {
  background: rgba(191, 202, 209, 0.8) !important; }

.bg-hover-grey-salt:hover {
  background: #bfcad1 !important; }

.font-grey-salt {
  color: #bfcad1 !important; }

.bg-font-grey-salt {
  color: #FAFCFB !important; }

.border-grey-salt {
  border-color: #bfcad1 !important; }

.border-top-grey-salt {
  border-top-color: #bfcad1 !important; }

.border-bottom-grey-salt {
  border-bottom-color: #bfcad1 !important; }

.border-left-grey-salt {
  border-left-color: #bfcad1 !important; }

.border-right-grey-salt {
  border-right-color: #bfcad1 !important; }

.bg-before-grey-salt:before,
.bg-after-grey-salt:after {
  background: #bfcad1 !important; }

.border-before-grey-salt:before,
.border-after-grey-salt:after {
  border-color: #bfcad1 !important; }

.border-top-before-grey-salt:before,
.border-top-after-grey-salt:after {
  border-top-color: #bfcad1 !important; }

.border-bottom-before-grey-salt:before,
.border-bottom-after-grey-salt:after {
  border-bottom-color: #bfcad1 !important; }

.border-left-before-grey-salt:before,
.border-left-after-grey-salt:after {
  border-left-color: #bfcad1 !important; }

.border-right-before-grey-salt:before,
.border-right-after-grey-salt:after {
  border-right-color: #bfcad1 !important; }

.bg-grey-mint {
  background: #525e64 !important; }

.bg-grey-mint-opacity {
  background: rgba(82, 94, 100, 0.8) !important; }

.bg-hover-grey-mint:hover {
  background: #525e64 !important; }

.font-grey-mint {
  color: #525e64 !important; }

.bg-font-grey-mint {
  color: #FFFFFF !important; }

.border-grey-mint {
  border-color: #525e64 !important; }

.border-top-grey-mint {
  border-top-color: #525e64 !important; }

.border-bottom-grey-mint {
  border-bottom-color: #525e64 !important; }

.border-left-grey-mint {
  border-left-color: #525e64 !important; }

.border-right-grey-mint {
  border-right-color: #525e64 !important; }

.bg-before-grey-mint:before,
.bg-after-grey-mint:after {
  background: #525e64 !important; }

.border-before-grey-mint:before,
.border-after-grey-mint:after {
  border-color: #525e64 !important; }

.border-top-before-grey-mint:before,
.border-top-after-grey-mint:after {
  border-top-color: #525e64 !important; }

.border-bottom-before-grey-mint:before,
.border-bottom-after-grey-mint:after {
  border-bottom-color: #525e64 !important; }

.border-left-before-grey-mint:before,
.border-left-after-grey-mint:after {
  border-left-color: #525e64 !important; }

.border-right-before-grey-mint:before,
.border-right-after-grey-mint:after {
  border-right-color: #525e64 !important; }

.bg-red {
  background: #e7505a !important; }

.bg-red-opacity {
  background: rgba(231, 80, 90, 0.8) !important; }

.bg-hover-red:hover {
  background: #e7505a !important; }

.font-red {
  color: #e7505a !important; }

.bg-font-red {
  color: #ffffff !important; }

.border-red {
  border-color: #e7505a !important; }

.border-top-red {
  border-top-color: #e7505a !important; }

.border-bottom-red {
  border-bottom-color: #e7505a !important; }

.border-left-red {
  border-left-color: #e7505a !important; }

.border-right-red {
  border-right-color: #e7505a !important; }

.bg-before-red:before,
.bg-after-red:after {
  background: #e7505a !important; }

.border-before-red:before,
.border-after-red:after {
  border-color: #e7505a !important; }

.border-top-before-red:before,
.border-top-after-red:after {
  border-top-color: #e7505a !important; }

.border-bottom-before-red:before,
.border-bottom-after-red:after {
  border-bottom-color: #e7505a !important; }

.border-left-before-red:before,
.border-left-after-red:after {
  border-left-color: #e7505a !important; }

.border-right-before-red:before,
.border-right-after-red:after {
  border-right-color: #e7505a !important; }

.bg-red-pink {
  background: #E08283 !important; }

.bg-red-pink-opacity {
  background: rgba(224, 130, 131, 0.8) !important; }

.bg-hover-red-pink:hover {
  background: #E08283 !important; }

.font-red-pink {
  color: #E08283 !important; }

.bg-font-red-pink {
  color: #ffffff !important; }

.border-red-pink {
  border-color: #E08283 !important; }

.border-top-red-pink {
  border-top-color: #E08283 !important; }

.border-bottom-red-pink {
  border-bottom-color: #E08283 !important; }

.border-left-red-pink {
  border-left-color: #E08283 !important; }

.border-right-red-pink {
  border-right-color: #E08283 !important; }

.bg-before-red-pink:before,
.bg-after-red-pink:after {
  background: #E08283 !important; }

.border-before-red-pink:before,
.border-after-red-pink:after {
  border-color: #E08283 !important; }

.border-top-before-red-pink:before,
.border-top-after-red-pink:after {
  border-top-color: #E08283 !important; }

.border-bottom-before-red-pink:before,
.border-bottom-after-red-pink:after {
  border-bottom-color: #E08283 !important; }

.border-left-before-red-pink:before,
.border-left-after-red-pink:after {
  border-left-color: #E08283 !important; }

.border-right-before-red-pink:before,
.border-right-after-red-pink:after {
  border-right-color: #E08283 !important; }

.bg-red-sunglo {
  background: #E26A6A !important; }

.bg-red-sunglo-opacity {
  background: rgba(226, 106, 106, 0.8) !important; }

.bg-hover-red-sunglo:hover {
  background: #E26A6A !important; }

.font-red-sunglo {
  color: #E26A6A !important; }

.bg-font-red-sunglo {
  color: #ffffff !important; }

.border-red-sunglo {
  border-color: #E26A6A !important; }

.border-top-red-sunglo {
  border-top-color: #E26A6A !important; }

.border-bottom-red-sunglo {
  border-bottom-color: #E26A6A !important; }

.border-left-red-sunglo {
  border-left-color: #E26A6A !important; }

.border-right-red-sunglo {
  border-right-color: #E26A6A !important; }

.bg-before-red-sunglo:before,
.bg-after-red-sunglo:after {
  background: #E26A6A !important; }

.border-before-red-sunglo:before,
.border-after-red-sunglo:after {
  border-color: #E26A6A !important; }

.border-top-before-red-sunglo:before,
.border-top-after-red-sunglo:after {
  border-top-color: #E26A6A !important; }

.border-bottom-before-red-sunglo:before,
.border-bottom-after-red-sunglo:after {
  border-bottom-color: #E26A6A !important; }

.border-left-before-red-sunglo:before,
.border-left-after-red-sunglo:after {
  border-left-color: #E26A6A !important; }

.border-right-before-red-sunglo:before,
.border-right-after-red-sunglo:after {
  border-right-color: #E26A6A !important; }

.bg-red-intense {
  background: #e35b5a !important; }

.bg-red-intense-opacity {
  background: rgba(227, 91, 90, 0.8) !important; }

.bg-hover-red-intense:hover {
  background: #e35b5a !important; }

.font-red-intense {
  color: #e35b5a !important; }

.bg-font-red-intense {
  color: #ffffff !important; }

.border-red-intense {
  border-color: #e35b5a !important; }

.border-top-red-intense {
  border-top-color: #e35b5a !important; }

.border-bottom-red-intense {
  border-bottom-color: #e35b5a !important; }

.border-left-red-intense {
  border-left-color: #e35b5a !important; }

.border-right-red-intense {
  border-right-color: #e35b5a !important; }

.bg-before-red-intense:before,
.bg-after-red-intense:after {
  background: #e35b5a !important; }

.border-before-red-intense:before,
.border-after-red-intense:after {
  border-color: #e35b5a !important; }

.border-top-before-red-intense:before,
.border-top-after-red-intense:after {
  border-top-color: #e35b5a !important; }

.border-bottom-before-red-intense:before,
.border-bottom-after-red-intense:after {
  border-bottom-color: #e35b5a !important; }

.border-left-before-red-intense:before,
.border-left-after-red-intense:after {
  border-left-color: #e35b5a !important; }

.border-right-before-red-intense:before,
.border-right-after-red-intense:after {
  border-right-color: #e35b5a !important; }

.bg-red-thunderbird {
  background: #D91E18 !important; }

.bg-red-thunderbird-opacity {
  background: rgba(217, 30, 24, 0.8) !important; }

.bg-hover-red-thunderbird:hover {
  background: #D91E18 !important; }

.font-red-thunderbird {
  color: #D91E18 !important; }

.bg-font-red-thunderbird {
  color: #ffffff !important; }

.border-red-thunderbird {
  border-color: #D91E18 !important; }

.border-top-red-thunderbird {
  border-top-color: #D91E18 !important; }

.border-bottom-red-thunderbird {
  border-bottom-color: #D91E18 !important; }

.border-left-red-thunderbird {
  border-left-color: #D91E18 !important; }

.border-right-red-thunderbird {
  border-right-color: #D91E18 !important; }

.bg-before-red-thunderbird:before,
.bg-after-red-thunderbird:after {
  background: #D91E18 !important; }

.border-before-red-thunderbird:before,
.border-after-red-thunderbird:after {
  border-color: #D91E18 !important; }

.border-top-before-red-thunderbird:before,
.border-top-after-red-thunderbird:after {
  border-top-color: #D91E18 !important; }

.border-bottom-before-red-thunderbird:before,
.border-bottom-after-red-thunderbird:after {
  border-bottom-color: #D91E18 !important; }

.border-left-before-red-thunderbird:before,
.border-left-after-red-thunderbird:after {
  border-left-color: #D91E18 !important; }

.border-right-before-red-thunderbird:before,
.border-right-after-red-thunderbird:after {
  border-right-color: #D91E18 !important; }

.bg-red-flamingo {
  background: #EF4836 !important; }

.bg-red-flamingo-opacity {
  background: rgba(239, 72, 54, 0.8) !important; }

.bg-hover-red-flamingo:hover {
  background: #EF4836 !important; }

.font-red-flamingo {
  color: #EF4836 !important; }

.bg-font-red-flamingo {
  color: #ffffff !important; }

.border-red-flamingo {
  border-color: #EF4836 !important; }

.border-top-red-flamingo {
  border-top-color: #EF4836 !important; }

.border-bottom-red-flamingo {
  border-bottom-color: #EF4836 !important; }

.border-left-red-flamingo {
  border-left-color: #EF4836 !important; }

.border-right-red-flamingo {
  border-right-color: #EF4836 !important; }

.bg-before-red-flamingo:before,
.bg-after-red-flamingo:after {
  background: #EF4836 !important; }

.border-before-red-flamingo:before,
.border-after-red-flamingo:after {
  border-color: #EF4836 !important; }

.border-top-before-red-flamingo:before,
.border-top-after-red-flamingo:after {
  border-top-color: #EF4836 !important; }

.border-bottom-before-red-flamingo:before,
.border-bottom-after-red-flamingo:after {
  border-bottom-color: #EF4836 !important; }

.border-left-before-red-flamingo:before,
.border-left-after-red-flamingo:after {
  border-left-color: #EF4836 !important; }

.border-right-before-red-flamingo:before,
.border-right-after-red-flamingo:after {
  border-right-color: #EF4836 !important; }

.bg-red-soft {
  background: #d05454 !important; }

.bg-red-soft-opacity {
  background: rgba(208, 84, 84, 0.8) !important; }

.bg-hover-red-soft:hover {
  background: #d05454 !important; }

.font-red-soft {
  color: #d05454 !important; }

.bg-font-red-soft {
  color: #ffffff !important; }

.border-red-soft {
  border-color: #d05454 !important; }

.border-top-red-soft {
  border-top-color: #d05454 !important; }

.border-bottom-red-soft {
  border-bottom-color: #d05454 !important; }

.border-left-red-soft {
  border-left-color: #d05454 !important; }

.border-right-red-soft {
  border-right-color: #d05454 !important; }

.bg-before-red-soft:before,
.bg-after-red-soft:after {
  background: #d05454 !important; }

.border-before-red-soft:before,
.border-after-red-soft:after {
  border-color: #d05454 !important; }

.border-top-before-red-soft:before,
.border-top-after-red-soft:after {
  border-top-color: #d05454 !important; }

.border-bottom-before-red-soft:before,
.border-bottom-after-red-soft:after {
  border-bottom-color: #d05454 !important; }

.border-left-before-red-soft:before,
.border-left-after-red-soft:after {
  border-left-color: #d05454 !important; }

.border-right-before-red-soft:before,
.border-right-after-red-soft:after {
  border-right-color: #d05454 !important; }

.bg-red-haze {
  background: #f36a5a !important; }

.bg-red-haze-opacity {
  background: rgba(243, 106, 90, 0.8) !important; }

.bg-hover-red-haze:hover {
  background: #f36a5a !important; }

.font-red-haze {
  color: #f36a5a !important; }

.bg-font-red-haze {
  color: #ffffff !important; }

.border-red-haze {
  border-color: #f36a5a !important; }

.border-top-red-haze {
  border-top-color: #f36a5a !important; }

.border-bottom-red-haze {
  border-bottom-color: #f36a5a !important; }

.border-left-red-haze {
  border-left-color: #f36a5a !important; }

.border-right-red-haze {
  border-right-color: #f36a5a !important; }

.bg-before-red-haze:before,
.bg-after-red-haze:after {
  background: #f36a5a !important; }

.border-before-red-haze:before,
.border-after-red-haze:after {
  border-color: #f36a5a !important; }

.border-top-before-red-haze:before,
.border-top-after-red-haze:after {
  border-top-color: #f36a5a !important; }

.border-bottom-before-red-haze:before,
.border-bottom-after-red-haze:after {
  border-bottom-color: #f36a5a !important; }

.border-left-before-red-haze:before,
.border-left-after-red-haze:after {
  border-left-color: #f36a5a !important; }

.border-right-before-red-haze:before,
.border-right-after-red-haze:after {
  border-right-color: #f36a5a !important; }

.bg-red-mint {
  background: #e43a45 !important; }

.bg-red-mint-opacity {
  background: rgba(228, 58, 69, 0.8) !important; }

.bg-hover-red-mint:hover {
  background: #e43a45 !important; }

.font-red-mint {
  color: #e43a45 !important; }

.bg-font-red-mint {
  color: #ffffff !important; }

.border-red-mint {
  border-color: #e43a45 !important; }

.border-top-red-mint {
  border-top-color: #e43a45 !important; }

.border-bottom-red-mint {
  border-bottom-color: #e43a45 !important; }

.border-left-red-mint {
  border-left-color: #e43a45 !important; }

.border-right-red-mint {
  border-right-color: #e43a45 !important; }

.bg-before-red-mint:before,
.bg-after-red-mint:after {
  background: #e43a45 !important; }

.border-before-red-mint:before,
.border-after-red-mint:after {
  border-color: #e43a45 !important; }

.border-top-before-red-mint:before,
.border-top-after-red-mint:after {
  border-top-color: #e43a45 !important; }

.border-bottom-before-red-mint:before,
.border-bottom-after-red-mint:after {
  border-bottom-color: #e43a45 !important; }

.border-left-before-red-mint:before,
.border-left-after-red-mint:after {
  border-left-color: #e43a45 !important; }

.border-right-before-red-mint:before,
.border-right-after-red-mint:after {
  border-right-color: #e43a45 !important; }

.bg-yellow {
  background: #c49f47 !important; }

.bg-yellow-opacity {
  background: rgba(196, 159, 71, 0.8) !important; }

.bg-hover-yellow:hover {
  background: #c49f47 !important; }

.font-yellow {
  color: #c49f47 !important; }

.bg-font-yellow {
  color: #ffffff !important; }

.border-yellow {
  border-color: #c49f47 !important; }

.border-top-yellow {
  border-top-color: #c49f47 !important; }

.border-bottom-yellow {
  border-bottom-color: #c49f47 !important; }

.border-left-yellow {
  border-left-color: #c49f47 !important; }

.border-right-yellow {
  border-right-color: #c49f47 !important; }

.bg-before-yellow:before,
.bg-after-yellow:after {
  background: #c49f47 !important; }

.border-before-yellow:before,
.border-after-yellow:after {
  border-color: #c49f47 !important; }

.border-top-before-yellow:before,
.border-top-after-yellow:after {
  border-top-color: #c49f47 !important; }

.border-bottom-before-yellow:before,
.border-bottom-after-yellow:after {
  border-bottom-color: #c49f47 !important; }

.border-left-before-yellow:before,
.border-left-after-yellow:after {
  border-left-color: #c49f47 !important; }

.border-right-before-yellow:before,
.border-right-after-yellow:after {
  border-right-color: #c49f47 !important; }

.bg-yellow-gold {
  background: #E87E04 !important; }

.bg-yellow-gold-opacity {
  background: rgba(232, 126, 4, 0.8) !important; }

.bg-hover-yellow-gold:hover {
  background: #E87E04 !important; }

.font-yellow-gold {
  color: #E87E04 !important; }

.bg-font-yellow-gold {
  color: #ffffff !important; }

.border-yellow-gold {
  border-color: #E87E04 !important; }

.border-top-yellow-gold {
  border-top-color: #E87E04 !important; }

.border-bottom-yellow-gold {
  border-bottom-color: #E87E04 !important; }

.border-left-yellow-gold {
  border-left-color: #E87E04 !important; }

.border-right-yellow-gold {
  border-right-color: #E87E04 !important; }

.bg-before-yellow-gold:before,
.bg-after-yellow-gold:after {
  background: #E87E04 !important; }

.border-before-yellow-gold:before,
.border-after-yellow-gold:after {
  border-color: #E87E04 !important; }

.border-top-before-yellow-gold:before,
.border-top-after-yellow-gold:after {
  border-top-color: #E87E04 !important; }

.border-bottom-before-yellow-gold:before,
.border-bottom-after-yellow-gold:after {
  border-bottom-color: #E87E04 !important; }

.border-left-before-yellow-gold:before,
.border-left-after-yellow-gold:after {
  border-left-color: #E87E04 !important; }

.border-right-before-yellow-gold:before,
.border-right-after-yellow-gold:after {
  border-right-color: #E87E04 !important; }

.bg-yellow-casablanca {
  background: #f2784b !important; }

.bg-yellow-casablanca-opacity {
  background: rgba(242, 120, 75, 0.8) !important; }

.bg-hover-yellow-casablanca:hover {
  background: #f2784b !important; }

.font-yellow-casablanca {
  color: #f2784b !important; }

.bg-font-yellow-casablanca {
  color: #ffffff !important; }

.border-yellow-casablanca {
  border-color: #f2784b !important; }

.border-top-yellow-casablanca {
  border-top-color: #f2784b !important; }

.border-bottom-yellow-casablanca {
  border-bottom-color: #f2784b !important; }

.border-left-yellow-casablanca {
  border-left-color: #f2784b !important; }

.border-right-yellow-casablanca {
  border-right-color: #f2784b !important; }

.bg-before-yellow-casablanca:before,
.bg-after-yellow-casablanca:after {
  background: #f2784b !important; }

.border-before-yellow-casablanca:before,
.border-after-yellow-casablanca:after {
  border-color: #f2784b !important; }

.border-top-before-yellow-casablanca:before,
.border-top-after-yellow-casablanca:after {
  border-top-color: #f2784b !important; }

.border-bottom-before-yellow-casablanca:before,
.border-bottom-after-yellow-casablanca:after {
  border-bottom-color: #f2784b !important; }

.border-left-before-yellow-casablanca:before,
.border-left-after-yellow-casablanca:after {
  border-left-color: #f2784b !important; }

.border-right-before-yellow-casablanca:before,
.border-right-after-yellow-casablanca:after {
  border-right-color: #f2784b !important; }

.bg-yellow-crusta {
  background: #f3c200 !important; }

.bg-yellow-crusta-opacity {
  background: rgba(243, 194, 0, 0.8) !important; }

.bg-hover-yellow-crusta:hover {
  background: #f3c200 !important; }

.font-yellow-crusta {
  color: #f3c200 !important; }

.bg-font-yellow-crusta {
  color: #ffffff !important; }

.border-yellow-crusta {
  border-color: #f3c200 !important; }

.border-top-yellow-crusta {
  border-top-color: #f3c200 !important; }

.border-bottom-yellow-crusta {
  border-bottom-color: #f3c200 !important; }

.border-left-yellow-crusta {
  border-left-color: #f3c200 !important; }

.border-right-yellow-crusta {
  border-right-color: #f3c200 !important; }

.bg-before-yellow-crusta:before,
.bg-after-yellow-crusta:after {
  background: #f3c200 !important; }

.border-before-yellow-crusta:before,
.border-after-yellow-crusta:after {
  border-color: #f3c200 !important; }

.border-top-before-yellow-crusta:before,
.border-top-after-yellow-crusta:after {
  border-top-color: #f3c200 !important; }

.border-bottom-before-yellow-crusta:before,
.border-bottom-after-yellow-crusta:after {
  border-bottom-color: #f3c200 !important; }

.border-left-before-yellow-crusta:before,
.border-left-after-yellow-crusta:after {
  border-left-color: #f3c200 !important; }

.border-right-before-yellow-crusta:before,
.border-right-after-yellow-crusta:after {
  border-right-color: #f3c200 !important; }

.bg-yellow-lemon {
  background: #F7CA18 !important; }

.bg-yellow-lemon-opacity {
  background: rgba(247, 202, 24, 0.8) !important; }

.bg-hover-yellow-lemon:hover {
  background: #F7CA18 !important; }

.font-yellow-lemon {
  color: #F7CA18 !important; }

.bg-font-yellow-lemon {
  color: #ffffff !important; }

.border-yellow-lemon {
  border-color: #F7CA18 !important; }

.border-top-yellow-lemon {
  border-top-color: #F7CA18 !important; }

.border-bottom-yellow-lemon {
  border-bottom-color: #F7CA18 !important; }

.border-left-yellow-lemon {
  border-left-color: #F7CA18 !important; }

.border-right-yellow-lemon {
  border-right-color: #F7CA18 !important; }

.bg-before-yellow-lemon:before,
.bg-after-yellow-lemon:after {
  background: #F7CA18 !important; }

.border-before-yellow-lemon:before,
.border-after-yellow-lemon:after {
  border-color: #F7CA18 !important; }

.border-top-before-yellow-lemon:before,
.border-top-after-yellow-lemon:after {
  border-top-color: #F7CA18 !important; }

.border-bottom-before-yellow-lemon:before,
.border-bottom-after-yellow-lemon:after {
  border-bottom-color: #F7CA18 !important; }

.border-left-before-yellow-lemon:before,
.border-left-after-yellow-lemon:after {
  border-left-color: #F7CA18 !important; }

.border-right-before-yellow-lemon:before,
.border-right-after-yellow-lemon:after {
  border-right-color: #F7CA18 !important; }

.bg-yellow-saffron {
  background: #F4D03F !important; }

.bg-yellow-saffron-opacity {
  background: rgba(244, 208, 63, 0.8) !important; }

.bg-hover-yellow-saffron:hover {
  background: #F4D03F !important; }

.font-yellow-saffron {
  color: #F4D03F !important; }

.bg-font-yellow-saffron {
  color: #ffffff !important; }

.border-yellow-saffron {
  border-color: #F4D03F !important; }

.border-top-yellow-saffron {
  border-top-color: #F4D03F !important; }

.border-bottom-yellow-saffron {
  border-bottom-color: #F4D03F !important; }

.border-left-yellow-saffron {
  border-left-color: #F4D03F !important; }

.border-right-yellow-saffron {
  border-right-color: #F4D03F !important; }

.bg-before-yellow-saffron:before,
.bg-after-yellow-saffron:after {
  background: #F4D03F !important; }

.border-before-yellow-saffron:before,
.border-after-yellow-saffron:after {
  border-color: #F4D03F !important; }

.border-top-before-yellow-saffron:before,
.border-top-after-yellow-saffron:after {
  border-top-color: #F4D03F !important; }

.border-bottom-before-yellow-saffron:before,
.border-bottom-after-yellow-saffron:after {
  border-bottom-color: #F4D03F !important; }

.border-left-before-yellow-saffron:before,
.border-left-after-yellow-saffron:after {
  border-left-color: #F4D03F !important; }

.border-right-before-yellow-saffron:before,
.border-right-after-yellow-saffron:after {
  border-right-color: #F4D03F !important; }

.bg-yellow-soft {
  background: #c8d046 !important; }

.bg-yellow-soft-opacity {
  background: rgba(200, 208, 70, 0.8) !important; }

.bg-hover-yellow-soft:hover {
  background: #c8d046 !important; }

.font-yellow-soft {
  color: #c8d046 !important; }

.bg-font-yellow-soft {
  color: #ffffff !important; }

.border-yellow-soft {
  border-color: #c8d046 !important; }

.border-top-yellow-soft {
  border-top-color: #c8d046 !important; }

.border-bottom-yellow-soft {
  border-bottom-color: #c8d046 !important; }

.border-left-yellow-soft {
  border-left-color: #c8d046 !important; }

.border-right-yellow-soft {
  border-right-color: #c8d046 !important; }

.bg-before-yellow-soft:before,
.bg-after-yellow-soft:after {
  background: #c8d046 !important; }

.border-before-yellow-soft:before,
.border-after-yellow-soft:after {
  border-color: #c8d046 !important; }

.border-top-before-yellow-soft:before,
.border-top-after-yellow-soft:after {
  border-top-color: #c8d046 !important; }

.border-bottom-before-yellow-soft:before,
.border-bottom-after-yellow-soft:after {
  border-bottom-color: #c8d046 !important; }

.border-left-before-yellow-soft:before,
.border-left-after-yellow-soft:after {
  border-left-color: #c8d046 !important; }

.border-right-before-yellow-soft:before,
.border-right-after-yellow-soft:after {
  border-right-color: #c8d046 !important; }

.bg-yellow-haze {
  background: #c5bf66 !important; }

.bg-yellow-haze-opacity {
  background: rgba(197, 191, 102, 0.8) !important; }

.bg-hover-yellow-haze:hover {
  background: #c5bf66 !important; }

.font-yellow-haze {
  color: #c5bf66 !important; }

.bg-font-yellow-haze {
  color: #ffffff !important; }

.border-yellow-haze {
  border-color: #c5bf66 !important; }

.border-top-yellow-haze {
  border-top-color: #c5bf66 !important; }

.border-bottom-yellow-haze {
  border-bottom-color: #c5bf66 !important; }

.border-left-yellow-haze {
  border-left-color: #c5bf66 !important; }

.border-right-yellow-haze {
  border-right-color: #c5bf66 !important; }

.bg-before-yellow-haze:before,
.bg-after-yellow-haze:after {
  background: #c5bf66 !important; }

.border-before-yellow-haze:before,
.border-after-yellow-haze:after {
  border-color: #c5bf66 !important; }

.border-top-before-yellow-haze:before,
.border-top-after-yellow-haze:after {
  border-top-color: #c5bf66 !important; }

.border-bottom-before-yellow-haze:before,
.border-bottom-after-yellow-haze:after {
  border-bottom-color: #c5bf66 !important; }

.border-left-before-yellow-haze:before,
.border-left-after-yellow-haze:after {
  border-left-color: #c5bf66 !important; }

.border-right-before-yellow-haze:before,
.border-right-after-yellow-haze:after {
  border-right-color: #c5bf66 !important; }

.bg-yellow-mint {
  background: #c5b96b !important; }

.bg-yellow-mint-opacity {
  background: rgba(197, 185, 107, 0.8) !important; }

.bg-hover-yellow-mint:hover {
  background: #c5b96b !important; }

.font-yellow-mint {
  color: #c5b96b !important; }

.bg-font-yellow-mint {
  color: #ffffff !important; }

.border-yellow-mint {
  border-color: #c5b96b !important; }

.border-top-yellow-mint {
  border-top-color: #c5b96b !important; }

.border-bottom-yellow-mint {
  border-bottom-color: #c5b96b !important; }

.border-left-yellow-mint {
  border-left-color: #c5b96b !important; }

.border-right-yellow-mint {
  border-right-color: #c5b96b !important; }

.bg-before-yellow-mint:before,
.bg-after-yellow-mint:after {
  background: #c5b96b !important; }

.border-before-yellow-mint:before,
.border-after-yellow-mint:after {
  border-color: #c5b96b !important; }

.border-top-before-yellow-mint:before,
.border-top-after-yellow-mint:after {
  border-top-color: #c5b96b !important; }

.border-bottom-before-yellow-mint:before,
.border-bottom-after-yellow-mint:after {
  border-bottom-color: #c5b96b !important; }

.border-left-before-yellow-mint:before,
.border-left-after-yellow-mint:after {
  border-left-color: #c5b96b !important; }

.border-right-before-yellow-mint:before,
.border-right-after-yellow-mint:after {
  border-right-color: #c5b96b !important; }

.bg-purple {
  background: #8E44AD !important; }

.bg-purple-opacity {
  background: rgba(142, 68, 173, 0.8) !important; }

.bg-hover-purple:hover {
  background: #8E44AD !important; }

.font-purple {
  color: #8E44AD !important; }

.bg-font-purple {
  color: #ffffff !important; }

.border-purple {
  border-color: #8E44AD !important; }

.border-top-purple {
  border-top-color: #8E44AD !important; }

.border-bottom-purple {
  border-bottom-color: #8E44AD !important; }

.border-left-purple {
  border-left-color: #8E44AD !important; }

.border-right-purple {
  border-right-color: #8E44AD !important; }

.bg-before-purple:before,
.bg-after-purple:after {
  background: #8E44AD !important; }

.border-before-purple:before,
.border-after-purple:after {
  border-color: #8E44AD !important; }

.border-top-before-purple:before,
.border-top-after-purple:after {
  border-top-color: #8E44AD !important; }

.border-bottom-before-purple:before,
.border-bottom-after-purple:after {
  border-bottom-color: #8E44AD !important; }

.border-left-before-purple:before,
.border-left-after-purple:after {
  border-left-color: #8E44AD !important; }

.border-right-before-purple:before,
.border-right-after-purple:after {
  border-right-color: #8E44AD !important; }

.bg-purple-plum {
  background: #8775a7 !important; }

.bg-purple-plum-opacity {
  background: rgba(135, 117, 167, 0.8) !important; }

.bg-hover-purple-plum:hover {
  background: #8775a7 !important; }

.font-purple-plum {
  color: #8775a7 !important; }

.bg-font-purple-plum {
  color: #ffffff !important; }

.border-purple-plum {
  border-color: #8775a7 !important; }

.border-top-purple-plum {
  border-top-color: #8775a7 !important; }

.border-bottom-purple-plum {
  border-bottom-color: #8775a7 !important; }

.border-left-purple-plum {
  border-left-color: #8775a7 !important; }

.border-right-purple-plum {
  border-right-color: #8775a7 !important; }

.bg-before-purple-plum:before,
.bg-after-purple-plum:after {
  background: #8775a7 !important; }

.border-before-purple-plum:before,
.border-after-purple-plum:after {
  border-color: #8775a7 !important; }

.border-top-before-purple-plum:before,
.border-top-after-purple-plum:after {
  border-top-color: #8775a7 !important; }

.border-bottom-before-purple-plum:before,
.border-bottom-after-purple-plum:after {
  border-bottom-color: #8775a7 !important; }

.border-left-before-purple-plum:before,
.border-left-after-purple-plum:after {
  border-left-color: #8775a7 !important; }

.border-right-before-purple-plum:before,
.border-right-after-purple-plum:after {
  border-right-color: #8775a7 !important; }

.bg-purple-medium {
  background: #BF55EC !important; }

.bg-purple-medium-opacity {
  background: rgba(191, 85, 236, 0.8) !important; }

.bg-hover-purple-medium:hover {
  background: #BF55EC !important; }

.font-purple-medium {
  color: #BF55EC !important; }

.bg-font-purple-medium {
  color: #ffffff !important; }

.border-purple-medium {
  border-color: #BF55EC !important; }

.border-top-purple-medium {
  border-top-color: #BF55EC !important; }

.border-bottom-purple-medium {
  border-bottom-color: #BF55EC !important; }

.border-left-purple-medium {
  border-left-color: #BF55EC !important; }

.border-right-purple-medium {
  border-right-color: #BF55EC !important; }

.bg-before-purple-medium:before,
.bg-after-purple-medium:after {
  background: #BF55EC !important; }

.border-before-purple-medium:before,
.border-after-purple-medium:after {
  border-color: #BF55EC !important; }

.border-top-before-purple-medium:before,
.border-top-after-purple-medium:after {
  border-top-color: #BF55EC !important; }

.border-bottom-before-purple-medium:before,
.border-bottom-after-purple-medium:after {
  border-bottom-color: #BF55EC !important; }

.border-left-before-purple-medium:before,
.border-left-after-purple-medium:after {
  border-left-color: #BF55EC !important; }

.border-right-before-purple-medium:before,
.border-right-after-purple-medium:after {
  border-right-color: #BF55EC !important; }

.bg-purple-studio {
  background: #8E44AD !important; }

.bg-purple-studio-opacity {
  background: rgba(142, 68, 173, 0.8) !important; }

.bg-hover-purple-studio:hover {
  background: #8E44AD !important; }

.font-purple-studio {
  color: #8E44AD !important; }

.bg-font-purple-studio {
  color: #ffffff !important; }

.border-purple-studio {
  border-color: #8E44AD !important; }

.border-top-purple-studio {
  border-top-color: #8E44AD !important; }

.border-bottom-purple-studio {
  border-bottom-color: #8E44AD !important; }

.border-left-purple-studio {
  border-left-color: #8E44AD !important; }

.border-right-purple-studio {
  border-right-color: #8E44AD !important; }

.bg-before-purple-studio:before,
.bg-after-purple-studio:after {
  background: #8E44AD !important; }

.border-before-purple-studio:before,
.border-after-purple-studio:after {
  border-color: #8E44AD !important; }

.border-top-before-purple-studio:before,
.border-top-after-purple-studio:after {
  border-top-color: #8E44AD !important; }

.border-bottom-before-purple-studio:before,
.border-bottom-after-purple-studio:after {
  border-bottom-color: #8E44AD !important; }

.border-left-before-purple-studio:before,
.border-left-after-purple-studio:after {
  border-left-color: #8E44AD !important; }

.border-right-before-purple-studio:before,
.border-right-after-purple-studio:after {
  border-right-color: #8E44AD !important; }

.bg-purple-wisteria {
  background: #9B59B6 !important; }

.bg-purple-wisteria-opacity {
  background: rgba(155, 89, 182, 0.8) !important; }

.bg-hover-purple-wisteria:hover {
  background: #9B59B6 !important; }

.font-purple-wisteria {
  color: #9B59B6 !important; }

.bg-font-purple-wisteria {
  color: #ffffff !important; }

.border-purple-wisteria {
  border-color: #9B59B6 !important; }

.border-top-purple-wisteria {
  border-top-color: #9B59B6 !important; }

.border-bottom-purple-wisteria {
  border-bottom-color: #9B59B6 !important; }

.border-left-purple-wisteria {
  border-left-color: #9B59B6 !important; }

.border-right-purple-wisteria {
  border-right-color: #9B59B6 !important; }

.bg-before-purple-wisteria:before,
.bg-after-purple-wisteria:after {
  background: #9B59B6 !important; }

.border-before-purple-wisteria:before,
.border-after-purple-wisteria:after {
  border-color: #9B59B6 !important; }

.border-top-before-purple-wisteria:before,
.border-top-after-purple-wisteria:after {
  border-top-color: #9B59B6 !important; }

.border-bottom-before-purple-wisteria:before,
.border-bottom-after-purple-wisteria:after {
  border-bottom-color: #9B59B6 !important; }

.border-left-before-purple-wisteria:before,
.border-left-after-purple-wisteria:after {
  border-left-color: #9B59B6 !important; }

.border-right-before-purple-wisteria:before,
.border-right-after-purple-wisteria:after {
  border-right-color: #9B59B6 !important; }

.bg-purple-seance {
  background: #9A12B3 !important; }

.bg-purple-seance-opacity {
  background: rgba(154, 18, 179, 0.8) !important; }

.bg-hover-purple-seance:hover {
  background: #9A12B3 !important; }

.font-purple-seance {
  color: #9A12B3 !important; }

.bg-font-purple-seance {
  color: #ffffff !important; }

.border-purple-seance {
  border-color: #9A12B3 !important; }

.border-top-purple-seance {
  border-top-color: #9A12B3 !important; }

.border-bottom-purple-seance {
  border-bottom-color: #9A12B3 !important; }

.border-left-purple-seance {
  border-left-color: #9A12B3 !important; }

.border-right-purple-seance {
  border-right-color: #9A12B3 !important; }

.bg-before-purple-seance:before,
.bg-after-purple-seance:after {
  background: #9A12B3 !important; }

.border-before-purple-seance:before,
.border-after-purple-seance:after {
  border-color: #9A12B3 !important; }

.border-top-before-purple-seance:before,
.border-top-after-purple-seance:after {
  border-top-color: #9A12B3 !important; }

.border-bottom-before-purple-seance:before,
.border-bottom-after-purple-seance:after {
  border-bottom-color: #9A12B3 !important; }

.border-left-before-purple-seance:before,
.border-left-after-purple-seance:after {
  border-left-color: #9A12B3 !important; }

.border-right-before-purple-seance:before,
.border-right-after-purple-seance:after {
  border-right-color: #9A12B3 !important; }

.bg-purple-intense {
  background: #8775a7 !important; }

.bg-purple-intense-opacity {
  background: rgba(135, 117, 167, 0.8) !important; }

.bg-hover-purple-intense:hover {
  background: #8775a7 !important; }

.font-purple-intense {
  color: #8775a7 !important; }

.bg-font-purple-intense {
  color: #ffffff !important; }

.border-purple-intense {
  border-color: #8775a7 !important; }

.border-top-purple-intense {
  border-top-color: #8775a7 !important; }

.border-bottom-purple-intense {
  border-bottom-color: #8775a7 !important; }

.border-left-purple-intense {
  border-left-color: #8775a7 !important; }

.border-right-purple-intense {
  border-right-color: #8775a7 !important; }

.bg-before-purple-intense:before,
.bg-after-purple-intense:after {
  background: #8775a7 !important; }

.border-before-purple-intense:before,
.border-after-purple-intense:after {
  border-color: #8775a7 !important; }

.border-top-before-purple-intense:before,
.border-top-after-purple-intense:after {
  border-top-color: #8775a7 !important; }

.border-bottom-before-purple-intense:before,
.border-bottom-after-purple-intense:after {
  border-bottom-color: #8775a7 !important; }

.border-left-before-purple-intense:before,
.border-left-after-purple-intense:after {
  border-left-color: #8775a7 !important; }

.border-right-before-purple-intense:before,
.border-right-after-purple-intense:after {
  border-right-color: #8775a7 !important; }

.bg-purple-sharp {
  background: #796799 !important; }

.bg-purple-sharp-opacity {
  background: rgba(121, 103, 153, 0.8) !important; }

.bg-hover-purple-sharp:hover {
  background: #796799 !important; }

.font-purple-sharp {
  color: #796799 !important; }

.bg-font-purple-sharp {
  color: #ffffff !important; }

.border-purple-sharp {
  border-color: #796799 !important; }

.border-top-purple-sharp {
  border-top-color: #796799 !important; }

.border-bottom-purple-sharp {
  border-bottom-color: #796799 !important; }

.border-left-purple-sharp {
  border-left-color: #796799 !important; }

.border-right-purple-sharp {
  border-right-color: #796799 !important; }

.bg-before-purple-sharp:before,
.bg-after-purple-sharp:after {
  background: #796799 !important; }

.border-before-purple-sharp:before,
.border-after-purple-sharp:after {
  border-color: #796799 !important; }

.border-top-before-purple-sharp:before,
.border-top-after-purple-sharp:after {
  border-top-color: #796799 !important; }

.border-bottom-before-purple-sharp:before,
.border-bottom-after-purple-sharp:after {
  border-bottom-color: #796799 !important; }

.border-left-before-purple-sharp:before,
.border-left-after-purple-sharp:after {
  border-left-color: #796799 !important; }

.border-right-before-purple-sharp:before,
.border-right-after-purple-sharp:after {
  border-right-color: #796799 !important; }

.bg-purple-soft {
  background: #8877a9 !important; }

.bg-purple-soft-opacity {
  background: rgba(136, 119, 169, 0.8) !important; }

.bg-hover-purple-soft:hover {
  background: #8877a9 !important; }

.font-purple-soft {
  color: #8877a9 !important; }

.bg-font-purple-soft {
  color: #ffffff !important; }

.border-purple-soft {
  border-color: #8877a9 !important; }

.border-top-purple-soft {
  border-top-color: #8877a9 !important; }

.border-bottom-purple-soft {
  border-bottom-color: #8877a9 !important; }

.border-left-purple-soft {
  border-left-color: #8877a9 !important; }

.border-right-purple-soft {
  border-right-color: #8877a9 !important; }

.bg-before-purple-soft:before,
.bg-after-purple-soft:after {
  background: #8877a9 !important; }

.border-before-purple-soft:before,
.border-after-purple-soft:after {
  border-color: #8877a9 !important; }

.border-top-before-purple-soft:before,
.border-top-after-purple-soft:after {
  border-top-color: #8877a9 !important; }

.border-bottom-before-purple-soft:before,
.border-bottom-after-purple-soft:after {
  border-bottom-color: #8877a9 !important; }

.border-left-before-purple-soft:before,
.border-left-after-purple-soft:after {
  border-left-color: #8877a9 !important; }

.border-right-before-purple-soft:before,
.border-right-after-purple-soft:after {
  border-right-color: #8877a9 !important; }

/***
Color library demo
***/
.color-demo {
  border: 1px solid #eee;
  margin: 0 0 20px 0;
  cursor: pointer; }
  .color-demo .color-view {
    padding: 35px 10px;
    text-align: center;
    font-size: 18px; }
  .color-demo .color-info {
    border-top: 1px solid #eee;
    padding: 10px 10px;
    text-align: center; }

.mt-cookie-consent-bar {
  position: fixed;
  bottom: 0;
  z-index: 10101;
  padding: 10px 25px;
  width: 100%;
  background: rgba(0, 0, 0, 0.9);
  color: #ffffff;
  left: 0;
  right: 0; }
  .mt-cookie-consent-bar .mt-cookie-consent-bar-holder {
    display: table;
    width: 100%; }
    .mt-cookie-consent-bar .mt-cookie-consent-bar-holder .mt-cookie-consent-bar-content {
      display: table-cell;
      text-align: left;
      vertical-align: middle; }
    .mt-cookie-consent-bar .mt-cookie-consent-bar-holder .mt-cookie-consent-bar-action {
      display: table-cell;
      text-align: right;
      vertical-align: middle; }
  .mt-cookie-consent-bar.mt-cookie-consent-bar-light {
    background: rgba(238, 238, 238, 0.9);
    color: #333; }

.mt-content-row {
  display: table;
  height: 100%;
  width: 100%; }
  .mt-content-row .mt-content-col-fluid {
    display: table-cell; }
    .mt-content-row .mt-content-col-fluid .mt-content-body {
      margin: 0;
      height: 100%;
      width: 100%;
      display: table; }
  .mt-content-row .mt-content-col-fixed {
    display: table-cell; }
    .mt-content-row .mt-content-col-fixed .mt-content-sidebar {
      height: 100%;
      width: 100%;
      display: table;
      margin-left: 20px;
      border: 1px solid red; }

@media (max-width: 767px) {
  /* 767px */
  .mt-content-row {
    display: block;
    width: 100%; }
    .mt-content-row .mt-content-col-fluid {
      display: block;
      width: 100%;
      margin-bottom: 20px; }
      .mt-content-row .mt-content-col-fluid .mt-content-body {
        margin: 0; }
    .mt-content-row .mt-content-col-fixed {
      display: block;
      width: 100%; }
      .mt-content-row .mt-content-col-fixed .mt-content-sidebar {
        margin-left: 0; } }

/*# sourceMappingURL=components-md.cs.map */
