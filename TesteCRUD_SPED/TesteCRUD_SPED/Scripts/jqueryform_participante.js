
var pais = $('#pais')

var pfpj = $("#pfpj")
var pjpf = $("#pjpf")
var cpf = $("#cpf")
var cnpj = $("#cnpj")
var estado = $("#estado")
var ie = $("#ie")
var suframa = $("#suframa")
var municipio = $("#municipio")
var bairro = $("#bairro")
var numero = $("#numero")
var complemento = $("#complemento")



$(document).ready(function () {
    pais.val('1058')
    pjpf.val('Juridica')
    cpf.hide()
    pjpf.on('change', function () {
        if (pjpf.val('Juridica')) {
            cpf.hide()
            cnpj.show()
            estado.show()
            ie.show()
            suframa.show()
        }
        if (pjpf.val('Juridica')) {
            cpf.show()
            cnpj.hide()
            estado.hide()
            ie.hide()
            suframa.hide()
        }
    })

    pais.on("change", function () {
        if (pais.val() != '1058') {
            pfpj.hide()
            cpf.hide()
            cnpj.hide()
            estado.hide()
            ie.hide()
            suframa.hide()
            municipio.hide()
            bairro.hide()
            numero.hide()
            complemento.hide()

        } else {
            pfpj.show()
            cpf.show()
            cnpj.show()
            estado.show()
            ie.show()
            suframa.show()
            municipio.show()
            bairro.show()
            numero.show()
            complemento.show()
        }
            
    })
});


