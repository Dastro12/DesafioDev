$(document).ready(function () {
    $("#FormPessoa").on("submit", function (event) {

        debugger

        event.preventDefault();

        var request = $("#FormPessoa").serializeArray();

        $.ajax({
            type: 'POST',
            url: '/Pessoa/Salvar',
            data: request
        }).then(function (response) {
            if (response.status) {

                $("#divTabelaPessoa").html(response.view);

                $('#ModalAdicionarPessoa').modal('hide');

                swal("Sucesso", response.mensagem, "success");
            }
            else {
                swal("Atenção", response.mensagem, "warning");
            }
        });
    })
})