 using UnityEngine;

 public class MiniMapController
 {
     private MiniMapData _data;
     private Transform _player;
     private Vector3 _vector3;
     private Camera _camera;
     
     public MiniMapController(MiniMapData data)
     {
         _player = data.PlayerPosition;
         _vector3 = data.VectorCameraMiniMap;
         _camera = data.CameraMiniMap;
         _camera.transform.rotation = Quaternion.Euler(90, 0, 90);
     }

     public void MiniMapStart()
     {
         var rt = Resources.Load<RenderTexture>("MapTex");
         _camera.targetTexture = rt;
     }

     public void MiniMapUpdate()
     {
         //var newPosition = _player.transform.position;
         //newPosition.y = _player.position.y;
       _camera.transform.position  =  _player.transform.position + _vector3;
        Debug.Log($"{_camera.transform.position}");
        
        
        
     }
     
     

 }
