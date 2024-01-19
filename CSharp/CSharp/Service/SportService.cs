using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Service
{
    public class SportService
    {
        //1.站立-静止-地面：1
        //2.走路-移动-地面：2-3-48-47
        //3.跑-移动-地面：49-50-51-52
        //4.坐-静止-地面：11
        //5.坐着抬头看-静止-地面：26
        //6.坐着抬头看鼠标-静止-地面：26，11
        //7.撒花：15-16-17-104-105-106-107-108-109-110-111-112
        //8.打枪：30-31-32-31
        //9.趴着：21
        //10.趴着拍打地面：20-21-20-94
        //11.抓住天花板-静止-顶部：23
        //12.顺着天花板-移动-顶部：25-25-23-24-24-24-23-25
        //13.靠墙-移动-左侧：14-14-12-13-13-13-12-14
        //14.带着IE掉下来-嵌入:36
        //15.带着IE走路-地面-嵌入：34-35-37-36
        //16.投IE-地面-嵌入：38
        //17.跳跃-嵌入：22
        //18.坠落-嵌入：4-53-4-54
        //19.坠落后撩头发：55-56-57-58-59-60-61-62-63
        //20.摔倒-固定-地面：19-18-19-18-21-21
        //21.拎起来后抵抗-嵌入：5-6-5-6-96-97-98-95-99-95-99-95-99-95-99-95-99-95-100-101-100-101-5-6-5-6-5-6-102-103
        //22.变身1-固定-地面：73-76-77-78-74-75-70-79-80
        //23.变身2-静止-地面：80
        //24.不要不要：66-71-66-72
        //25.抓住窗口：9-9-9
        public SportService(string path = "default")
        {
            this.path = path;
        }
        string path = "default";

        private string format(int i = 1)
        {
            return Path.Combine("mod",path,"shime" + i + ".png") ;
        }
        
        public List<Image> getBmp(int[] i)
        {
            List<Image> images = new List<Image>();
            for (int j = 0; j < i.Count(); j++)
            {
                images.Add(Image.FromFile(format(i[j])));
            }
            return images;
        }

        private Image[] init(int[] i)
        {
            Image[] map = new Image[i.Count()];
            for (int j = 0; j < i.Count(); j++)
            {
                map[j] = Image.FromFile(format(i[j]));
            }
            return map;
        }
    }
}
