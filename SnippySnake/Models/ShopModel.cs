using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippySnake.Models
{
    public class ShopModel
    {
        private readonly List<SkinModel> _snakeSkins;
        private readonly List<SkinModel> _tokenSkins;

        public IReadOnlyList<SkinModel> SnakeSkins => _snakeSkins.AsReadOnly();
        public IReadOnlyList<SkinModel> TokenSkins => _tokenSkins.AsReadOnly();

        public ShopModel()
        {
            _snakeSkins = new List<SkinModel>();
            _tokenSkins = new List<SkinModel>();

            // Initialize snake skins
            _snakeSkins.Add(new SkinModel("Classic", 100));
            _snakeSkins.Add(new SkinModel("Rainbow", 200));
            _snakeSkins.Add(new SkinModel("Metallic", 150));
            _snakeSkins.Add(new SkinModel("Galactic", 250));
            _snakeSkins.Add(new SkinModel("Pixel", 75));

            // Initialize token skins
            _tokenSkins.Add(new SkinModel("Apple", 50));
            _tokenSkins.Add(new SkinModel("Banana", 75));
            _tokenSkins.Add(new SkinModel("Cherry", 100));
            _tokenSkins.Add(new SkinModel("Grapes", 125));
            _tokenSkins.Add(new SkinModel("Watermelon", 150));
        }
    }

}
