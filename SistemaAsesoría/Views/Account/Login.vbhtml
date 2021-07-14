@ModelType LoginViewModel
@Code
    ViewBag.Title = "Iniciar sesión"
    ViewBag.ReturnUrl = "/Menu/Index"
End Code

<style>
    .form-control {
        margin-left: 1cm;
    }
    body {
        background: #2980b9; /* fallback for old browsers */
        background: -webkit-linear-gradient(to top, #2c3e50, #2980b9); /* Chrome 10-25, Safari 5.1-6 */
        background: linear-gradient(to top, #2c3e50, #2980b9); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
    }
</style>

        <div class="gradient wrapper fadeInDown">
            <div id="formContent">
                @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                    @Html.AntiForgeryToken()
                    @<text>
                        <hr />
                        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                        <div class="form-group">

                            <div class="col-md-10">
                                @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control", .placeHolder = "Usuario"})
                                @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-10">
                                @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control", .placeHolder = "Contraseña"})
                                @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                        <p>
                            @Html.ActionLink("¿Ha olvidado su contraseña?", "ForgotPassword")
                        </p>
                    
                                <input type="submit" value="Iniciar sesión" class="btn btn-default" />
                         



                    </text>
                End Using

            </div>

        </div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
