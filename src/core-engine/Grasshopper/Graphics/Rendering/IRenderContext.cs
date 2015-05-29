using System;

namespace Grasshopper.Graphics.Rendering
{
	public interface IRenderContext : IDisposable
	{
		void MakeActive();
		void Exit();
		bool ExitRequested { get; }
		RasterizerSettings RasterizerSettings { get; }

		void Clear(Color color);
		void SetDrawType(DrawType drawType);
		void UpdateRasterizerState();
	}
}