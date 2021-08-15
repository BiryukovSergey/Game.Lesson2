using UnityEngine;

public class FlyController : IExecute
    {
        private Transform _pos;
        private float _numeric;
        private FLyPanelData _data;

       public FlyController(FLyPanelData data)
        {
            _pos = data.Pos;
            _numeric = data.Numeric;
        }
        
        private void Fly()
        {
            _pos.position = new Vector3(_pos.position.x, Mathf.PingPong(Time.time, _numeric),
                _pos.transform.position.z);
        }

        public void Range()
        {
            _numeric = Random.Range(2.0f, 4.0f);
        }
        public void Update()
        {
            Fly();
        }
    }
