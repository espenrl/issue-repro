using Esri.ArcGISRuntime.Mapping;
using Map = Esri.ArcGISRuntime.Mapping.Map;

namespace arcgis_runtime_maui_v200_beta;

public partial class MapPage : ContentPage
{
    public MapPage()
    {
        InitializeComponent();

        MapView.Map = new Map
        {
            Basemap = new Basemap(new ArcGISVectorTiledLayer(new Uri("https://services.geodataonline.no/arcgis/rest/services/GeocacheVector/GeocacheGraatone/VectorTileServer")))
        };
    }
}