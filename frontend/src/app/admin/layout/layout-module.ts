import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ComponentsModule } from './components/components-module';
import { Layout } from './layout';

@NgModule({
  declarations: [],
  imports: [CommonModule, Layout, ComponentsModule],
  exports: [Layout],
})
export class LayoutModule {}
