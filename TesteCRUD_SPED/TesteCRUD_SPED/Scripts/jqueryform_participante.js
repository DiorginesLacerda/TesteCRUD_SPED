
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
var suframa = $("#suframa")
var div_municipio =$("#div_municipio")
var municipio = $("#municipio")
var bairro = $("#bairro")
var numero = $("#numero")
var complemento = $("#complemento")




$(function () {
    iniciaValores()
    validaPais()
    validaPessoa()
    validaTipoPessoa()
    manipulaEstado()
    checaIsentoIE()
})



function validaPessoa() {
    pjpf.on("change", function () {
        validaTipoPessoa();
    })
}

function iniciaValores() {
    pais.val('1058')
    pjpf.val("Juridica")
    divcpf.hide()
    estado.val('')
    municipio.val('')
    ie.prop("disabled", true)
}

function manipulaEstado() {
    estado.change(() => {
        atualizaMunicipios()
        if (pjpf.val() == "Juridica") {
            validaIsentoIE()
            manipulaSuframa()
        }
    })
}

function atualizaMunicipios() { 
    municipio.empty()
    var id = estado.val()
    var url = "/Participante/GetMunicipios"
    var dados = { cod_estado: id }
    $.get(url, dados, (data)=> {
        $(data).each(function () {
            var d = $(this)[0]
            municipio.append(new Option(d.NomeMunicipio, d.CodMunicipio, ))
        })
    })
}

function checaIsentoIE() {
    isentoIE.on("click", function () {
        validaIsentoIE()
    })
}

function validaIsentoIE() {
    if (isentoIE.is(':checked')) {
        ie.val('')
        ie.prop("disabled", true)
    } else {
        if (estado.val() != null) {
            ie.prop("disabled", false)
            aplicaMaskIe()
        }
        else {
            alert("Selecione um estado")
        } 
    }
}

function aplicaMaskIe() {
    var uf = Number(estado.val())
    var mascara = getMaskIE(uf)
    ie.mask(mascara)
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
    cnpj.mask('99.999.999/9999-99')
    divcpf.hide()
    cpf.val('')
    div_cnpj.show()
    div_ie.show()
    manipulaSuframa()
}

function manipulaSuframa() {
    if (estado.val() == 13) {
        div_suframa.show()
        suframa.mask("999999999")
    }
    else {
        div_suframa.hide()
        suframa.val('')
    }
}

function mostraPF() {
    cpf.mask('999.999.999-99')
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