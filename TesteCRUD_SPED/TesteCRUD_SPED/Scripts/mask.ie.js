//Para ser utilizada com a bilioteca jquery.mask
//Códigos de Estado conforme a tabela do IBGE, atualizado em 04/2018

function getMaskIE(uf) {
    switch (uf) {
        case 43:
            return "99-9999999"
        case 42:
            return "999.999.999"
        case 41:
            return "99999999-99"
        case 35:
            return "999.999.999.999"
        case 31:
            return "999.999.999/9999"
        case 33:
            return "99.999.99-9"
        case 32:
            return "999.999.99-9"
        case 28:
            return "999.999.99-9"
        case 28:
            return "999999999-9"
        case 27:
        case 22:
        case 51:
        case 21:
        case 50:
        case 16:
            return "999999999"
        case 26:
            return "99.9.999.9999999-9"
        case 25:
            return "99999999-9"
        case 24:
        case 52:
        case 13:
            return "99.999.999-9"
        case 23:
        case 14:
            return "99999999-9"
        case 17:
            return "99999999999"
        case 53:
            return "99999999999-99"
        case 12:
            return "99.999.999./999-99"
        case 15:
            return "99-999999-9"
        case 11:
            return "999.99999-9"
    }  
}

/*
 RS    RIO GRANDE DO SUL        ###-#######
 SC    SANTA CATARINA           ###.###.###
 PR    PARANÁ                   ########-##
 SP    SÃO PAULO                ###.###.###.###
 MG    MINAS GERAIS             ###.###.###/####
 RJ    RIO DE JANEIRO           ##.###.##-#
 ES    ESPÍRITO SANTO           ###.###.##-#
 BA    BAHIA                    ###.###.##-#
 SE    SERGIPE                  #########-#
 AL    ALAGOAS                  #########
 PI    PIAUÍ                    #########
 MT    MATO GROSSO              #########
 MS    MATO GROSSO DO SUL       #########
 MA    MARANHÃO                 #########
 AP    AMAPÁ                    #########
 PE    PERNAMBUCO               ##.#.###.#######-#
 PB    PARAÍBA                  ########-#
 RN    RIO GRANDE DO NORTE      ##.###.###-#
 GO    GOIÁS                    ##.###.###-#
 AM    AMAZONAS                 ##.###.###-#
 CE    CEARÁ                    ########-#
 RR    RORAIMA                  ########-#
 TO    TOCANTINS                ###########
 DF    DISTRITO FEDERAL         ###########-##
 AC    ACRE                     ##.###.###/###-##
 PA    PARÁ                     ##-######-#
 RO    RONDÔNIA                 ###.#####-#
 */