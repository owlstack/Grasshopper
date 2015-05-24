﻿using Grasshopper.Assets;
using Grasshopper.Graphics;
using Grasshopper.Graphics.Materials;
using Grasshopper.Graphics.Rendering;
using Grasshopper.SharpDX.Graphics.Materials;
using Grasshopper.SharpDX.Graphics.Rendering;

namespace Grasshopper.SharpDX.Graphics
{
	public class GraphicsContext : IGraphicsContext
	{
		public GraphicsContext(IAssetStore assets)
		{
			DeviceManager = new DeviceManager();
			RenderHostFactory = new RenderHostFactory(this);
			TextureLoader = new TextureLoader(DeviceManager, assets);
			MaterialManager = new MaterialManager(DeviceManager);
			MeshGroupBufferManager = new MeshGroupBufferManager(DeviceManager);

			MeshLibrary = new MeshLibrary();
			TextureLibrary = new TextureLibrary(TextureLoader);
			MaterialLibrary = new MaterialLibrary(TextureLibrary);
		}

		public DeviceManager DeviceManager { get; private set; }
		public IRenderHostFactory RenderHostFactory { get; private set; }
		public ITextureLoader TextureLoader { get; private set; }
		public IMaterialManager MaterialManager { get; private set; }
		public IMeshGroupBufferManager MeshGroupBufferManager { get; private set; }
		public MeshLibrary MeshLibrary { get; private set; }
		public MaterialLibrary MaterialLibrary { get; private set; }
		public TextureLibrary TextureLibrary { get; private set; }

		public void Initialize()
		{
			DeviceManager.Initialize();
		}

		private bool _disposed;
		public void Dispose()
		{
			if(_disposed) return;
			DeviceManager.Dispose();
			_disposed = true;
		}
	}
}
