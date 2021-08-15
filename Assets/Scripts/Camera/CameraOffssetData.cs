using UnityEngine;

public class CameraOffssetData
{
   private Transform _player;
   private Vector3 _offset;
   private Camera _camera;

   public CameraOffssetData(Transform transform, Vector3 vector3, Camera camera)
   {
       _player = transform;
       _offset = vector3;
       _camera = camera;
   }
   
   public Transform playerTransform { get => _player; }
   public Vector3 Offset { get => _offset; }
   public Camera Camera { get => _camera; }
   
}
