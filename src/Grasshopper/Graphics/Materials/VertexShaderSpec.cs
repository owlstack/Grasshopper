using System.Collections.Generic;

namespace Grasshopper.Graphics.Materials
{
	public class VertexShaderSpec : ShaderSpec
	{
		public VertexShaderSpec(string source,
			IEnumerable<ShaderInputElementSpec> perVertexElements,
			IEnumerable<ShaderInputElementSpec> perInstanceElements = null) : base(source)
		{
			PerVertexElements = perVertexElements;
			PerInstanceElements = perInstanceElements ?? new ShaderInputElementSpec[0];
		}

		public IEnumerable<ShaderInputElementSpec> PerVertexElements { get; private set; }
		public IEnumerable<ShaderInputElementSpec> PerInstanceElements { get; private set; }
	}
}