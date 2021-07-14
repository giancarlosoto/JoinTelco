

@Code
    ViewData("Title") = "Index"
End Code

<h1>Lista de Clientes</h1>

<style>
    table{
        text-align:center;

    }
      table.dataTable thead .sorting {
            text-align: center;
      }

</style>
<br />
<div class="row">
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
                                <button type="button" class="btn btn-secondary">Consultar</button>
                                <button type="button" class="btn btn-primary">Agregar</button>
                                <button type="button" class="btn btn-success">Modificar</button>
                                <button type="button" class="btn btn-danger">Eliminar</button>
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
