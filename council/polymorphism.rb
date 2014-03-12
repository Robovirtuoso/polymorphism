class HighCouncil::Factory
  def self.build(member)
    factory = new(member)
    factory.presenter.new(member)
  end

  def initialize(member)
    @member = member
  end

  def presenter
    HighCouncil.const_get("Presenter::#{member.council_status.camelcase}")
  end
end

# This is our type field
# jedi.council_status
# => 'sith in disguise'
# => 'yoda'
# => 'jedi'

class HighCouncil::Presenter::SithInDisguise
end

class HighCouncil::Presenter::Guest
end

class HighCouncil::Presenter::Yoda
end

class HighCouncil::Presenter::Jedi
  attr_reader :jedi

  def initialize(jedi)
    @jedi = jedi
  end

  def method_missing(sym, *args, &block)
    @jedi.send(sym, args, block)
  end
end
