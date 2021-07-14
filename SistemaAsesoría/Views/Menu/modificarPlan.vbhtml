﻿@Code
    ViewData("Title") = "modificarPlan"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<h1>Modificar Plan</h1>


<form>
    <div class="form-group">
        <label for="exampleInputEmail1">Documento de Identidad </label>
        <input type="text" disabled class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="">
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Nombre Completo </label>
        <input type="text" disabled class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="">
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Número de Telefono: </label>
        <select class="form-control form-control-6sm">
            <option>Seleccionar</option>
            <option>999 999 999</option>
            <option>942417723</option>

        </select>
    </div>

    <div class="form-group">
        <label for="exampleInputPassword1">Pin</label>
        <input type="text" disabled class="form-control" id="exampleInputPassword1">
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Puk</label>
        <input type="text" disabled class="form-control" id="exampleInputPassword1">
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Plan Actual</label>
        <input type="text" disabled class="form-control" id="exampleInputPassword1">
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Plan</label>
        <select class="form-control form-control-6sm">
            <option>Seleccionar</option>
            <option>Plan 29.90</option>
            <option>Plan 39.90</option>
            <option>Plan 49.90</option>

        </select>
    </div>

    <button type="submit" class="btn btn-primary">Actualizar</button>
    <a href="~/Menu/Index"> <button type="button" class="btn btn-secondary">Regresar</button></a>
   
</form>

