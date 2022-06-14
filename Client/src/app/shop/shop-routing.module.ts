import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { ShopComponent } from './shop.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';


const routes: Routes = [

  { path: '', component: ShopComponent},
  { path: ':id', component: ProductDetailComponent }


];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports:[
    RouterModule
  ]
})
export class ShopRoutingModule { }
