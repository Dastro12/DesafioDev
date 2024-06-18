$(document).ready(function () {

})

$('.btn-AdicionarPessoa').click(function () {
    AbrirFormPessoa();
});

function AbrirFormPessoa(id = 0) {
    $.ajax({
        type: 'POST',
        url: '/Pessoa/Form',
        data: { id: id }
    }).then(function (response) {
        $("#divform").html(response.view);
        $('#ModalAdicionarPessoa').modal();
    });
}