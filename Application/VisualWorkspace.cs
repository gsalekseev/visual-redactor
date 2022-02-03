using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Application.Abstract;
using Domain;

namespace Application
{
    public class VisualWorkspace : IVisualWorkspace
    {
        private readonly ISceneRepository _sceneLoader; 
        private readonly IRenderer<LightSource> _lightRenderer; 
        private readonly IRenderer<VisualModel> _modelRenderer; 
        private readonly IRenderer<Camera> _cameraRenderer; 
        private readonly IPolygonEditor _polygonEditor;
        private readonly IViewProjector _projector;
        private readonly ILightsEditor _lightsEditor;
        private readonly ICameraEditor _cameraEditor;
        private readonly ILightProcessor _lightProcessor;

        public VisualWorkspace(ISceneRepository sceneLoader, IRenderer<LightSource> lightRenderer,
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
        
        public Bitmap Present(Guid selectedCameraId)
        {
            var camera = this.CurrentScene.Cameras.First(c => c.Id == selectedCameraId);
            
            _lightProcessor.ApplyLightToModel(camera, CurrentScene.Model, CurrentScene.LightSources);
            _projector.ProjectView(camera, CurrentScene.Model);
            
            var modelBitmap = _modelRenderer.Render(CurrentScene.Model);
            return modelBitmap;
        }

        public void SetCurrentScene(string path)
        {
            CurrentScene = _sceneLoader.Get(path);
        }

        public void SaveModelToFile(string path)
        {
            var bitmap = _modelRenderer.Render(CurrentScene.Model);
            using var f = File.Create(path);
            bitmap.Save(f, ImageFormat.Bmp);
        }

        public void SavePresentationToFile(Guid presentationCameraId, string path)
        {
            var presentation = Present(presentationCameraId);
            using var f = File.Create(path);
            presentation.Save(f, ImageFormat.Bmp);
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