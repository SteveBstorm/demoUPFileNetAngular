import { Component, OnInit } from '@angular/core';
import { UploadService } from '../upload.service';

@Component({
  selector: 'app-upfile',
  templateUrl: './upfile.component.html',
  styleUrls: ['./upfile.component.scss']
})
export class UpfileComponent implements OnInit {

  myFile? : File
  url : string = ""

  constructor(
    private _UpService : UploadService
  ) { }

  ngOnInit(): void {
  }

  loadFile(e : any) {
    this.myFile = e.target.files[0]
  }

  startUpload() {
    if(this.myFile) this._UpService.upload(this.myFile).subscribe((url : string) => {
      this.url = url
    })
  }

}
