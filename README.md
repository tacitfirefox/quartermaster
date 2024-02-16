# quartermaster
A generic system of party equipment loadouts and their component make-ups that facilitate their craft or customization.

## why?
There's not enough spreadsheet goodness to help me figure out all the items I need to grind when playing Final Fantasy VIII, Final Fantasy X, Final Fantasy XII, Final Fantasy XIII, Dragon Age: Inquisition, and other party-based role-playing games that utilize component items to craft, create, or customize equipment items that I am targeting.

Upon realizing that I wanted a simple means of collating large amount of inventory data across rather different systems and structures, I set out to create an automated means of doing so. 

I chose this particular project (API, GraphQL, python, whatever) to help provide a creative outlet as well as benefit my gaming time.

## how?

### Quartermaster.Core
This project details the skeleton of the quartermaster system. The main interface, IQuartermaster, exposes the necessary means of interacting with the system: provided a collection of party rosters filled with equipment sets, items, and party members, give back the requisite types and amounts of component items required to make those specified equipment items.

The user of the system should create rosters, then check out the rosters with the quartermaster. The quartermaster will provide a receipt (uniquely identifiable by the quartermaster and stamped with the time of the transaction) of these component items.

A quartermaster can provide its registration information upon request. At current, quartermasters have a uniquely-identifiable key string and a human-readable name. Other forms of registration may be expanded on in the future.