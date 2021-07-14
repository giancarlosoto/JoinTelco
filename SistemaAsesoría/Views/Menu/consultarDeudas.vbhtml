﻿@Code
    ViewData("Title") = "consultarDeudas"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code




<style>
    table {
        text-align: center;
    }

        table.dataTable thead .sorting {
            text-align: center;
        }

    .row {
        height: 100%;
        margin-top: 8% !important;
    }
</style>

<div class="row">

    <h1>Información Crediticia</h1>
    <br />
    <form class="form-inline">

        <div class="form-group mx-sm-3 mb-2">
            <label for="staticEmail2">Número de Documento</label>

            <label for="inputPassword2" class="sr-only">Password</label>
            <input type="password" class="form-control" id="inputPassword2">
        </div>
        <button type="submit" class="btn btn-primary mb-2">Buscar</button>
    </form>

    <br />
    <div class="col-sm-12">
        <div class="card">
            <div class="card-header">

            </div>
            <div class="card-body">
                <table id="tablemain" class="table">
                    <thead>
                        <tr>
                            <th>Código</th>
                            <th>Descripción</th>
                            <th>Entidad</th>
                            <th>Año</th>
                            <th>Estado</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1 </td>
                            <td>Prestamo 1000 dolares </td>
                            <td>BCP </td>
                            <td>2020 </td>
                            <td>Activo </td>


                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
    <a href="~/Menu/registerPlanes"> <button type="button" class="btn btn-secondary">Regresar</button></a>
</div>
