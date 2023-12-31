###Bike Rental App

*Authors*: 
Jacek Cierkosz, 
Paweł Zięba, 
Łukasz Złocki, 

Created at: 
Chmurower Studio

## Intro

*Why/Problem*

With growing popularity of bike tourism, there's a high demand for bike rental services.

Lots of rental companies have problems with managing their resources - bikes, calendar, maintentance.

*How*

We would like to create a cloud application, to allow ease of deployment and configuration, without dependency on costly bare-metal solution, with high availability through web service.

*What*

Creating an app for managing bike rental, with consinderation in bike classes, availability calendar and pricing.

## Goals and Non-Goals

**Goals**:
Applet that allows a categorization of bikes, with differentiation of:
*Mountain Bike
*Road Bike
*City-tourist Bike

Applet that allows checking whether given bike is available at required time,
with possibility of reservation by the person managing the bike rental.

Applet for managing the maintenance of bicycles.

**Non-Goals**:

Overly complicated solutions with too many options. The application is to be lightweight, without needless functions, easy to use.

## Proposed solution


**Desired functions:**

* Grouping resources: 
  MTB / Road / City
* Listing resources:
  All resources / Resources by group.
* Listing available resources by date frame.
  All resources / Resources by group.
* Reservation of resource by date frame and client name.
* List all resources in need of service:
  Resources that will need service soon / Resources in service at the moment.
  
**Database model**:

Table:	Bicycle
		Int: ID
		Foreign Key: Category_id (Type)
		String: Model
		Int: Framesize (14, 15, 16, 17, 18, 19, 20, 21)
		Date-time: Start reservation
		Date-time: End reservation
		Date-time: Start service - 2 days hardcoded
		Bool: 0, 1 - is on stock
		Bool: 0, 1 - is in service
		
Table:	Category
		Int: Category_id (0, 1, 2)
		String: Type (Mtb, road, city)

Technologies:
	Infrastructure: Azure
	Backend: .NET 7.0
	Database: MySQL
		
You might here also touch things, such as testing.

Frontend: for later arrangement.

## Other options

Discarded alternatives.

...

## Open Questions

...

## References