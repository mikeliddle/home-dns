# Home-DNS

I've been a long-time pihole user, and recently I got envious of tools that
allow for better home-centric features like disabling the wifi for a time,
being able to block specific things for specific people on a schedule, and
having RBAC for management APIs. Also, why doesn't Pihole have TLS available
for its management page?

With that in mind, and previous experiences to build on, this will be based on
Unbound's DNS server, with a management interface built in Blazor. The product
will be mainly targeted as a container appliance, but because of that, it would
be easy to run this on a linux machine following the patterns in the
dockerfile.

## FAQs

### 1. Why Blazor?

Because I want to learn more about .NET, and blazor is plenty
efficient for a management site that doesn't need HA and billions of users.

### 2. Why Unbound?

Unbound's configuration and records files are based on flat text files, and is
a great easy way to get started on setting up a DNS server. I've worked with it
fairly extensively on other projects testing networking implementations and I
enjoy it. It also has DNSSec, DoT, and DoH implementations, so any desired
security features have a track record of gaining support from unbound.

## Disclaimer

This is not a fork of Unbound. This project is not affiliated with NLNet Labs,
Unbound, Pihole, or any other projects mentioned. All trademarks mentioned are
the property of their respective owners.
