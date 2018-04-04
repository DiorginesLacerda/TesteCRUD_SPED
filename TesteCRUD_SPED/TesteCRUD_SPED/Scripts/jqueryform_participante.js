
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




$(function () {
    iniciaValores()
    validaPais()
    validaPessoa()
    filtraMunicipios()
    validaIsentoIE()

    cpf.mask('999.999.999-99')
    cnpj.mask('99.999.999/9999-99')
})

function aplicaMascaraIE() {
    //validar máximo 14 números
    /*
     1    RS    RIO GRANDE DO SUL    ###-#######
2    SC    SANTA CATARINA            ###.###.###
3    PR    PARANÁ                    ########-##
4    SP    SÃO PAULO                ###.###.###.###
5    MG    MINAS GERAIS            ###.###.###/####
6    RJ    RIO DE JANEIRO            ##.###.##-#
7    ES    ESPÍRITO SANTO        ###.###.##-#
8    BA    BAHIA                    ###.###.##-#
9    SE    SERGIPE                #########-#
10    AL    ALAGOAS                #########
11    PE    PERNAMBUCO            ##.#.###.#######-#
12    PB    PARAÍBA                    ########-#
13    RN    RIO GRANDE DO NORTE    ##.###.###-#
14    PI    PIAUÍ                    #########
15    MA    MARANHÃO                #########
16    CE    CEARÁ                    ########-#
17    GO    GOIÁS                    ##.###.###-#
18    TO    TOCANTINS                ###########
19    MT    MATO GROSSO            #########
20    MS    MATO GROSSO DO SUL    #########
21    DF    DISTRITO FEDERAL        ###########-##
22    AM    AMAZONAS                ##.###.###-#
23    AC    ACRE                    ##.###.###/###-##
24    PA    PARÁ                    ##-######-#
25    RO    RONDÔNIA                ###.#####-#
26    RR    RORAIMA                ########-#
27    AP    AMAPÁ                    #########
     */
}

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
    municipio.val('')
}

function filtraMunicipios() {
    estado.change(() => { 
    var id = estado.val()
    console.log(id)
    var url = "/Participante/GetMunicipios"
    var dados = { cod_estado: id }
    $.get(url, dados, atualizaMunicipios)
    })
}

function atualizaMunicipios(data) {
    console.log(data)
    municipio.empty()

    $(data).each(function () {
        var d = $(this)[0]
        municipio.append(new Option(d.NomeMunicipio, d.CodMunicipio,))
    })
}

function criaOption(value,text) {
    var option = $("<opttion>")
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