# SentinelOps AC

SentinelOps is a modular, lore-integrated anti-cheat framework designed for MW2 (2009) dedicated servers. It detects and flags common cheat vectors including wallhacks, aimbots, spinbots, radar/ESP, and offhost exploits. It also includes contributor safe audit trails, factional governance logic, sabotage simulation, and redemption mechanics.

## Disclaimer

This project is currently untested in live environments. It is experimental and may contain bugs, incomplete logic, or edge cases. Use at your own discretion. Testing and feedback are welcome.

## Features

- Detection Vectors: Wallhack, Aimbot, Aimlock, Spinbot, Radar/ESP, Behavioral Fingerprinting
- Audit Trail Logging: JSON based detection logs with replay links and severity scores
- Lore Integration: Flags are tagged with narrative hooks (e.g. "Gyro Destabilizer", "Echo Mapper")
- Factional Governance: Flags interpreted differently by Archivists, Enforcers, and Watchers
- Redemption System: Flagged players can complete missions to restore integrity
- Sabotage Simulator: Simulate cheat behavior to test detection logic
- Legacy Preservation: Export configs and review contributor history

## Installation

Compile and inject the DLL into your MW2 server (e.g. IW4MAdmin plugin folder or via manual injection).

Configure detection toggles in Config/SentinelConfig.ini.

Monitor detection logs in Logs/AuditTrail.json.

## Status

This project is experimental and untested. It has not been validated in production environments. Expect bugs and incomplete features. Use sandbox servers for testing.

## Contributing

Pull requests are welcome. Please submit test cases, detection improvements, lore expansions, or UI dashboards. All contributions should respect the modular, ethical, and contributor-safe design philosophy.
