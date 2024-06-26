﻿$(document).ready(function () {

})

$('.btn-AdicionarPessoa').click(function () {
    AbrirFormPessoa();
});

function EditarPessoa(id) {
    debugger
    AbrirFormPessoa(id);
}

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

function DeletarPessoa(id) {
    debugger
    swal({
        title: "Deseja realmente excluír?",
        text: "Pessoa será excluída de forma permanente!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    }).then((confirma) => {
        if (confirma) {
            AbrirExcluirPessoa(id);
        }
    });
}

function AbrirExcluirPessoa(id) {
    $.ajax({
        type: 'POST',
        url: '/Pessoa/Delete',
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

$(function () {
    $('#FormFiltroPessoa').submit(function (e) {
        e.preventDefault(); // Evita o comportamento padrão de submit do formulário

        var formData = $(this).serialize(); // Serializa os dados do formulário

        $.ajax({
            url: '/Pessoa/Filtrar', // URL da action que vai processar o filtro
            type: 'POST',
            data: formData,
            success: function (result) {
                $('#divTabelaPessoa').html(result); // Atualiza a parte da página com os resultados filtrados
            },
            error: function () {
                alert('Ocorreu um erro ao processar o filtro.');
            }
        });
    });
});