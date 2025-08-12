import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BasketsModule } from './baskets/baskets-module';
import { HomeModule } from './home/home-module';
import { ProductsModule } from './products/products-module';

@NgModule({
  declarations: [],
  imports: [CommonModule, ProductsModule, BasketsModule, HomeModule],
})
export class ComponentsModule {}
