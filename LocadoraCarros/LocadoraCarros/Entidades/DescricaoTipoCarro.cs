using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public static class DescricaoTipoCarro {

        public static string Informacao(this int tipoCarro) {
            string descricao = "Carro desconhecido!";
            switch (tipoCarro) {
                case (int)Categoria.HatchCompacto:
                    descricao = "Considerados modelos de entrada, são os mais simples e baratos do mercado. Com opções de três ou cinco portas...";
                    return descricao;
                case (int)Categoria.HatchMédioEsportivo:
                    descricao = "Maiores que os compactos de entrada, os hatches médios têm motor mais forte (com mais potência que o usual 1.0)...";
                    return descricao;
                case (int)Categoria.SedaCompacto:
                     descricao = "São modelos que as montadoras geralmente desenham a partir de hatches compactos - também conhecidos como versões de três volumes...";
                    return descricao;
                case (int)Categoria.SedaMedio:
                    descricao = "Favorito de consumidores de perfil mais conservador, que gostam o design de três volumes e precisam de muito espaço...";
                    return descricao;
                case (int)Categoria.SedaGrandes:
                    descricao = "Luxo e conforto são as palavras de ordem nesta categoria, composta majoritariamente por modelos importados...";
                    return descricao;
                case (int)Categoria.Monovolume:
                    descricao = "Espaço para grandes famílias e conforto para grandes viagens são as principais razões que levam consumidores a escolher carros modelo monovolume...";
                    return descricao;
                case (int)Categoria.Perua:
                    descricao = "O espaço interno das peruas - também conhecidas como station wagons (e daí vem a sigla SW que acompanha o nome de alguns modelos)...";
                    return descricao;
                case (int)Categoria.Picape:
                    descricao = "Originalmente desenhadas como veículos de trabalho, as picapes passaram a ser desejadas por consumidores jovens, ...";
                    return descricao;
                case (int)Categoria.UtilitarioEsportivo:
                    descricao = "Objeto de desejo para quem gosta de viver ao ar livre, os SUVs (Sport Utility Vehicle) ganharam fãs no asfalto...";
                    return descricao;
                default:
                    return descricao;

                    


            }

        }

    }
}
