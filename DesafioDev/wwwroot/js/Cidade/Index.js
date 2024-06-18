//const { swal } = require("../Sweetalert/sweetalert");

$(document).ready(function () {

})

$('.btn-ModalAdicionarCidade').click(function () {
    AbrirForm();
});

function DeletarCidade(id) {
    swal({
        title: "Deseja realmente excluír?",
        text: "Cidade será excluída de forma permanente!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    }).then((confirma) => {
        if (confirma) {
            AbrirExcluir(id);
        }
    });
}

function EditarCidade(id) {
    AbrirForm(id);
}

function AbrirForm(id = 0) {
    $.ajax({
        type: 'POST',
        url: '/Cidade/Form',
        data: { id: id }
    }).then(function (response) {
        $("#divform").html(response.view);
        $('#ModalAdicionarCidade').modal();
    });
}

function AbrirExcluir(id) {
    $.ajax({
        type: 'POST',
        url: '/Cidade/Delete',
        data: { id: id }
    }).then(function (response) {
        if (response.status) {

            $("#divTabelaCidade").html(response.view);

            swal("Sucesso", response.mensagem, "success");
        }
        else {
            swal("Atenção", response.mensagem, "warning");
        }
    });
}
