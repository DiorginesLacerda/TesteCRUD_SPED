
var pais = $('#pais')

var pfpj = $("#pfpj")
var pjpf = $("#pjpf")
var divcpf = $("#divcpf")
var cpf = $("#cpf")
var div_cnpj = $("#div_cnpj")
var cnpj = $("#cnpj")
var div_estado = $("#div_estado")
var estado = $("#estado")
var div_ie = $("#div_ie")
var ie = $("#ie")
var isentoIE = $("#isentoIE")
var div_suframa = $("#div_suframa")
var suframa = ("#suframa")
var div_municipio =$("#div_municipio")
var municipio = $("#municipio")
var bairro = $("#bairro")
var numero = $("#numero")
var complemento = $("#complemento")
var municipios = $("@ViewBag.Municipios")



$(document).ready(function () {
    iniciaValores();
    
    validaPais()
    validaPessoa()
    validaIsentoIE()
})

function validaPessoa() {
    pjpf.on("change", function () {
        validaTipoPessoa();
    })
}



function iniciaValores() {
    pais.val('1058');
    pjpf.val("Juridica");
    divcpf.hide();
    estado.val('');
}

function filtraMunicipios(id) {

}

function validaIsentoIE() {
    isentoIE.on("click", function () {
        if (isentoIE.is(':checked')) {
            ie.val('')
            ie.prop("disabled", true)
        } else {
            ie.prop("disabled", false)
        }
    })
}

function validaPais() {
    pais.on("change", function () {
        if (pais.val() == '1058') {
            validaTipoPessoa()
            mostraBR()

        } else {
            escondeBR()
        }
    })
}
    



function mostraPJ() {
    
    divcpf.hide()
    cpf.val('')
    div_cnpj.show()
    div_ie.show()
    div_suframa.show()
    
}

function mostraPF() {
    
    divcpf.show()
    div_cnpj.hide()
    cnpj.val('')
    div_ie.hide()
    ie.val('')
    div_suframa.hide()
    suframa.val('')
    
}

function escondeBR() {
    pfpj.hide()
    divcpf.hide()
    cpf.val('')
    div_cnpj.hide()
    cnpj.val('')
    div_estado.hide()
    estado.val('')
    div_ie.hide()
    ie.val('')
    div_suframa.hide()
    suframa.val('')
    div_municipio.hide()
    municipio.val('')
    bairro.hide()

    numero.hide()

    complemento.hide()

}

function mostraBR() {
    pfpj.show()
    divcpf.show()
    div_cnpj.show()
    div_estado.show()
    div_ie.show()
    div_suframa.show()
    dic_municipio.show()
    bairro.show()
    numero.show()
    complemento.show()
}

function validaTipoPessoa() {
    if (pjpf.val() == 'Juridica') {
        mostraPJ()
    }
    if (pjpf.val() == 'Fisica') {
        mostraPF()
    }
}