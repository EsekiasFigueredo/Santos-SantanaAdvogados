$(function () {
	$("input[data-tipo='data']").mask("00/00/0000");
    $("input[data-tipo='telefone']").mask("(00) 0 00000000");
    
});
$('#docType').change(function () {
    if ($('#docType option:selected').val() == 'PF') {
        $("#doc").mask("000.000.000-00");
    } else {
        $("#doc").mask("00.000.000/0000-00");
    }
});

   