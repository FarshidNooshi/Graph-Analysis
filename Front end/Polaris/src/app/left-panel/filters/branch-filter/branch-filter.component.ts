import { DataOnScreenService } from './../../../../services/data-on-screen.service';
import { Component, Input, OnInit } from '@angular/core';
import { FilterService } from 'src/services/filter.service';
@Component({
  selector: 'app-branch-filter',
  templateUrl: './branch-filter.component.html',
  styleUrls: ['./branch-filter.component.scss'],
})
export class BranchFilterComponent implements OnInit {
  // @Input()
  public branches: string[] = ["آزادی - یادگار","چهارراه وليعصر","نازی آباد","خیابان ایت اله طالقانی","پاستور","گاندی","میدان حسین آباد","امیر آباد شمالی","احمدیه","استاد حسن بنا","جمالزاده جنوبی","شهید صابونیان","استاد نجات الهی شمالی","چهارراه نیاکان","سید خندان","بیست متری نبرد","قصر","جنت آباد","ورامین","شهران","امیر شرفی","فرهنگسرای بهمن","17شهریور","دوراهی قپان","میرداماد","دکتر مفتح","پیچ شمیران","میدان عطار","اکباتان","فلکه صادقیه","خیابان فدائیان اسلام","شریعتی - پل رومی","میدان سیزده آبان","بورس تهران","شادمهر","ولنجک","امام علی","شهرک راه اهن","نواب","میدان فاطمی","طالقانی","آزادی","قلهک","حکيميه","پانزده خرداد شرقی","آذربایجان","بلوار مرزداران","بلوار شاهد","اندیشه سهروردی","مرزداران","زعفرانیه","خیابان باهنر تهران","امين","صادقیه","خیابان ایرانشهر","سمنگان","دردشت","سه راه فتح","فردوسی شمالی","سهروردی شمالی تهران","میدان نبوت","پیروزی","بازار بلور ایران","میدان بهارستان","بلوار ناهید","تجریش","فاطمی","وحدت","جاویدالاثر عباس کهن","شهر قدس","بازار مسگرها","میدان منیریه","سید جمال الدین اسدآبادی","شهرآرا","فـلکه دوم نيروی هوايی","شهید قندی","اسلامشهر","سی متری نيروی هوايی","چهارراه گرگان شهید نامجو","پل تهران نو","ميدان انقلاب","سه راه وحیدیه","خيابان بوعلی","شهرآرای","میدان ولیعصر","طالقانی شرقی","بلوار شهید فرحزادی","میدان هفتم تیر","پرفسور حسابی","ناصر خسرو","خیابان آزادی شادمهر","اقدسیه","بازار","علامه شمالی","امیرکبیر","ظفر","پامنار جنوبی","سرچشمه","گلوبندک","بلوار آفريقا","سرای آزادی","بنیاد","دربند","شهید قنبری","ديباجی جنوبی","استاد مطهری","خوارزمی","لیزینگ","رسالت - کرمان","مقدس‌ اردبيلی","بومهن دماوند","خاورشهر","پانزده خرداد غربی","فلکه دوم نیرو هوایی","شهید سرافراز","امام خمينی-حسن آباد","سه راه آذری","چهارراه‌ رشيد","اباذر","میدان نوبنیاد","خیابان ملاصدرا","ولی عصر – دستگردی","اذری","خیابان ستارخان","جیحون","خانی آباد نو","چهار راه شمس","شهرداری منطقه 14","تهرانپارس","قایم مقام فراهانی","افسریه شمالی","ایت اله سعیدی","چهارراه مولوی","خیابان قصرالدشت","شمس آباد","پل رومی","فرخی یزدی","لاله ملت","12 فروردین","گلبرگ شرقی","بیست و یک متری جی","مستقل بیهقی تهران","شهرک والفجر تهران","بازار سنگ و فلزات","سعادت آباد - میدان کاج","طالقانی غربی","چهار راه قصر","بزرگمهر","میدان پونک","آرژانتین-الوند","توانیر ولی عصر","اسکان","شهریار","ایت اله کاشانی","میدان صنعت","بانک پارسیا فلکه سوم تهرانپارس","تهران شرق","فرجام شرقی","اسکندری شمالی","اختیاریه جنوبی","بیمارستان ولی عصر","بهرود","کوی دانشگاه","باقرشهر","امیریه","برج میلاد","سعدی شمالی","ابوذر فلاح","شهرک اميد","خیرآباد ورامین","بلوار کشاورز","مهدیه تهران","سلمان","گیلاوند دماوند","نجات الهی جنوبی","شادآباد","دولت آباد","منیریه","مجیدیه","فرخی","نیاوران","احمد قصیر","سه راه ضرابخانه","بلوار ابوذر","امام خمینی","پارک بهمن","خيابان آيت","جویبار نارمک","بازار مبل یافت آباد","بزرگراه فتح","فـردوسـی","ابزار یراق ","سی تیر","بلوار فردوس","پرواز","قیطریه","شهید بهشتی","میدان قزوین","فرودگاه مهرآباد","نبوت","میدان قدس","یوسف آباد","دادمان","حسینیه ارشاد","24 متری سعادت آباد","بلوار آفریقا","چهارراه شمس","فدائیان اسلام","میدان تجریش","سعادت آباد","شهرک راه آهن","پیامبر","کوی نصر","سه راه سلیمانیه","شمیران","شهید کیائی نژاد","آفریقا شمالی","اوين","سید جمال الدین اسد آبادی","تهرانسر","فارابی","اسلامبول","امین الملک","جاده مازندران","اسلام آباد افسریه","هدایت","جمالزاده شمالی",  "چهار راه جمهوری","اریکه ایرانیان","پاکنژاد","ستارخان","بنی هاشم","فرشته","خیابان درازشیب","پالایشگاه تهران","تهرانپارس - رشید","دولت","حکیمیه","خواجه عبدالله انصاری","تهران نوی","اشرفی اصفهانی","میدان شهداء","چهاردانگه","بهشت زهرا","فرجام","یافت آباد","جمهوری - پل حافظ","لاله","چمن و سامان","میرداماد - اسکان","شهرک اکباتان","میدان انقلاب","خیابان جمهوری","پاسداران","شهید مدنی","پرند","صنعتی تهران","میدان فرهنگ","بازار مبل ايران","بلوار دریا","ولیعصر","خیابان توحید","کمالی","دانشکده اقتصاد","سه راه امین حضور","پونک تهران","شيخ بهايی","نارنجستان یوسف آباد","میدان حسن آباد","آبشار","هلال احمر","خواجه نصیرالدین طوسی","چهارده متری لشگر","شریعتی مطهری","امام حسين","طرشت","ملاصدرا","سئول","شهید بخارائی","تختی","میدان خراسان","شهید صمدی","اميريه","ایرانمهر","میدان ولی عصر","20 متری ابوذر","سهروردی شمالی","موزه ملی قران کریم","مطهری-سنایی","پامنار","الهیه- آقا بزرگی","ولیعصر - پارک ساعی","مولوی غربی","خیابان میرزای شیرازی","مرکزی تهران","ایستگاه مدرسه ضرابخانه","قشلاق","ملت","خیابان سلسبیل شمالی","سرافراز"] ;
  public selectedBranches: string[] = [];
  public searchedBranches: string[] = [];
  constructor(
    public filterService: FilterService,
  ) {}
  ngOnInit(): void {
    this.searchedBranches = this.branches;
  }
  public updateResult(input: string){
    this.searchedBranches = [];
    this.branches.forEach((element) => {
          this.searchedBranches.push(element);
      });
    let temp : string[]=[];
    for(let i=0 ; i<this.searchedBranches.length ; i++) {
      if (this.searchedBranches[i].indexOf(input) != -1 ){
          temp.push(this.searchedBranches[i]);
          }
      }
     this.searchedBranches = [];
     temp.forEach((element)=>{
        this.searchedBranches.push(element);
     });
  }
  public isBranchSelected(branchName : string){
    return this.selectedBranches.indexOf(branchName) === -1 ? false : true ;
  }
  public changeChecked(branch: string, isChecked: boolean) {
    let index = this.selectedBranches.indexOf(branch, 0);
    if (isChecked && index === -1) {
      this.selectedBranches.push(branch)
    }
    else if(!isChecked && index !=-1){
      this.selectedBranches.splice(index, 1);
    }
    this.filterService.branches = this.selectedBranches;
  }
  public h(){
    console.log("helllo saba $ mahla");
  }
}
