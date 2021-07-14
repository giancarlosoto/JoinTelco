

@Code
    ViewData("Ver ") = "Index"
End Code

<h1>Dueño de la Linea: Raúl Salinas</h1>

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
    <div class="col-sm-6">
        <div class="card">
            <div class="card-body">
                <h5 class="card-title">Special title treatment</h5>
                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
        </div>
    </div>
    <div class="col-sm-6">
        <div class="card">
            <div class="card-body">
                <h5 class="card-title">Special title treatment</h5>
                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
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
