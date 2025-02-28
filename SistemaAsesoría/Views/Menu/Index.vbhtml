﻿

@Code
    ViewData("Title") = "Index"
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

    <h1>Lista de Clientes</h1>
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
                            <th>Titular</th>
                            <th>N. de Documento</th>
                            <th>Celular</th>
                            <th>Cant. Lineas</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1 </td>
                            <td>Raúl </td>
                            <td>73632374 </td>
                            <td>942417723 </td>
                            <td>2 </td>
                            <td>

                                <a href="~/Menu/viewPlanes"> <button type="button" class="btn btn-secondary">Consultar</button></a>
                                <a href="~/Menu/registerPlanes"> <button type="button" class="btn btn-primary">Agregar</button></a>
                                <a href="~/Menu/modificarPlan">  <button type="button" class="btn btn-success">Modificar</button></a>
                                <a href="~/Menu/deletePlan"><button type="button" class="btn btn-danger">Eliminar</button></a>
                            </td>

                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
</div>

@section scripts





    <script>
        $(document).ready(function () {
            $('#tablemain').DataTable();
        });

    </script>

end Section
