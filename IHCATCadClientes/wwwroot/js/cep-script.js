//A API do ViaCEP preenche os campos quando o CEP informado é encontrado
$(document).ready(function () {
    $('#CEP').on('blur', function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep.length === 8) { 
            $.getJSON(`https://viacep.com.br/ws/${cep}/json/`, function (data) {
                if (!data.erro) {
                    $('#Bairro').val(data.bairro || '')
                    $('#Cidade').val(data.localidade || '');
                    $('#UF').val(data.uf || '');
                } else {
                    $('#Bairro').val('');
                    $('#Cidade').val('');
                    $('#UF').val('');
                    //Emite um Alerta para quando não é encontrado
                    //Bug de emitir dois alertas e travar a tela consertado, emite 1 alerta e libera o usuário
                    alert('CEP não encontrado.');
                }
            });
        }
    });
});
