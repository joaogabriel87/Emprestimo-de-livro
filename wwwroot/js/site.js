$(document).ready(function () {

    $('#Emprestimos').DataTable({
        language: {
            "decimal":        "",
            "emptyTable":     "No data available in table",
            "info":           "Showing _START_ to _END_ of _TOTAL_ entries",
            "infoEmpty":      "Showing 0 to 0 of 0 entries",
            "infoFiltered":   "(filtered from _MAX_ total entries)",
            "infoPostFix":    "",
            "thousands":      ",",
            "lengthMenu":     "Mostrar _MENU_ entradas",
            "loadingRecords": "Carregando",
            "processing":     "",
            "search":         "Procurar:",
            "zeroRecords":    "No matching records found",
            "paginate": {
                "first":      "Primeiro",
                "last":       "Ultimo",
                "next":       "Proximo",
                "previous":   "Anterior"
            },
            "aria": {
                "sortAscending":  ": activate to sort column ascending",
                "sortDescending": ": activate to sort column descending"
            }
        }
            
        
    });

    setTimeout(function (){
        $(".alert").fadeOut("slow", function(){
            $(this).alert('close');
        })
    },5000)
});