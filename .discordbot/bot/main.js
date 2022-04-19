const { Client, Intents } = require('discord.js');

const client = new Client({
    intents: [
      Intents.FLAGS.GUILDS,
      Intents.FLAGS.GUILD_MEMBERS,
      Intents.FLAGS.GUILD_BANS,
      Intents.FLAGS.GUILD_EMOJIS_AND_STICKERS,
      Intents.FLAGS.GUILD_INTEGRATIONS,
      Intents.FLAGS.GUILD_WEBHOOKS,
      Intents.FLAGS.GUILD_INVITES,
      Intents.FLAGS.GUILD_VOICE_STATES,
      Intents.FLAGS.GUILD_PRESENCES,
      Intents.FLAGS.GUILD_MESSAGES,
      Intents.FLAGS.GUILD_MESSAGE_REACTIONS,
      Intents.FLAGS.GUILD_MESSAGE_TYPING,
    ],
  });

client.once('ready', async () => {
    console.log('Online')
    const guild = client.guilds.cache.get('755241392963452947'); /*905260014913069067*/
    let role = guild.roles.cache.find(r => r.name === "Muted")
    console.log(`Found ${role.name}`);
    
    const user = await guild.members.fetch('250599938138832896')
        .catch(console.error);
    await user.roles.add(role).catch(console.error)
})

client.login('OTU1NDU5NjQ0ODU0MjY3OTU0.Yjh_Ig.4GAnTi900oX09FWUe6f4cETw2Og')