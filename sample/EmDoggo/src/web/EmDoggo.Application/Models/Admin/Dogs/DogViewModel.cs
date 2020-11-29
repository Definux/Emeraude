using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;

namespace EmDoggo.Application.Models.Admin.Dogs
{
    public class DogViewModel : CreateEditEntityViewModel, IMapFrom<Dog>
    {
        [DetailsCard(0, typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsCard(1, typeof(DetailsCardTextElement))]
        public string Name { get; set; }

        [TableColumn(2, typeof(TableTextElement))]
        [DetailsCard(2, typeof(DetailsCardTextElement))]
        public DogType Type { get; set; }

        [TableColumn(3, typeof(TableTextElement))]
        [DetailsCard(3, typeof(DetailsCardTextElement))]
        public DogBreed Breed { get; set; }
    }
}