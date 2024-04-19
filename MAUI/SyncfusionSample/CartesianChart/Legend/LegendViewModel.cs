using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public class LegendViewModel : BaseViewModel
    {
        public ObservableCollection<ChartDataModel> ChartData1 { get; set; }
        public ObservableCollection<ChartDataModel> ChartData2 { get; set; }
        public ObservableCollection<ChartDataModel> ChartData3 { get; set; }
        public ObservableCollection<ChartDataModel> ChartData4 { get; set; }


        public Geometry? Truck { get; set; } = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M46.5 22.4813V22.4437C46.503 22.3992 46.4966 22.3545 46.4812 22.3125V22.2562C46.4812 22.2187 46.4625 22.1812 46.4625 22.1437V22.1063L46.425 21.9562H46.4062L43.7812 15.4313C43.5721 14.8602 43.1912 14.3679 42.691 14.0221C42.1907 13.6763 41.5956 13.4939 40.9875 13.5H34.5V12C34.5 11.6022 34.342 11.2206 34.0607 10.9393C33.7794 10.658 33.3978 10.5 33 10.5H4.5C3.70435 10.5 2.94129 10.8161 2.37868 11.3787C1.81607 11.9413 1.5 12.7044 1.5 13.5V34.5C1.5 35.2956 1.81607 36.0587 2.37868 36.6213C2.94129 37.1839 3.70435 37.5 4.5 37.5H6.9375C7.26795 38.7906 8.01855 39.9346 9.07096 40.7515C10.1234 41.5684 11.4177 42.0118 12.75 42.0118C14.0823 42.0118 15.3766 41.5684 16.429 40.7515C17.4814 39.9346 18.232 38.7906 18.5625 37.5H29.4375C29.7679 38.7906 30.5185 39.9346 31.571 40.7515C32.6234 41.5684 33.9177 42.0118 35.25 42.0118C36.5823 42.0118 37.8766 41.5684 38.929 40.7515C39.9814 39.9346 40.732 38.7906 41.0625 37.5H43.5C44.2956 37.5 45.0587 37.1839 45.6213 36.6213C46.1839 36.0587 46.5 35.2956 46.5 34.5V22.5V22.4813ZM34.5 16.5H40.9875L42.7875 21H34.5V16.5ZM4.5 13.5H31.5V25.5H4.5V13.5ZM12.75 39C12.1567 39 11.5766 38.8241 11.0833 38.4944C10.5899 38.1648 10.2054 37.6962 9.97836 37.1481C9.7513 36.5999 9.69189 35.9967 9.80764 35.4147C9.9234 34.8328 10.2091 34.2982 10.6287 33.8787C11.0482 33.4591 11.5828 33.1734 12.1647 33.0576C12.7467 32.9419 13.3499 33.0013 13.898 33.2284C14.4462 33.4554 14.9148 33.8399 15.2444 34.3333C15.5741 34.8266 15.75 35.4067 15.75 36C15.75 36.7956 15.4339 37.5587 14.8713 38.1213C14.3087 38.6839 13.5456 39 12.75 39ZM35.25 39C34.6567 39 34.0766 38.8241 33.5833 38.4944C33.0899 38.1648 32.7054 37.6962 32.4784 37.1481C32.2513 36.5999 32.1919 35.9967 32.3076 35.4147C32.4234 34.8328 32.7091 34.2982 33.1287 33.8787C33.5482 33.4591 34.0828 33.1734 34.6647 33.0576C35.2467 32.9419 35.8499 33.0013 36.398 33.2284C36.9462 33.4554 37.4148 33.8399 37.7444 34.3333C38.074 34.8266 38.25 35.4067 38.25 36C38.25 36.7956 37.9339 37.5587 37.3713 38.1213C36.8087 38.6839 36.0456 39 35.25 39Z"));
        public Geometry? Bus { get; set; } = (Geometry?) (new PathGeometryConverter().ConvertFromInvariantString("M5.34446 13.5821C3.49147 15.1641 3.06941 17.8231 2.22528 23.141L1.42623 28.175C0.956633 31.1334 0.721836 32.6126 1.54597 33.5778C2.3701 34.5431 3.86782 34.5431 6.86326 34.5431H7.60607C7.58365 34.363 7.5721 34.1796 7.5721 33.9934C7.5721 31.5611 9.54387 29.5894 11.9762 29.5894C14.4085 29.5894 16.3803 31.5611 16.3803 33.9934C16.3803 34.1796 16.3687 34.363 16.3463 34.5431H30.7276C30.7052 34.363 30.6937 34.1796 30.6937 33.9934C30.6937 31.5611 32.6654 29.5894 35.0977 29.5894C37.5301 29.5894 39.5018 31.5611 39.5018 33.9934C39.5018 34.1796 39.4903 34.363 39.4679 34.5431H41.1531C43.7483 34.5431 45.0458 34.5431 45.852 33.7369C46.6582 32.9307 46.6582 31.6331 46.6582 29.038V17.5051C46.6582 14.91 46.6582 13.6124 45.852 12.8062C45.0458 12 43.7483 12 41.1531 12H15.2742C9.88968 12 7.19745 12 5.34446 13.5821ZM16.3809 14.7031V19.2082C16.3809 19.4844 16.6047 19.7082 16.8809 19.7082H24.1385C24.4147 19.7082 24.6385 19.4844 24.6385 19.2082V14.7031C24.6385 14.427 24.4147 14.2031 24.1385 14.2031H16.8809C16.6047 14.2031 16.3809 14.427 16.3809 14.7031ZM4.99657 20.6098C5.70336 17.5369 6.05675 16.0004 7.18553 15.1018C8.31431 14.2031 9.89091 14.2031 13.0441 14.2031H13.7278C14.1992 14.2031 14.4349 14.2031 14.5813 14.3496C14.7278 14.496 14.7278 14.7317 14.7278 15.2031V19.1972C14.7278 19.4478 14.7278 19.5731 14.673 19.6802C14.6182 19.7874 14.5167 19.8608 14.3136 20.0076L8.05445 24.5323C6.05924 25.9746 5.06163 26.6958 4.42613 26.2745C3.79063 25.8531 4.06655 24.6535 4.61839 22.2541L4.99657 20.6098ZM34.0467 14.2031H26.7891C26.5129 14.2031 26.2891 14.427 26.2891 14.7031V19.2082C26.2891 19.4844 26.5129 19.7082 26.7891 19.7082H34.0467C34.3229 19.7082 34.5467 19.4844 34.5467 19.2082V14.7031C34.5467 14.427 34.3229 14.2031 34.0467 14.2031ZM36.6992 14.2031H43.9569C44.233 14.2031 44.4569 14.427 44.4569 14.7031V19.2082C44.4569 19.4844 44.233 19.7082 43.9569 19.7082H36.6992C36.4231 19.7082 36.1992 19.4844 36.1992 19.2082V14.7031C36.1992 14.427 36.4231 14.2031 36.6992 14.2031ZM15.0827 34C15.0827 35.6569 13.7395 37 12.0827 37C10.4258 37 9.08267 35.6569 9.08267 34C9.08267 32.3431 10.4258 31 12.0827 31C13.7395 31 15.0827 32.3431 15.0827 34ZM38.0827 34C38.0827 35.6569 36.7395 37 35.0827 37C33.4258 37 32.0827 35.6569 32.0827 34C32.0827 32.3431 33.4258 31 35.0827 31C36.7395 31 38.0827 32.3431 38.0827 34Z"));
        public Geometry? Car { get; set; } = (Geometry?) (new PathGeometryConverter().ConvertFromInvariantString("M14.2097 14.913H10.8352L7.96755 20.6484H11.342L14.2097 14.913ZM32.6055 20.6484L28.0692 14.6C27.3138 13.5928 26.1282 13 24.8692 13H17.3051H16.009H10.8352C10.1106 13 9.44822 13.4094 9.12417 14.0575L5.8287 20.6484H3C2.44772 20.6484 2 21.0962 2 21.6484V31.1267C2 31.679 2.44771 32.1267 3 32.1267H7.73776C7.73857 28.9578 10.3078 26.3891 13.4769 26.3891C16.646 26.3891 19.2152 28.9578 19.216 32.1267H28.7839C28.7847 28.9578 31.3538 26.3891 34.523 26.3891C37.6921 26.3891 40.2613 28.9578 40.2621 32.1267H45C45.5523 32.1267 46 31.679 46 31.1267V26.3886H43.1294C42.6012 26.3886 42.1729 25.9603 42.1729 25.432C42.1729 24.9038 42.6012 24.4755 43.1294 24.4755H45.9963C45.9058 22.3466 44.1512 20.6484 42 20.6484H32.6055ZM13.4769 28.3021C11.3643 28.3021 9.65161 30.0143 9.6508 32.1267H9.6513C9.6513 32.1274 9.6513 32.128 9.6513 32.1287C9.6513 34.2418 11.3643 35.9548 13.4774 35.9548C15.5905 35.9548 17.3035 34.2418 17.3035 32.1287C17.3035 31.0698 16.8733 30.1114 16.1783 29.4187C15.4862 28.7287 14.5314 28.3021 13.4769 28.3021ZM38.3491 32.1267C38.3483 30.0143 36.6356 28.3021 34.523 28.3021C34.2523 28.3021 33.9881 28.3302 33.7333 28.3837C31.9979 28.7467 30.6945 30.2855 30.6945 32.1287C30.6945 34.2418 32.4075 35.9548 34.5206 35.9548C36.6337 35.9548 38.3467 34.2418 38.3467 32.1287C38.3467 32.128 38.3467 32.1274 38.3467 32.1267H38.3491Z"));
        public Geometry? Motorcycle { get; set; } = (Geometry?) (new PathGeometryConverter().ConvertFromInvariantString("M46.9924 15.8474C46.5759 12.7185 36.9677 13.0074 37.4024 14.6708C37.8371 16.3342 34.1432 17.615 34.1432 17.615L28.8328 18.6484C25.6023 16.0817 24.142 15.2774 23.0226 14.5589C18.6727 11.7709 14.112 17.5161 14.112 17.5161C14.112 17.5161 9.88974 17.0006 14.8904 12C-2.51164 20.934 5.77156 22.423 5.77156 22.423H10.6629L9.88193 23.6855C9.1088 23.3445 8.24976 23.1519 7.34386 23.1519C3.84003 23.1519 1 25.9945 1 29.4957C1 32.9996 3.84003 35.8422 7.34386 35.8422C10.8477 35.8422 13.6877 32.9996 13.6877 29.4957C13.6877 27.5304 12.7922 25.7758 11.3865 24.6122L12.0582 23.5241L18.8237 31.0628H19.412H31.6807H33.2009C33.8985 33.8065 36.3819 35.8422 39.3417 35.8422C42.8456 35.8422 45.683 32.9996 45.683 29.4957C45.683 25.9945 42.8456 23.1519 39.3417 23.1519C36.1398 23.1519 33.5003 25.5259 33.0655 28.6081H33.0057C33.0057 28.6081 32.4512 26.5698 31.4646 24.0448C34.7602 22.9436 47.3542 18.5677 46.9924 15.8474ZM7.34647 33.4838C5.14681 33.4838 3.36105 31.6954 3.36105 29.4957C3.36105 27.2961 5.14941 25.5103 7.34647 25.5103C7.79681 25.5103 8.22633 25.5858 8.62982 25.7264L7.25536 27.9547C7.24494 27.9703 7.22672 27.9807 7.21631 27.9989L6.64101 28.9439C6.63841 28.9543 6.64101 28.9595 6.63581 28.9647L6.59416 29.0324L6.60717 29.0428C6.42495 29.4437 6.55251 29.9279 6.94038 30.1647C7.32564 30.399 7.80722 30.2923 8.08055 29.9487L8.09878 29.9617L8.15084 29.8784C8.15344 29.8732 8.15865 29.8706 8.16125 29.868L8.41896 29.4463L10.137 26.6531C10.8763 27.3768 11.3345 28.3842 11.3345 29.4983C11.3319 31.6954 9.54352 33.4838 7.34647 33.4838ZM39.3443 25.5077C41.5414 25.5077 43.3297 27.2961 43.3297 29.4931C43.3297 31.6954 41.5388 33.4812 39.3443 33.4812C37.6991 33.4812 36.283 32.4789 35.6765 31.0576H40.5157V31.0368H40.6277C41.3019 31.0472 41.8564 30.5162 41.8642 29.8394C41.8772 29.1677 41.3383 28.6159 40.6667 28.6029L39.1491 28.5846C39.071 28.582 38.9955 28.5898 38.92 28.6029H35.4604C35.8613 26.8353 37.4466 25.5077 39.3443 25.5077Z"));

        public LegendViewModel()
        {
            ChartData1 = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel( "2005", 38),
                new ChartDataModel( "2006",20),
                new ChartDataModel( "2007",60),
                new ChartDataModel( "2008",50),
            };

            ChartData2 = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel( "2005", 49),
                new ChartDataModel( "2006",40),
                new ChartDataModel( "2007",72),
                new ChartDataModel( "2008",65),
            };

            ChartData3 = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel( "2005", 56),
                new ChartDataModel( "2006", 50),
                new ChartDataModel( "2007", 84),
                new ChartDataModel( "2008", 80),
            };

            ChartData4 = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel( "2005",67),
                new ChartDataModel( "2006",60),
                new ChartDataModel( "2007",96),
                new ChartDataModel( "2008",90),
            };
        }
    }
}