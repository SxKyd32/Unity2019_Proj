using UnityEngine;

public class BoxSelect : MonoBehaviour
{
    private bool onDrawingRect;//画框状态
    private Vector3 startPoint;//框的起始点
    private Vector3 currentPoint;//鼠标实时位置
    private Vector3 endPoint;//框的终止点

    int flag = 0;
    int temp = 0;
    int change = 1;

    Animation soldier;

    public GUIStyle rectStyle;
    public class Selector
    {
        public float Xmin;
        public float Xmax;
        public float Ymin;
        public float Ymax;

        
        //构造函数，在创建选定框时自动计算Xmin/Xmax/Ymin/Ymax
        public Selector(Vector3 start, Vector3 end)
        {
            Xmin = Mathf.Min(start.x, end.x);
            Xmax = Mathf.Max(start.x, end.x);
            Ymin = Mathf.Min(start.y, end.y);
            Ymax = Mathf.Max(start.y, end.y);
        }
    }
    private Selector selector;

    void Update()
    {
        
        //按下鼠标左键,确定框的起始点，画框状态设为true
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            onDrawingRect = true;
            startPoint = Input.mousePosition;
        }
        //未放开鼠标左键时，实时记录鼠标位置
        if (onDrawingRect)
        {
            currentPoint = Input.mousePosition;
        }
        //放开鼠标左键，确定框的终止点，画框状态设为false
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            endPoint = Input.mousePosition;
            onDrawingRect = false;
            //当框画完时，创建一个生效的选定框selector
            selector = new Selector(startPoint, endPoint);
            //执行框选事件
            CheckSelection(selector, "Select");
        }
    }

    void OnGUI()
    {
        if (onDrawingRect)
        {
            //获取确定矩形框各角坐标所需的各个数值
            float Xmin = Mathf.Min(startPoint.x, currentPoint.x);
            float Xmax = Mathf.Max(startPoint.x, currentPoint.x);
            float Ymin = Mathf.Min(startPoint.y, currentPoint.y);
            float Ymax = Mathf.Max(startPoint.y, currentPoint.y);

            //确定方框的定位点（左上角点）的横坐标、纵坐标，以及方框的横向宽度和纵向高度
            Rect rect = new Rect(Xmin, Screen.height - Ymax, Xmax - Xmin, Ymax - Ymin);

            //画框
            GUI.Box(rect, "");
        }
    }

    void CheckSelection(Selector selector, string tag)
    {
        GameObject[] Selects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject Select in Selects)
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(Select.transform.position);
            if (screenPos.x > selector.Xmin && screenPos.x < selector.Xmax
                && screenPos.y > selector.Ymin && screenPos.y < selector.Ymax)
            {
                //Debug.LogFormat("已选中目标:{0}", Select.name);
                soldier = Select.GetComponent<Animation>();

                if (flag == 0)
                {
                    soldier.Play("death_A");
                }
                else if (flag == 1)
                {
                    soldier.Play("combat_idle_aim");
                }
                
                
            }
        }

        // 调整标记，如果flag是0，说明士兵站立，那么可以倒下，如果flag是1，说明士兵倒下，可以站立
        temp = flag;
        flag = change;
        change = temp;
    }
}
