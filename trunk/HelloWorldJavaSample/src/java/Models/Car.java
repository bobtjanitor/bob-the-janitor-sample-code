/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.math.BigDecimal;

/**
 *
 * @author Richard
 */
public class Car {
    private Long id;
	private Brand brand;
	private String model;
	private BigDecimal price;
 
	public Long getId() {
		return id;
	}
	public void setId(Long id) {
		this.id = id;
	}
	public Brand getBrand() {
		return brand;
	}
	public void setBrand(Brand brand) {
		this.brand = brand;
	}
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public BigDecimal getPrice() {
		return price;
	}
	public void setPrice(BigDecimal price) {
		this.price = price;
	}
}
