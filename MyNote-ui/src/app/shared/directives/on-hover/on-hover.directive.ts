import { Directive, ElementRef, HostListener, Input, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appOnHover]'
})
export class OnHoverDirective {
  constructor(private elementRef: ElementRef, private renderer: Renderer2) { }
  @Input() contentColor = "test"
  @HostListener("mouseenter")onHover(){
    this.contentColor = this.elementRef.nativeElement.style.backgroundColor;
    this.renderer.setStyle(this.elementRef.nativeElement, 'background-color', 'red');
  }
  @HostListener('mouseleave') onLeave(){
    this.renderer.setStyle(this.elementRef.nativeElement, 'background-color',this.contentColor??'');
  }
}
