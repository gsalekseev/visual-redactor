using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Application.Abstract;
using Domain;
using Infrastructure;

namespace Application
{
    public class VisualWorkspace : IVisualWorkspace
    {
        private readonly ISceneLoader _sceneLoader; 
        private readonly IRenderer<LightSource> _lightRenderer; 
        private readonly IRenderer<VisualModel> _modelRenderer; 
        private readonly IRenderer<Camera> _cameraRenderer; 
        private readonly IPolygonEditor _polygonEditor;
        private readonly IViewProjector _projector;
        private readonly ILightsEditor _lightsEditor;
        private readonly ICameraEditor _cameraEditor;
        private readonly ILightProcessor _lightProcessor;

        public VisualWorkspace(ISceneLoader sceneLoader, IRenderer<LightSource> lightRenderer,
            IRenderer<VisualModel> modelRenderer, IRenderer<Camera> cameraRenderer,
            IViewProjector projector, ILightsEditor lightsEditor, IPolygonEditor polygonEditor,
            ICameraEditor cameraEditor, ILightProcessor lightProcessor)
        {
            _sceneLoader = sceneLoader;
            _lightRenderer = lightRenderer;
            _modelRenderer = modelRenderer;
            _cameraRenderer = cameraRenderer;
            _polygonEditor = polygonEditor;
            _projector = projector;
            _lightsEditor = lightsEditor;
            _cameraEditor = cameraEditor;
            _lightProcessor = lightProcessor;
        }
        
        public Scene CurrentScene { get; set; }
        
        public Bitmap Present()
        {
            PreparePresentation();
            
            var camerasBitmaps = CurrentScene.Cameras.Select(c => _cameraRenderer.Render(c));
            var lightsBitmap = CurrentScene.LightSources.Select(c => _lightRenderer.Render(c));
            var modelBitmap = _modelRenderer.Render(CurrentScene.Model);

            var allBitmaps = new List<Bitmap>();
            allBitmaps.AddRange(camerasBitmaps);
            allBitmaps.AddRange(lightsBitmap);
            allBitmaps.Add(modelBitmap);

            return allBitmaps.Aggregate(ConcatBitmaps);
        }

        public void SetCurrentScene(string path)
        {
            CurrentScene = _sceneLoader.Load(path);
        }

        public void SaveToFile(string path)
        {
            var bitmap = Present();
            using var f = File.Create(path);
            bitmap.Save(f, ImageFormat.Bmp);
        }

        private void PreparePresentation()
        {
            _lightProcessor.ApplyLightToModel(CurrentScene.Model, CurrentScene.LightSources);
            _projector.ProjectView(CurrentScene.Cameras, CurrentScene.Model);
        }

        private Bitmap ConcatBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
           //логика по склеиванию рисунков
           return new(1, 1);
        }
       
        //...
        //остальные методы по работе с камерой, светом и прочее
    }
}