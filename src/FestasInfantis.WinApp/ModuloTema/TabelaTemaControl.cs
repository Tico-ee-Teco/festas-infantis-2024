﻿
using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();

            foreach (Tema t in temas)
            { 
                grid.Rows.Add(
                    t.Id.ToString(),
                    t.Nome);               
            }

           
        }

       private DataGridViewColumn[] ObterColunas()
       {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
        
            };
        } 

        //ToDo
        //Adicionar zebrado


        

    }
}