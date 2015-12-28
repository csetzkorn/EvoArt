
using System;

namespace EvoArt.WebApi.Models
{
    public class PayLoad
    {
        public Guid Guid { get; set; }
        public string Svg { get; set; }

        public PayLoad()
        {
            Guid = Guid.NewGuid();

            var random = new Random(Guid.NewGuid().GetHashCode());
            const double min = 100.0;
            var randomNumber1 = (int)min + random.Next(100);
            var randomNumber2 = (int)min + random.Next(100);

//            Svg = string.Format(@"<svg width=""400"" height=""180"">
//                      <rect x=""5"" y=""20"" width=""{0}"" height=""{1}"" style=""fill:blue;stroke:pink;stroke-width:5;fill-opacity:0.1;stroke-opacity:0.9"">
//                      Sorry, your browser does not support inline SVG.  
//                    </svg>", randomNumber1, randomNumber2);
            Svg = @"<?xml version=""1.0"" ?>
<svg xmlns=""http://www.w3.org/2000/svg""
     xmlns:xlink=""http://www.w3.org/1999/xlink""
     width=""600"" height=""400"">
  <defs>
    <path id=""lev0"" fill=""#039"" d=""M0 0,2 0,1 1.732 z"" />
    <g id=""lev1"">
      <use xlink:href=""#lev0"" transform=""matrix(0.5 0 0 0.5  0  0)"" />
      <use xlink:href=""#lev0"" transform=""matrix(0.5 0 0 0.5  1  0)"" />
      <use xlink:href=""#lev0"" transform=""matrix(0.5 0 0 0.5 0.5 0.866)"" />
    </g>
    <g id=""lev2"">
      <use xlink:href=""#lev1"" transform=""matrix(0.5 0 0 0.5  0  0)"" />
      <use xlink:href=""#lev1"" transform=""matrix(0.5 0 0 0.5  1  0)"" />
      <use xlink:href=""#lev1"" transform=""matrix(0.5 0 0 0.5 0.5 0.866)"" />
    </g>
    <g id=""lev3"">
      <use xlink:href=""#lev2"" transform=""matrix(0.5 0 0 0.5  0  0)"" />
      <use xlink:href=""#lev2"" transform=""matrix(0.5 0 0 0.5  1  0)"" />
      <use xlink:href=""#lev2"" transform=""matrix(0.5 0 0 0.5 0.5 0.866)"" />
    </g>
    <g id=""lev4"">
      <use xlink:href=""#lev3"" transform=""matrix(0.5 0 0 0.5  0  0)"" />
      <use xlink:href=""#lev3"" transform=""matrix(0.5 0 0 0.5  1  0)"" />
      <use xlink:href=""#lev3"" transform=""matrix(0.5 0 0 0.5 0.5 0.866)"" />
    </g>
    <g id=""lev5"">
      <use xlink:href=""#lev4"" transform=""matrix(0.5 0 0 0.5  0  0)"" />
      <use xlink:href=""#lev4"" transform=""matrix(0.5 0 0 0.5  1  0)"" />
      <use xlink:href=""#lev4"" transform=""matrix(0.5 0 0 0.5 0.5 0.866)"" />
    </g>
  </defs>
  <use xlink:href=""#lev5"" transform=""translate(50,50) scale(200)"" />
</svg>";
        }
    }
}