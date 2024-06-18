$(document).ready(function () {
    $("#FormCidade").on("submit", function (event) {

        debugger

        event.preventDefault();

        var request = $("#FormCidade").serializeArray();

        $.ajax({
            type: 'POST',
            url: '/Cidade/Salvar',
            data: request
        }).then(function (response) {
            if (response.status) {

                $("#divTabelaCidade").html(response.view);

                $('#ModalAdicionarCidade').modal('hide');

                swal("Sucesso", response.mensagem, "success");
            }
            else {
                swal("Atenção", response.mensagem, "warning");
            }
        });
    })
})